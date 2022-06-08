using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_2022.Classes.Room
{
    internal class Room_Bill_DB
    {
        DatabaseOperating databaseOperating = new DatabaseOperating();  
        
        public int Get_idRoomBill_On_idRoom(string RoomID)
        {
            try 
            {
                int idRoomBill = 0;
                SqlCommand command = new SqlCommand("SELECT idRoomBill FROM RoomBill WHERE idRoom = @ID", databaseOperating.GetConnection);

                command.Parameters.Add("@ID", SqlDbType.NVarChar).Value = RoomID;
                command.Connection = databaseOperating.GetConnection;

                databaseOperating.openConnection();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    idRoomBill = Int32.Parse(reader["idRoomBill"].ToString());
                }
                reader.Close();
                databaseOperating.closeConnection();
                return idRoomBill;
            }
            
        
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }

        }
    }
}
