using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Final_Project_2022.Classes;
namespace Final_Project_2022.Classes
{

    public class ServicesDB
    {
        DatabaseOperating databaseOperating = new DatabaseOperating();
        public bool InsertNewServices(int ID, string serviceName, string unit, string Instock, int price)
        {
            SqlCommand command = new SqlCommand("INSERT INTO services (ID, ServiceName, Unit, Price, InStock) VALUES (@ID, @svname, @unit, @price, @IS)", databaseOperating.GetConnection);
            command.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@svname", SqlDbType.NVarChar).Value = serviceName;
            command.Parameters.Add("@unit", SqlDbType.NVarChar).Value = unit;
            command.Parameters.Add("@IS", SqlDbType.NVarChar).Value = Instock;
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

        //check if serviceName exist
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

        //get table of all services
        public DataTable getAllServices()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM services", databaseOperating.GetConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //remove service based on name
        public bool deleteService(int ID)
        {
            //
            SqlCommand command = new SqlCommand("DELETE FROM services WHERE ID= @cID", databaseOperating.GetConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = ID;

            databaseOperating.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() == 1))
                {
                    // Delete thanh cong
                    databaseOperating.closeConnection();
                    return true;
                }
                else
                {
                    // nguoc lai
                    databaseOperating.closeConnection();
                    return false;
                }
            }
            catch
            {
                databaseOperating.closeConnection();
                return false;
            }
            //
        }

        public bool updateService(int ID, string serviceName, string unit, int price,string InStock)
        {
            SqlCommand command = new SqlCommand("UPDATE services"
            + " SET ServiceName = @SN, Unit = @unit, Price = @price, InStock = @IS WHERE ID = @cID", databaseOperating.GetConnection);

            command.Parameters.Add("@cID", SqlDbType.Int).Value = ID;
            command.Parameters.Add("@SN", SqlDbType.NVarChar).Value = serviceName;
            command.Parameters.Add("@unit", SqlDbType.NVarChar).Value = unit;
            command.Parameters.Add("@price", SqlDbType.Int).Value = price;
            command.Parameters.Add("@IS", SqlDbType.NVarChar).Value = InStock;

            databaseOperating.openConnection();
            try
            {
                // update thanh cong
                if ((command.ExecuteNonQuery() == 1))
                {
                    databaseOperating.closeConnection();
                    return true;
                }
                // nguoc lai
                else
                {
                    databaseOperating.closeConnection();
                    return false;
                }
            }
            catch
            {
                databaseOperating.closeConnection();
                return false;
            }
        }
    }
}
