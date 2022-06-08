using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project_2022.Classes;

namespace Final_Project_2022.Classes
{
    public class EmployeeModel
    {
        private int id;
        

        private string username;
        private string password;

        private string name;
        private string position;
        private DateTime birthDate;
        private string gender;
        private string phoneNum;
        private string email;
        private Image image;
        private float salary_per_hour;       
        private int age;

        public int Id { get => id; set => id = value; }
       
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
        public string Position { get => position; set => position = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Gender { get => gender; set => gender = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Email { get => email; set => email = value; }
        public Image Image { get => image; set => image = value; }
        public float Salary_per_hour { get => salary_per_hour; set => salary_per_hour = value; }        
        public int Age { get => age; }

        public EmployeeModel()
        {
            DateTime now = DateTime.Today;
            this.age = now.Year - BirthDate.Year;
            if (now < BirthDate.AddYears(Age))
                this.age--;
        }

        public void SetAge()
        {
            DateTime now = DateTime.Today;
            this.age = now.Year - BirthDate.Year;
            if (now < BirthDate.AddYears(Age))
                this.age--;
        }

        public EmployeeModel(int id, int manager_id, string name, string position, DateTime birthDate, string gender, string phoneNum, string email, Image image, float salary_per_hour, string username, string password, string address)
        {
            this.Id = id;          
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Gender = gender;            
            this.BirthDate = birthDate;
            this.Email = email;
            this.PhoneNum = phoneNum;                     
            this.Position = position;
            this.Salary_per_hour = salary_per_hour;
            this.Image = image;

            DateTime now = DateTime.Today;
            this.age = now.Year - birthDate.Year;
            if (now < birthDate.AddYears(Age))
                this.age--;
        }


    }

    
}
