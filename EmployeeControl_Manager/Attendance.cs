using Final_Project_2022.Classes;
using Final_Project_2022.Classes.Shift;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_2022.EmployeeControl_Manager
{
    public partial class Attendance : Form
    {


        ShiftDB shiftDB = new ShiftDB();
        AttendanceDB attendance = new AttendanceDB();

     
        TimeSpan loginTime = CurrentUser.LoginTime.TimeOfDay;
        TimeSpan startTime, endTime;
        string weekDate = DateTime.Now.DayOfWeek.ToString();
        string shift_type;


        public Attendance()
        {
            InitializeComponent();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            
            TimeSpan startTime = TimeSpan.Parse(labelStartTime.Text);
            TimeSpan endTime = TimeSpan.Parse(labelCheckOutTime.Text);
            
            DateTime date_time_now = DateTime.Now;

            if (attendance.IsEmployeeCheckIn(CurrentUser.Id, DateTime.Now.TimeOfDay) == false)
            {
                attendance.MakeCheckInForEmployee(CurrentUser.Id, weekDate, startTime, endTime, date_time_now);
                buttonCheckIn.Text = "Check IN Completed";
                
            }
            else
            {
                buttonCheckIn.Text = "CHECK OUT";
                attendance.MakeCheckOutForEmployee(CurrentUser.Id, weekDate, startTime, endTime, date_time_now);
                buttonCheckIn.Text = "Check Out Completed";
            }
           
        }

        void LoadData()
        {
            DateTime dateTime = DateTime.Now;   
            dataGridViewSchedule.AllowUserToAddRows = false;
            dataGridViewSchedule.DataSource = shiftDB.GetDataTableSchedulesOfEmployee(weekDate, CurrentUser.Id);


            ScheduleModel currentSchedule = shiftDB.GetSchedulesOfEmployee(CurrentUser.Id, weekDate, loginTime);

            if (currentSchedule.Week_date == dateTime.DayOfWeek.ToString() && CurrentUser.Id == currentSchedule.Employee_id)
            {
                if (loginTime >= currentSchedule.Start_time && loginTime <= currentSchedule.End_time)
                {
                    if (attendance.IsEmployeeCheckIn(CurrentUser.Id, DateTime.Now.TimeOfDay) == false)
                    {

                        buttonCheckIn.Enabled = true;
                        labelShiftAnnouncement.Text = "Shift Info.";
                        labelStartTime.Text = currentSchedule.Start_time.ToString();
                        labelCheckOutTime.Text = currentSchedule.End_time.ToString();
                        textBoxShiftType.Text = currentSchedule.Shift_type.ToString();

                    }
                    else
                    {
                        buttonCheckIn.Text = "Checked In Already Progressed";
                        labelShiftAnnouncement.Text = "Remember to check out on time.";
                        labelStartTime.Text = currentSchedule.Start_time.ToString();
                        labelCheckOutTime.Text = currentSchedule.End_time.ToString();
                        textBoxShiftType.Text = currentSchedule.Shift_type.ToString();
                    }
                }
                else if (dateTime.Hour - currentSchedule.End_time.Hours <= 1 && dateTime.Hour - currentSchedule.End_time.Hours >= -1)
                {
                    buttonCheckIn.Text = "Check out";
                    labelShiftAnnouncement.Text = "Beware, you need to check out!";
                    labelStartTime.Text = currentSchedule.Start_time.ToString();
                    labelCheckOutTime.Text = currentSchedule.End_time.ToString();
                    textBoxShiftType.Text = currentSchedule.Shift_type.ToString();
                }
                else if (dateTime.Hour - currentSchedule.End_time.Hours > 1)
                {
                    buttonCheckIn.Enabled = false;
                    buttonCheckIn.Text = "Check out DISABLED";
                    labelShiftAnnouncement.Text = "Out of Check-Out-time interval!";
                }
            }             
            else
            {
                buttonCheckIn.Enabled = false;
                buttonCheckIn.Text = "Not In Current Ship";
                labelShiftAnnouncement.Text = "You don't have any shift currently!";
                labelStartTime.Visible = false;
                labelCheckOutTime.Visible = false;
                textBoxShiftType.Visible = false;
            }


        }
    }
}
