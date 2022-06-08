using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_2022.Classes.Shift
{
    public class ScheduleModel
    {
        int employee_id;
        string employee_name;
        string employee_pos;
        string week_date;
        string shift_type;
        TimeSpan start_time;
        TimeSpan end_time;

       public int Employee_id { get { return employee_id; } set { employee_id = value; } }  
        public string Employee_name { get { return employee_name; } set { employee_name = value; } }    
        public string Employee_pos { get { return employee_pos; } set { employee_pos = value; } }
        public string Week_date{get { return week_date; } set { week_date = value; } }
        public string Shift_type { get { return shift_type; } set { shift_type = value; } } 
        
        public TimeSpan Start_time { get => start_time; set => start_time = value; }

        public TimeSpan End_time { get => end_time; set => end_time = value;}

    }
}
