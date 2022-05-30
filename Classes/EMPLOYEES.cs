using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//SQL command classes based on this 
using System.IO;
using System.Windows.Forms;

namespace Final_Project_2022.Classes
{
     class EMPLOYEES
    {
        DatabaseOperating dsop = new DatabaseOperating();

        public EmployeeModel getDataOnUserName(string username)
        {
            EmployeeModel employee = new EmployeeModel();       
            try
            {
                //use SQL command to get all data
                SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE username = @UserName", dsop.GetConnection);
                command.Parameters.Add("@UserName", SqlDbType.NVarChar).Value = username;
                dsop.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                //read data on that id
                while (reader.Read())
                {
                    
                    
                    employee.Id =  Convert.ToInt32(reader["id"]);
                    employee.Username = reader["username"].ToString();
                    employee.Password = reader["password"].ToString();
                    employee.Name = reader["name"].ToString();
                    employee.Gender = reader["gender"].ToString();
                    employee.BirthDate = Convert.ToDateTime(reader["birthDate"].ToString());
                    employee.Email = reader["email"].ToString();
                    employee.PhoneNum = reader["phoneNum"].ToString();
                    employee.Position = reader["position"].ToString();
                    employee.Salary_per_hour = float.Parse(reader["salary_per_hour"].ToString());

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
                    
                }
                reader.Close();
                dsop.closeConnection();
                return employee;
            }

            catch (Exception ex)
            {
                return null;
            }


        }

        public DataTable getEmployee(SqlCommand command)
        {
            command.Connection = dsop.GetConnection;
            dsop.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "employee");
            dataTable = dataSet.Tables["employee"];
            dsop.closeConnection();
            return dataTable;

        }
    }
}
