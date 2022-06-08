using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_2022.Classes.Salary
{
    public class SalaryModel
    {
        int employee_id;
        string week_date;
        TimeSpan start_time;
        TimeSpan end_time;
        DateTime check_in;
        DateTime check_out;
        string status;

        public int Employee_id { get => employee_id; set => employee_id = value; }
        public string Week_date { get => week_date; set => week_date = value; }
        public TimeSpan Start_time { get => start_time; set => start_time = value; }
        public TimeSpan End_time { get => end_time; set => end_time = value; }
        public DateTime Check_in { get => check_in; set => check_in = value; }
        public DateTime Check_out { get => check_out; set => check_out = value; }
        public string Status { get => status; set => status = value; }
    }
}
