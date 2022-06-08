using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_2022.Classes.Service
{
    public class Service_Order
    {
        DatabaseOperating DbOperating = new DatabaseOperating();

        public bool InsertServiceOrder( int idRoomBill, string service_name, string order_date, int num)
        {
            

            //insert Command string query 
            SqlCommand command = new SqlCommand("INSERT INTO ServiceBill (idRoomBill, ServiceName, OrderDate, Amount) VALUES (@ID, @svname, @date, @num)", DbOperating.GetConnection);
           
            //catch input empty
            if (idRoomBill == 0)
            {
                MessageBox.Show("Please Enter Room ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = idRoomBill;

            if (service_name.Trim() == "")
            {
                MessageBox.Show("Please Enter service name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@svname", SqlDbType.NVarChar).Value = service_name;
            command.Parameters.Add("@date", SqlDbType.DateTime).Value = order_date ;
            
            if (num == 0)
            {
                MessageBox.Show("Please Enter Valid Order Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@num", SqlDbType.Int).Value = num;

            DbOperating.openConnection();
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    DbOperating.closeConnection();
                    return true;
                }
                else
                {
                    DbOperating.closeConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
