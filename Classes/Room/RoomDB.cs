using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_2022.Classes.Room
{
    public class RoomDB
    {
        DatabaseOperating connection = new DatabaseOperating(); 
        public DataTable GetAllRoom_ForComboBox()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Room", connection.GetConnection);
            connection.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.closeConnection();
            return table;
        }

        public DataTable GetAllRoom_InUse_ForComboBox()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Room WHERE Status = N'In Use' ", connection.GetConnection);
            connection.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.closeConnection();
            return table;
        }
    }
}
