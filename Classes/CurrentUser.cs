using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
//SQL command classes based on this 
using System.IO;
using System.Windows.Forms;

namespace Final_Project_2022.Classes
{
    public static class CurrentUser
    {
        private static int id;
        
        
        private static string pass;
        private static string userName;
        
        private static string name;
        private static string gender;
        private static DateTime bdate;
        private static string email;
        private static string phone ;
       
        private static string pos;
        private static float salary_per_hour;

        private static Image image;

        private static DateTime loginTime;
        private static DateTime lastLoginTime;

        public static int Id { get => id; set => id = value; }
        
        public static string Pass { get => pass; set => pass = value; }
        public static string UserName { get => userName; set => userName = value; }
        public static string Name { get => name; set => name = value; }
        public static string Gender { get => gender; set => gender = value; }
        public static DateTime Bdate { get => bdate; set => bdate = value; } 
        public static string Email { get => email; set => email = value; }
        public static string Phone { get => phone; set => phone = value; }      
        public static string Pos { get => pos; set => pos = value; }       
        public static float Salary_per_hour { get => salary_per_hour; set => salary_per_hour = value; }   
        public static Image Image { get => image; set => image = value; }
        public static DateTime LoginTime { get => loginTime; set => loginTime = value; }
        public static DateTime LastLoginTime { get => lastLoginTime; set => lastLoginTime = value; }

        public static void setUser(EmployeeModel employee)
        {
            Id = employee.Id;
            UserName = employee.Username;
            Pass = employee.Password;
            Name = employee.Name;
            Gender = employee.Gender;
            Bdate = employee.BirthDate;
            Email = employee.Email;
            Phone = employee.PhoneNum;
            Pos = employee.Position;
            Salary_per_hour = employee.Salary_per_hour;
            Image = employee.Image;

        }

    }

   
}
