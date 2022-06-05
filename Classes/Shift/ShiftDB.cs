using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_2022.Classes
{
    public class ShiftDB
    {
        DatabaseOperating DbOperating = new DatabaseOperating();

        public bool InsertShift(int employee_id, string employee_name, string employee_position, string week_date, string shift_type, TimeSpan start_time, TimeSpan end_Time)
        {
            //insert Command string query 
            SqlCommand command = new SqlCommand ("INSERT INTO schedule (employee_ID, employee_Name, employee_Position, weekDate, shift_Type, start_Time, end_Time) VALUES (@ID, @Name, @Pos, @WDate, @Type, @Start, @End)", DbOperating.GetConnection);
            
            //catch id empty
            if (employee_id == 0 )
            {
                MessageBox.Show("Please Enter Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@ID", SqlDbType.Int).Value = employee_id;

            //catch name empty
            if(employee_name.Trim() == "")
            {
                MessageBox.Show("Please Enter Employee Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }                                               //them shiftType
            command.Parameters.Add("@Name", SqlDbType.NVarChar).Value = employee_name;

            //catch Pos empty
            if (employee_position.Trim() == "")
            {
                MessageBox.Show("Please Enter Employee Position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@Pos", SqlDbType.NVarChar).Value = employee_position;

            //catch weekdate empty
            if (week_date.Trim() == "")
            {
                MessageBox.Show("Please Enter Weekdate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@WDate", SqlDbType.NVarChar).Value = week_date;

            //catch Shift type empty
            if(shift_type.Trim() == "")
            {
                MessageBox.Show("Please Enter shift Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@Type", SqlDbType.NVarChar).Value = shift_type;

            //not need to catch input time since the value had been fixed in form.
            command.Parameters.Add("@Start", SqlDbType.Time).Value = start_time;
            command.Parameters.Add("@End", SqlDbType.Time).Value = end_Time;
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

        public bool isShiftExists(int employee_id, TimeSpan startTime, TimeSpan endTime, string weekDate)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM schedule WHERE employee_id = @employee_id AND startTime = @startTime AND endTime = @endTime AND weekDate = @weekDate", DbOperating.GetConnection);

            command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employee_id;          
            command.Parameters.Add("@startTime", SqlDbType.Time).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.Time).Value = endTime;
            command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;
            command.CommandType = CommandType.StoredProcedure;
            DbOperating.openConnection();
            try
            {
                if (command.ExecuteScalar() == null)
                {
                    DbOperating.closeConnection();
                    return false;
                }
                else
                {
                    DbOperating.closeConnection();
                    return true;
                }
            }
            catch
            {
                DbOperating.closeConnection();
                return false;
            }
        }

        public DataTable GetDataTableAllSchedules()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM schedule", DbOperating.GetConnection);

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

        public DataTable getEmployeeInfoByID(int ID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE id = @cID", DbOperating.GetConnection);
            command.Parameters.Add("@cID", SqlDbType.Int).Value = ID;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}
