using Final_Project_2022.Classes.Shift;
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
            SqlCommand command = new SqlCommand("INSERT INTO schedule (employee_ID, employee_Name, employee_Position, weekDate, shift_Type, start_Time, end_Time) VALUES (@ID, @Name, @Pos, @WDate, @Type, @Start, @End)", DbOperating.GetConnection);

            //catch id empty
            if (employee_id == 0)
            {
                MessageBox.Show("Please Enter Employee ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@ID", SqlDbType.Int).Value = employee_id;

            //catch name empty
            if (employee_name.Trim() == "")
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
            if (shift_type.Trim() == "")
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
            SqlCommand command = new SqlCommand("SELECT * FROM schedule WHERE employee_ID = @employee_id AND start_Time = @startTime AND end_Time = @endTime AND weekDate = @weekDate", DbOperating.GetConnection);

            command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employee_id;
            command.Parameters.Add("@startTime", SqlDbType.Time).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.Time).Value = endTime;
            command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;

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

        public bool DeleteShift(int employeeID, string employeeName, string employeePosition, string weekDate, string shiftType, TimeSpan startTime, TimeSpan endTime)
        {
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM schedule WHERE employee_ID = @employee_id AND employee_Name = @employee_name AND employee_Position = @employee_position AND weekDate = @weekDate AND shift_Type = @shift_type AND start_Time = @startTime AND end_Time = @endTime ", DbOperating.GetConnection);

                command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employeeID;
                command.Parameters.Add("@employee_name", SqlDbType.NVarChar).Value = employeeName;
                command.Parameters.Add("@employee_position", SqlDbType.NVarChar).Value = employeePosition;
                command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;
                command.Parameters.Add("@shift_type", SqlDbType.NVarChar).Value = shiftType;
                command.Parameters.Add("@startTime", SqlDbType.Time).Value = startTime;
                command.Parameters.Add("@endTime", SqlDbType.Time).Value = endTime;

                DbOperating.openConnection();
                if ((command.ExecuteNonQuery() >= 1))
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
            catch
            {
                return false;
            }
        }

        public bool DeleteAllShifts()
        {
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM schedule", DbOperating.GetConnection);


                DbOperating.openConnection();
                if ((command.ExecuteNonQuery() >= 1))
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
            catch
            {
                return false;
            }
        }

        public bool UpdateShift(int employee_id, string employee_name, string employee_position, string weekDate, string shiftType, TimeSpan startTime, TimeSpan endTime)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE schedule SET employee_ID = @employee_id, employee_Name = @employee_name, employee_Position = @employee_position, weekDate = @weekDate, shift_Type = @shift_type, start_Time = @startTime, end_Time = @endTime WHERE employee_ID = @employee_id AND start_Time = @startTime AND end_Time = @endTime", DbOperating.GetConnection);

                //
                if (employee_id == 0)
                {
                    MessageBox.Show("Please Enter Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employee_id;

                if (employee_name == String.Empty)
                {
                    MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@employee_name", SqlDbType.NVarChar).Value = employee_name;

                if (employee_position == String.Empty)
                {
                    MessageBox.Show("Please Enter Employee Position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@employee_position", SqlDbType.NVarChar).Value = employee_position;

                if (weekDate == String.Empty)
                {
                    MessageBox.Show("Please Enter week Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;

                if (shiftType == String.Empty)
                {
                    MessageBox.Show("Please Enter Shift Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@shift_type", SqlDbType.NVarChar).Value = shiftType;

                command.Parameters.Add("@startTime", SqlDbType.Time).Value = startTime;
                command.Parameters.Add("@endTime", SqlDbType.Time).Value = endTime;

                //
                DbOperating.openConnection();
                if ((command.ExecuteNonQuery() >= 1))
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
            catch
            {
                return false;
            }
        }

        public DataTable GetDataTableSchedulesOfEmployee(string weekDate, int employee_id)
        {
            SqlCommand command = new SqlCommand("SELECT start_Time as 'Check In Time', " +
                "end_Time as 'Check Out time', shift_Type as 'Shift Type' " +
                "FROM schedule " +
                "WHERE weekDate = @weekDate AND employee_ID = @employee_id", DbOperating.GetConnection);

            if (employee_id == 0)
            {
                MessageBox.Show("Please Enter Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employee_id;


            if (weekDate == String.Empty)
            {
                MessageBox.Show("Please Enter week Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;

            command.Connection = DbOperating.GetConnection;
            DbOperating.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            DataSet dataSet = new DataSet();
            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "schedule");
            dataTable = dataSet.Tables["schedule"];

            DbOperating.closeConnection();
            return dataTable;
        }






        public ScheduleModel GetSchedulesOfEmployee(int employeeID, string weekDate, TimeSpan loginTime)
        {
            ScheduleModel schedule = new ScheduleModel();

            SqlCommand command = new SqlCommand("SELECT employee_ID as ID, start_Time as 'Check In Time', " +
                "end_Time as 'Check Out time', shift_Type as 'Shift Type' " +
                "FROM schedule " +
                "WHERE weekDate = @weekDate AND employee_ID = @employee_id AND " +
                "@loginTime <= end_Time  AND @loginTime >= start_Time", DbOperating.GetConnection);
            
            if (employeeID == 0)
            {
                MessageBox.Show("Please Enter Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employeeID;

            if (weekDate == String.Empty)
            {
                MessageBox.Show("Please Enter week Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;
            
            command.Parameters.Add("@loginTime", SqlDbType.Time).Value = loginTime;
           

            command.Connection = DbOperating.GetConnection;
            DbOperating.openConnection();
            SqlDataReader reader = command.ExecuteReader();

            schedule.Week_date = weekDate;

            while (reader.Read())
            {
                schedule.Employee_id = Int32.Parse(reader["ID"].ToString());
                schedule.End_time = TimeSpan.Parse(reader["Check Out time"].ToString());
                schedule.Start_time = TimeSpan.Parse(reader["Check In Time"].ToString());
                schedule.Shift_type = reader["Shift Type"].ToString();
            }
            reader.Close();


            DbOperating.closeConnection();
            return schedule;
        }
    }   
}
