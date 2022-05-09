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
        private static string manager_id;
        
        private static string pass;
        private static string userName;
        
        private static string name;
        private static string gender;
        private static string bdate;
        private static string email;
        private static string phone ;
        private static string address;
        private static string pos;
        private static string basicSalary;

        private static PictureBox image;

        public static int Id { get => id; set => id = value; }
        public static string Manager_id { get => manager_id; set => manager_id = value; }
        public static string Pass { get => pass; set => pass = value; }
        public static string UserName { get => userName; set => userName = value; }
        public static string Name { get => name; set => name = value; }
        public static string Gender { get => gender; set => gender = value; }
        public static string Bdate { get => bdate; set => bdate = value; } 
        public static string Email { get => email; set => email = value; }
        public static string Phone { get => phone; set => phone = value; }
        public static string Address { get => address; set => address = value; }
        public static string Pos { get => pos; set => pos = value; }       
        public static string BasicSalary { get => basicSalary; set => basicSalary = value; }   
        public static PictureBox Image { get => image; set => image = value; }


        
        
    }
}
