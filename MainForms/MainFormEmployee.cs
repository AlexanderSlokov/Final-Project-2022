using Final_Project_2022.Classes;
using Final_Project_2022.EmployeeControl_Manager;
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

namespace Final_Project_2022.MainForms
{
    public partial class MainFormEmployee : Form
    {
        public MainFormEmployee()
        {
            InitializeComponent();
        }

        DatabaseOperating database = new DatabaseOperating();
        ShiftDB shiftDB = new ShiftDB();
        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show(this);
        }

        private void buttonServiceOrder_Click(object sender, EventArgs e)
        {
            service_Order order = new service_Order();
            order.Show(this);
        }


        private void buttonServiceManagement_Click(object sender, EventArgs e)
        {
            ServiceManagement serviceManagement = new ServiceManagement();
            serviceManagement.ShowDialog();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            EditUserProfile editUserProfile = new EditUserProfile();
            editUserProfile.Show(this);
        }

        private void MainFormEmployee_Load(object sender, EventArgs e)
        {
            GetImageAndUserName();
            Loadschedule();
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

        void Loadschedule()
        {
            dataGridView.DataSource = shiftDB.GetDataTableAllSchedules();

            dataGridView.RowHeadersVisible = false;
            dataGridView.AllowUserToAddRows = false;

            dataGridView.Columns["employee_ID"].Width = 50;
            dataGridView.Columns["employee_ID"].HeaderText = "Employee ID";
            dataGridView.Columns["employee_ID"].DisplayIndex = 0;

            dataGridView.Columns["employee_Name"].Width = 100;
            dataGridView.Columns["employee_Name"].HeaderText = "Employee name";
            dataGridView.Columns["employee_Name"].DisplayIndex = 1;

            dataGridView.Columns["employee_Position"].Width = 100;
            dataGridView.Columns["employee_Position"].HeaderText = "Employee position";
            dataGridView.Columns["employee_Position"].DisplayIndex = 2;

            dataGridView.Columns["weekDate"].Width = 100;
            dataGridView.Columns["weekDate"].HeaderText = "Week Date";
            dataGridView.Columns["weekDate"].DisplayIndex = 3;

            dataGridView.Columns["shift_Type"].Width = 100;
            dataGridView.Columns["shift_Type"].HeaderText = "Shift Type";
            dataGridView.Columns["shift_Type"].DisplayIndex = 4;

            dataGridView.Columns["start_Time"].Width = 100;
            dataGridView.Columns["start_Time"].HeaderText = "Starting time";
            dataGridView.Columns["start_Time"].DisplayIndex = 5;

            dataGridView.Columns["end_Time"].Width = 100;
            dataGridView.Columns["end_Time"].HeaderText = "Ending time";
            dataGridView.Columns["end_Time"].DisplayIndex = 6;

            //

            dataGridView.Sort(dataGridView.Columns[0], ListSortDirection.Ascending);

        }
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
    }
}
