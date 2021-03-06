using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_2022.Classes;

namespace Final_Project_2022.Classes
{
    
    public class EmployeeDB
    {
        DatabaseOperating connection = new DatabaseOperating();
        public bool login(string username, string password)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE username = @User AND password = @Pass", connection.GetConnection);
            command.Parameters.Add("@User", SqlDbType.VarChar).Value = username;
            command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = password;
            adapter.SelectCommand = command;
            connection.openConnection();
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }



        public EmployeeModel GetEmployeeByID(int id)
        {
            EmployeeModel employee = new EmployeeModel();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE id = @id", connection.GetConnection);
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    employee.Id = Int32.Parse(reader["id"].ToString());
                    employee.Name = reader["name"].ToString();
                    employee.Position = reader["position"].ToString();
                    employee.BirthDate = DateTime.Parse(reader["birthDate"].ToString());
                    employee.Gender = reader["gender"].ToString();
                    employee.PhoneNum = reader["phoneNum"].ToString();
                    employee.Email = reader["email"].ToString();
                    try
                    {
                        MemoryStream stream = new MemoryStream((byte[])reader["image"]);
                        Image RetImage = Image.FromStream(stream);
                        employee.Image = RetImage;
                    }
                    catch (Exception ex)
                    {
                        employee.Image = null;
                    }
                    employee.Salary_per_hour = float.Parse(reader["salary_per_hour"].ToString());
                    employee.Username = reader["username"].ToString();
                    employee.Password = reader["password"].ToString();
                }
                reader.Close();
                connection.closeConnection();
                employee.SetAge();
                return employee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public EmployeeModel GetEmployeeByUsername(string username)
        {

            EmployeeModel employee = new EmployeeModel();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE username = @username", connection.GetConnection);
                command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    employee.Id = Int32.Parse(reader["id"].ToString());
                    employee.Name = reader["name"].ToString();
                    employee.Position = reader["position"].ToString();
                    employee.BirthDate = DateTime.Parse(reader["birthDate"].ToString());
                    employee.Gender = reader["gender"].ToString();
                    employee.PhoneNum = reader["phoneNum"].ToString();
                    employee.Email = reader["email"].ToString();
                    employee.Image = Image.FromStream((MemoryStream)reader["image"]);
                    employee.Salary_per_hour = float.Parse(reader["salary_per_hour"].ToString());
                    employee.Username = reader["username"].ToString();
                    employee.Password = reader["password"].ToString();
                }
                reader.Close();
                connection.closeConnection();
                return employee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }



        public bool IsEmployeeExistByID(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE id = @id", connection.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            connection.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }
        public bool IsEmployeeExistByUsername(string username)
        {

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE username = @username", connection.GetConnection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            adapter.SelectCommand = command;
            connection.openConnection();
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }
        public bool UpdateEmployee(EmployeeModel employee, int oldID, string oldUsername)
        {

            if (employee.Id == 0)
            {
                MessageBox.Show("Please Enter ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsEmployeeExistByID(employee.Id) && employee.Id != oldID)
            {
                MessageBox.Show("ID existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (employee.Id == oldID)
            {
                // Update
                SqlCommand command = new SqlCommand("UPDATE employee SET name = @name, position = @position, " +
                            "birthDate = @birthDate, gender = @gender, phoneNum = @phoneNum, email = @email, image = @image, " +
                            "salary_per_hour = @salary_per_hour, username = @username, password = @password WHERE id = @id", connection.GetConnection);
                
                command.Parameters.Add("@id", SqlDbType.Int).Value = employee.Id;
                if (employee.Name == String.Empty || employee.Name == null)
                {
                    MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@name", SqlDbType.VarChar).Value = employee.Name;
                if (employee.Position == String.Empty || employee.Position == null)
                {
                    MessageBox.Show("Please Enter Position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@position", SqlDbType.VarChar).Value = employee.Position;
                command.Parameters.Add("@birthDate", SqlDbType.DateTime).Value = employee.BirthDate;
                command.Parameters.Add("@gender", SqlDbType.VarChar).Value = employee.Gender;
                if (employee.PhoneNum == String.Empty || employee.PhoneNum == null)
                {
                    MessageBox.Show("Please Enter Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@phoneNum", SqlDbType.VarChar).Value = employee.PhoneNum;
                if (employee.Email == String.Empty || employee.Email == null || DataValidate.emailValidate(employee.Email) == false)
                {
                    MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@email", SqlDbType.VarChar).Value = employee.Email;

                MemoryStream memoryStream = new MemoryStream();
                if (employee.Image != null)
                {
                    employee.Image.Save(memoryStream, employee.Image.RawFormat);
                    command.Parameters.Add("@image", SqlDbType.Image).Value = memoryStream.ToArray();
                }
                else
                {
                    command.Parameters.Add("@image", SqlDbType.Image).Value = DBNull.Value;
                }
                if (employee.Salary_per_hour == 0)
                {
                    MessageBox.Show("Please Enter Salary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@salary_per_hour", SqlDbType.Real).Value = employee.Salary_per_hour;
                if (employee.Username == String.Empty || employee.Username == null)
                {
                    MessageBox.Show("Please Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else if (this.IsEmployeeExistByUsername(employee.Username) == true && employee.Username != oldUsername)
                {
                    MessageBox.Show("Username Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@username", SqlDbType.VarChar).Value = employee.Username;
                if (employee.Password == String.Empty || employee.Password == null)
                {
                    MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@password", SqlDbType.VarChar).Value = employee.Password;


                connection.openConnection();
                try
                {
                    if ((command.ExecuteNonQuery() == 1))
                    {
                        MessageBox.Show("Update New Employee Sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.closeConnection();
                        return true;

                    }
                    else
                    {
                        connection.closeConnection();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else if (employee.Id != oldID)
            {
                // Delete Old ID
                this.DeleteEmployee(oldID);
                // Insert
                this.AddEmployee(employee);
            }
            return false;
        }
        public bool AddEmployee(EmployeeModel employee)
        {
            SqlCommand command = new SqlCommand("INSERT INTO employee (id, name, position, birthDate, gender, phoneNum, email, image, salary_per_hour, username, password)"
                + " VALUES (@id, @name, @position, @birthDate, @gender, @phoneNum, @email, @image, @salary_per_hour, @username, @password)", connection.GetConnection);

            if (employee.Id == 0)
            {
                MessageBox.Show("Please Enter ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsEmployeeExistByID(employee.Id))
            {
                MessageBox.Show("ID existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@id", SqlDbType.Int).Value = employee.Id;
            if (employee.Name == String.Empty || employee.Name == null)
            {
                MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@name", SqlDbType.VarChar).Value = employee.Name;
            if (employee.Position == String.Empty || employee.Position == null)
            {
                MessageBox.Show("Please Enter Position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@position", SqlDbType.VarChar).Value = employee.Position;
            command.Parameters.Add("@birthDate", SqlDbType.DateTime).Value = employee.BirthDate;
            command.Parameters.Add("@gender", SqlDbType.VarChar).Value = employee.Gender;
            if (employee.PhoneNum == String.Empty || employee.PhoneNum == null)
            {
                MessageBox.Show("Please Enter Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@phoneNum", SqlDbType.VarChar).Value = employee.PhoneNum;
            if (employee.Email == String.Empty || employee.Email == null || DataValidate.emailValidate(employee.Email) == false)
            {
                MessageBox.Show("Please Enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@email", SqlDbType.VarChar).Value = employee.Email;

            MemoryStream memoryStream = new MemoryStream();
            if (employee.Image != null)
            {
                employee.Image.Save(memoryStream, employee.Image.RawFormat);
                command.Parameters.Add("@image", SqlDbType.Image).Value = memoryStream.ToArray();
            }
            else
            {
                command.Parameters.Add("@image", SqlDbType.Image).Value = DBNull.Value;
            }
            if (employee.Salary_per_hour == 0)
            {
                MessageBox.Show("Please Enter Salary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@salary_per_hour", SqlDbType.Real).Value = employee.Salary_per_hour;
            if (employee.Username == String.Empty || employee.Username == null)
            {
                MessageBox.Show("Please Enter Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (this.IsEmployeeExistByUsername(employee.Username) == true)
            {
                MessageBox.Show("Username Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = employee.Username;
            if (employee.Password == String.Empty || employee.Password == null)
            {
                MessageBox.Show("Please Enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@password", SqlDbType.VarChar).Value = employee.Password;


            connection.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() == 1))
                {
                    MessageBox.Show("Insert New Employee Sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.closeConnection();
                    return true;

                }
                else
                {
                    connection.closeConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool DeleteEmployee(int ID)
        {
            SqlCommand command = new SqlCommand("DELETE FROM employee WHERE id = @id", connection.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            connection.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() >= 1))
                {
                    // Delete thanh cong
                    //MessageBox.Show("De New Employee Sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.closeConnection();
                    return true;
                }
                else
                {
                    // nguoc lai
                    connection.closeConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        public DataTable GetAllEmployee_ForComnboBox_Schedule ()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM employee", connection.GetConnection);
            connection.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.closeConnection();
            return table;
        }
        public DataTable GetEmployeesDataTable()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE position = @position", connection.GetConnection);
            command.Parameters.Add("@position", SqlDbType.NVarChar).Value = "Employee";
            connection.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            connection.closeConnection();
            return table;
        }
        public DataTable GetManagersDataTable()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE position = @position", connection.GetConnection);
            command.Parameters.Add("@position", SqlDbType.NVarChar).Value = "Manager";
            connection.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            connection.closeConnection();
            return table;
        }
        public DataTable GetLaborDataTable()
        { 
            SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE position = @position", connection.GetConnection);
            command.Parameters.Add("@position", SqlDbType.NVarChar).Value = "Labor";
            connection.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            connection.closeConnection();
            return table;
        }
        public List<EmployeeModel> GetManagersList()
        {
            List<EmployeeModel> employeeList = new List<EmployeeModel>();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE position = @position", connection.GetConnection);
                command.Parameters.Add("@position", SqlDbType.NVarChar).Value = "Manager";

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeModel employee = new EmployeeModel();
                    employee.Id = Int32.Parse(reader["id"].ToString());
                    employee.Name = reader["name"].ToString();
                    employee.Position = reader["position"].ToString();
                    employee.BirthDate = DateTime.Parse(reader["birthDate"].ToString());
                    employee.Gender = reader["gender"].ToString();
                    employee.PhoneNum = reader["phoneNum"].ToString();
                    employee.Email = reader["email"].ToString();
                    employee.Image = Image.FromStream((MemoryStream)reader["image"]);
                    employee.Salary_per_hour = float.Parse(reader["salary_per_hour"].ToString());
                    employee.Username = reader["username"].ToString();
                    employee.Password = reader["password"].ToString();
                    employeeList.Add(employee);
                }
                reader.Close();
                connection.closeConnection();
                return employeeList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


        public Stack<EmployeeModel> GetEmployeesStack()
        {
            Stack<EmployeeModel> employeesStack = new Stack<EmployeeModel>();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE position = @position ", connection.GetConnection);
               
                command.Parameters.Add("@position", SqlDbType.NVarChar).Value = "Employee";
                
                connection.openConnection();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeModel employee = new EmployeeModel();

                    employee.Id = Int32.Parse(reader["id"].ToString());
                    employee.Name = reader["name"].ToString();
                    employee.Position = reader["position"].ToString();
                    employee.BirthDate = DateTime.Parse(reader["birthDate"].ToString());
                    employee.Gender = reader["gender"].ToString();
                    employee.PhoneNum = reader["phoneNum"].ToString();
                    employee.Email = reader["email"].ToString();
                    try
                    {
                        MemoryStream stream = new MemoryStream((byte[])reader["image"]);
                        Image RetImage = Image.FromStream(stream);
                        employee.Image = RetImage;
                    }
                    catch (Exception ex)
                    {
                        employee.Image = null;
                    }
                    employee.Salary_per_hour = float.Parse(reader["salary_per_hour"].ToString());
                    employee.Username = reader["username"].ToString();
                    employee.Password = reader["password"].ToString();
                    employeesStack.Push(employee);
                }
                reader.Close();
                connection.closeConnection();
                return employeesStack;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public Stack<EmployeeModel> GetManagersStack()
        {
            Stack<EmployeeModel> managersStack = new Stack<EmployeeModel>();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE position = @position", connection.GetConnection);
                
                command.Parameters.Add("@position", SqlDbType.NVarChar).Value = "Manager";

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeModel manager = new EmployeeModel();

                    manager.Id = Int32.Parse(reader["id"].ToString());
                    manager.Name = reader["name"].ToString();
                    manager.Position = reader["position"].ToString();
                    manager.BirthDate = DateTime.Parse(reader["birthDate"].ToString());
                    manager.Gender = reader["gender"].ToString();
                    manager.PhoneNum = reader["phoneNum"].ToString();
                    manager.Email = reader["email"].ToString();
                    try
                    {
                        MemoryStream stream = new MemoryStream((byte[])reader["image"]);
                        Image RetImage = Image.FromStream(stream);
                        manager.Image = RetImage;
                    }
                    catch (Exception ex)
                    {
                        manager.Image = null;
                    }
                    manager.Salary_per_hour = float.Parse(reader["salary_per_hour"].ToString());
                    manager.Username = reader["username"].ToString();
                    manager.Password = reader["password"].ToString();
                    managersStack.Push(manager);
                }
                reader.Close();
                connection.closeConnection();
                return managersStack;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public Stack<EmployeeModel> GetLaborsStack()
        {
            Stack<EmployeeModel> laborsStack = new Stack<EmployeeModel>();
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE position = @position", connection.GetConnection);
               
                command.Parameters.Add("@position", SqlDbType.NVarChar).Value = "Labor";

                connection.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    EmployeeModel labor = new EmployeeModel();

                    labor.Id = Int32.Parse(reader["id"].ToString());
                    labor.Name = reader["name"].ToString();
                    labor.Position = reader["position"].ToString();
                    labor.BirthDate = DateTime.Parse(reader["birthDate"].ToString());
                    labor.Gender = reader["gender"].ToString();
                    labor.PhoneNum = reader["phoneNum"].ToString();
                    labor.Email = reader["email"].ToString();
                    try
                    {
                        MemoryStream stream = new MemoryStream((byte[])reader["image"]);
                        Image RetImage = Image.FromStream(stream);
                        labor.Image = RetImage;
                    }
                    catch (Exception ex)
                    {
                        labor.Image = null;
                    }
                    labor.Salary_per_hour = float.Parse(reader["salary_per_hour"].ToString());
                    labor.Username = reader["username"].ToString();
                    labor.Password = reader["password"].ToString();
                    laborsStack.Push(labor);
                }
                reader.Close();
                connection.closeConnection();
                return laborsStack;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}
