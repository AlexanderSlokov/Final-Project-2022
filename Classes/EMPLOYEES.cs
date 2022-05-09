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
                SqlCommand command = new SqlCommand("SELECT * FROM HumanResourse", dsop.GetConnection);
                //command.Parameters.Add("@UserName", SqlDbType.Int).Value = CurrentUser.UserName;
                dsop.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                //read data on that id
                while (reader.Read())
                {
                    
                    
                    CurrentUser.Id =  Convert.ToInt32(reader["ID"]);
                    CurrentUser.Manager_id = reader["ManagerID"].ToString();

                    CurrentUser.UserName = reader["UserName"].ToString();
                    CurrentUser.Pass = reader["Password"].ToString();   
                    
                    CurrentUser.Name = reader["Name"].ToString();
                    CurrentUser.Gender = reader["Gender"].ToString();
                    CurrentUser.Bdate = reader["Bdate"].ToString();
                    CurrentUser.Email = reader["Email"].ToString();
                    CurrentUser.Phone = reader["Phone"].ToString();
                    CurrentUser.Address = reader["Address"].ToString();
                    CurrentUser.Pos = reader["Position"].ToString();
                    CurrentUser.BasicSalary = reader["BasicSalary"].ToString();

                    MemoryStream stream = new MemoryStream((byte[])reader["picture"]);
                    Image RetImage = Image.FromStream(stream);
                    CurrentUser.Image.Image = RetImage;
                }
                reader.Close();
                dsop.closeConnection();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }


        }
    }
}
