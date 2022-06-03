using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Final_Project_2022.Classes;
namespace Final_Project_2022.Classes
{
   
    internal class ServicesDB
    {
        DatabaseOperating databaseOperating = new DatabaseOperating();
        public bool InsertNewServices(string serviceName, string unit, int price)
        {
            SqlCommand command = new SqlCommand("INSERT INTO services (ServiceName, Unit, Price) VALUES (@svname, @unit, @price)", databaseOperating.GetConnection);
            command.Parameters.Add("@svname", SqlDbType.NVarChar).Value = serviceName;
            command.Parameters.Add("@unit", SqlDbType.NVarChar).Value = unit;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            databaseOperating.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                databaseOperating.closeConnection();
                return true;
            }
            else
            {
                databaseOperating.closeConnection();
                return false;

            }

        }

        // get data table fill in gridview based on command
        public DataTable getServiceList(SqlCommand command)
        {
            command.Connection = databaseOperating.GetConnection;
            databaseOperating.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "services");
            dataTable = dataSet.Tables["services"];
            databaseOperating.closeConnection();
            return dataTable;

        }

       //fill gridview with search on service name
        public DataTable GetServices(int name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM services WHERE ServiceName = @SvName", databaseOperating.GetConnection);

            command.Parameters.Add("@SvName", SqlDbType.Int).Value = name;
            command.Connection = databaseOperating.GetConnection;

            databaseOperating.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;

        }

        public bool checkServiceName(string serviceName)
        {
            //
            SqlCommand command = new SqlCommand("SELECT * FROM services WHERE ServiceName = @cSN", databaseOperating.GetConnection);

            command.Parameters.Add("@cSN", SqlDbType.NVarChar).Value = serviceName;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);
            // neu ton tai
            if ((table.Rows.Count > 0))
            {
                return false;
            }
            // nguoc lai
            else
            {
                return true;
            }
            //
        }
    }
}
