using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_2022.Classes;
using Final_Project_2022.EmployeeControl_Manager;

namespace Final_Project_2022.MainForms
{
    public partial class MainFormManager : Form
    {
        public MainFormManager()
        {
            InitializeComponent();
        }

        DatabaseOperating database = new DatabaseOperating();
       
         


        private void ProfileListbutton_Click(object sender, EventArgs e)
        {
            ProfileListForm profileList = new ProfileListForm();
            profileList.ShowDialog();   
        }

        private void EditEmployeeProfilebutton_Click(object sender, EventArgs e)
        {
            Employee_Manager_Form employee_Manager_Form = new Employee_Manager_Form();      
            employee_Manager_Form.ShowDialog(); 
        }

        private void buttonServiceManagement_Click(object sender, EventArgs e)
        {
            ServiceManagement serviceManagement = new ServiceManagement();  
            serviceManagement.ShowDialog(); 
        }

        private void MainFormManager_Load(object sender, EventArgs e)
        {
            GetImageAndUserName();  
        }

        public void GetImageAndUserName()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            EMPLOYEES employeeCap = new EMPLOYEES();

            SqlCommand command = new SqlCommand("SELECT * FROM employee WHERE username = @username", database.GetConnection);
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = CurrentUser.UserName;

            adapter.SelectCommand = command;

            adapter.Fill(table);
            if ((table.Rows.Count > 0))
            {
                byte[] pic = (byte[])table.Rows[0]["image"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox.Image = Image.FromStream(picture);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                CurrentAccountLabel.Text = table.Rows[0]["name"].ToString();
            }
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            EditUserProfile editUserProfile = new EditUserProfile();
            editUserProfile.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShiftManagement shiftManagement = new ShiftManagement();
            shiftManagement.Show(this);
        }
    }
}
