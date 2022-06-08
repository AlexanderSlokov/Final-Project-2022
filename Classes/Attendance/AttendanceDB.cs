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
    public class AttendanceDB
    {
        DatabaseOperating connection = new DatabaseOperating();
        public bool IsEmployeeCheckIn(int employee_id, TimeSpan check_in)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Salary as sa INNER JOIN schedule as s " +

                "ON sa.start_Time = s.start_Time AND sa.end_Time = s.end_Time AND " +

                "sa.employee_ID = s.employee_ID AND sa.week_Date = s.weekDate " +
            
                "WHERE EXISTS (" +

                "SELECT * FROM  Salary as sal INNER JOIN schedule as sc " +

                "ON sal.start_Time = sc.start_Time AND sal.end_Time = sc.end_Time AND " +

                "sal.employee_ID = sc.employee_ID AND sal.week_Date = sc.weekDate " +

                "WHERE @check_in <= sc.end_Time AND @check_in >= sc.start_Time AND sal.employee_ID = @employee_id) ", connection.GetConnection);

            if (employee_id == 0)
            {
                MessageBox.Show("Please Enter Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employee_id;
            command.Parameters.Add("@check_in", SqlDbType.Time).Value = check_in;

           
            connection.openConnection();
            try
            {
                if (command.ExecuteScalar() == null)
                {
                    connection.closeConnection();
                    return false;
                }
                else
                {
                    connection.closeConnection();
                    return true;
                }
            }
            catch
            {
                connection.closeConnection();
                return false;
            }
        }

        public bool MakeCheckInForEmployee(int employee_id, string weekDate, TimeSpan startTime, TimeSpan endTime, DateTime check_in_date_time)
        {

            SqlCommand command = new SqlCommand("INSERT INTO Salary (employee_ID, week_Date, start_Time, end_Time, check_In) " +
                "VALUES ( @employee_id, @weekDate, @startTime, @endTime, @check_in)", connection.GetConnection);

            #region catch empty input
            if (employee_id == 0)
            {
                MessageBox.Show("Please Enter Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employee_id;

            if (weekDate == String.Empty)
            {
                MessageBox.Show("Please Enter week Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;
            #endregion

            command.Parameters.Add("@startTime", SqlDbType.Time).Value = startTime;
            command.Parameters.Add("@endTime", SqlDbType.Time).Value = endTime;
            command.Parameters.Add("@check_in", SqlDbType.DateTime).Value = check_in_date_time;

            connection.openConnection();
            try
            {
                if ((command.ExecuteNonQuery() == 1))
                {
                    MessageBox.Show("Check IN Sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.closeConnection();
                    return true;

                }
                else
                {
                    connection.closeConnection();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

            public bool MakeCheckOutForEmployee(int employee_id, string weekDate, TimeSpan startTime, TimeSpan endTime, DateTime check_out_date_time)
            {

                SqlCommand command = new SqlCommand("UPDATE Salary SET check_Out = @check_out " +
                    "WHERE employee_ID = @employee_id AND week_Date = @weekDate AND start_Time = @startTime AND end_Time = @endTime", connection.GetConnection);

                #region catch empty input
                if (employee_id == 0)
                {
                    MessageBox.Show("Please Enter Employee", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@employee_id", SqlDbType.Int).Value = employee_id;

                if (weekDate == String.Empty)
                {
                    MessageBox.Show("Please Enter week Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                command.Parameters.Add("@weekDate", SqlDbType.NVarChar).Value = weekDate;
            #endregion


                command.Parameters.Add("@startTime", SqlDbType.Time).Value = startTime;
                command.Parameters.Add("@endTime", SqlDbType.Time).Value = endTime;
                command.Parameters.Add("@check_out", SqlDbType.DateTime).Value = check_out_date_time;

                connection.openConnection();
                try
                {
                    if ((command.ExecuteNonQuery() == 1))
                    {
                        MessageBox.Show("Check OUT Sucessfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        connection.closeConnection();
                        return true;

                    }
                    else
                    {
                        connection.closeConnection();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error in Executing sql: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        
    }
}
