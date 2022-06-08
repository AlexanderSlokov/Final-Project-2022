using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_2022.Classes.Salary
{
    internal class SalaryDB
    {
        DatabaseOperating DbOperating = new DatabaseOperating();
        public DataTable GetDataTable_Salary()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Salary", DbOperating.GetConnection);

            command.Connection = DbOperating.GetConnection;
            DbOperating.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "std");

            dataTable = dataSet.Tables["std"];

            DbOperating.closeConnection();
            return dataTable;
        }

        public bool IsEmployeeExistByID(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM salary_report WHERE report_id = @id", DbOperating.GetConnection);
         
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            DbOperating.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if ((table.Rows.Count > 0))
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

        public bool Add_Employee_SalaryReport(int id, int working, int late, int salary, string status)
        {
            SqlCommand command = new SqlCommand("INSERT INTO salary_report (employee_id, working_hours, late_hours, salary, status) "
                + " VALUES (@id, @working, @late, @salary, @status)", DbOperating.GetConnection);

            
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@working", SqlDbType.Int).Value = working;
            command.Parameters.Add("@late", SqlDbType.Int).Value = late;          
            command.Parameters.Add("@salary", SqlDbType.Int).Value = salary ;
            command.Parameters.Add("@status", SqlDbType.VarChar).Value = status ;

            DbOperating.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() == 1))
                {
                    MessageBox.Show("Insert New Salary Record Sucessfully, remember to print before 6:30 AM", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DbOperating.closeConnection();
                    return true;

                }
                else
                {
                    DbOperating.closeConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
