using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_2022.Classes;


namespace Final_Project_2022.EmployeeControl_Manager
{
    public partial class Employee_Manager_Form : Form
    {
        public Employee_Manager_Form()
        {
            InitializeComponent();
        }

        EmployeeDB employeeDB = new EmployeeDB();
       
        int oldID;
        string oldUsername;
        string inTable;
        private void Employee_Manager_Form_Load(object sender, EventArgs e)
        {
            Init();
            FillGrid();

        }
        void Init()
        {
            dateTimePicker.Value = new DateTime(1999, 1, 1);
            dataGridViewEmployee.DataSource = employeeDB.GetEmployeesDataTable();
            inTable = "Employee";
        }

        void FillGrid()
        {
            if (inTable == "Employee")
            {
                dataGridViewEmployee.DataSource = employeeDB.GetEmployeesDataTable();
            }
            else
            {
                dataGridViewEmployee.DataSource = employeeDB.GetManagersDataTable();
            }
            dataGridViewEmployee.RowHeadersVisible = false;
            dataGridViewEmployee.AllowUserToAddRows = false;

            dataGridViewEmployee.Columns[0].Width = 70;
            dataGridViewEmployee.Columns[0].HeaderText = "ID";
            dataGridViewEmployee.Columns[1].Width = 100;
            dataGridViewEmployee.Columns[1].HeaderText = "Name";
            dataGridViewEmployee.Columns[2].Width = 70;
            dataGridViewEmployee.Columns[2].HeaderText = "Position";
            dataGridViewEmployee.Columns[3].Width = 70;
            dataGridViewEmployee.Columns[3].HeaderText = "Birthdate";
            dataGridViewEmployee.Columns[4].Width = 50;
            dataGridViewEmployee.Columns[4].HeaderText = "Gender";
            dataGridViewEmployee.Columns[5].Width = 70;
            dataGridViewEmployee.Columns[5].HeaderText = "Phone";
            dataGridViewEmployee.Columns[6].Width = 100;
            dataGridViewEmployee.Columns[6].HeaderText = "Email";
            dataGridViewEmployee.Columns[7].Width = 100;
            dataGridViewEmployee.Columns[7].HeaderText = "Image";
            dataGridViewEmployee.Columns["image"].Visible = false;
            dataGridViewEmployee.Columns[8].Width = 100;
            dataGridViewEmployee.Columns[8].HeaderText = "Salary(VND)";
            dataGridViewEmployee.Columns[9].Width = 100;
            dataGridViewEmployee.Columns[9].HeaderText = "Username";
            dataGridViewEmployee.Columns[10].Width = 100;
            dataGridViewEmployee.Columns[10].HeaderText = "Password";
            dataGridViewEmployee.Columns["password"].Visible = false;

            dataGridViewEmployee.Sort(dataGridViewEmployee.Columns[0], ListSortDirection.Ascending);
        }

        
    }
}
