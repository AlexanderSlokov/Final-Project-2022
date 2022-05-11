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

        public void getDataOnUserName ()
        {
            try
            {
                //use SQL command to get all data
                SqlCommand command = new SqlCommand("SELECT * FROM employee", dsop.GetConnection);
                //command.Parameters.Add("@UserName", SqlDbType.Int).Value = CurrentUser.UserName;
                dsop.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                //read data on that id
                while (reader.Read())
                {
                    
                    
                    CurrentUser.Id =  Convert.ToInt32(reader["id"]);                 
                    CurrentUser.UserName = reader["username"].ToString();
                    CurrentUser.Pass = reader["password"].ToString();                      
                    CurrentUser.Name = reader["name"].ToString();
                    CurrentUser.Gender = reader["gender"].ToString();
                    CurrentUser.Bdate = reader["birthDate"].ToString();
                    CurrentUser.Email = reader["email"].ToString();
                    CurrentUser.Phone = reader["phoneNum"].ToString();                   
                    CurrentUser.Pos = reader["position"].ToString();
                    CurrentUser.Salary_per_hour = reader["salary_per_hour"].ToString();
                    MemoryStream stream = new MemoryStream((Byte)reader["image"]);
                    Image RetImage = Image.FromStream(stream);
                    CurrentUser.Image = RetImage;
                }
                reader.Close();
                dsop.closeConnection();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
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
