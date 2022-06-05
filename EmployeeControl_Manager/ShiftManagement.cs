using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_2022.Classes;
namespace Final_Project_2022.EmployeeControl_Manager
{
    public partial class ShiftManagement : Form
    {
        public ShiftManagement()
        {
            InitializeComponent();
        }

        ShiftDB shiftDB = new ShiftDB();
        EmployeeDB employeeDB = new EmployeeDB();   
        int insert_employee_id;
        string insert_weekDate, insert_shiftType, insert_startTime, insert_endTime, insert_employee_name, insert_employee_position;

        private void comboBoxEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBoxEmployeeID.Text.ToString());
                DataTable table = new DataTable();
                table = shiftDB.getEmployeeInfoByID(id);

                textBoxEmployeeName.Text = table.Rows[0][1].ToString();
                textBoxPosition.Text = table.Rows[0][2].ToString();
            }
            catch (Exception ex)
            {          

            }
        }

        private void comboBoxShiftType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string shift_type = comboBoxShiftType.Text;
            if (shift_type == "Day Shift")
            {
                labelStartTime.Text = "7:00:00";
                labelEndTime.Text = "19:00:00";
            }
            else if (shift_type == "Night Shift")
            {
                labelStartTime.Text = "20:00:00";
                labelEndTime.Text = "6:00:00";
            }
        }

        private void buttonNewShift_Click(object sender, EventArgs e)
        {
            InsertShift();
        }
        #region Extra functions
        public void InsertShift()
        {
            int employeeID;
            try
            {
                employeeID = Int32.Parse(comboBoxEmployeeID.SelectedValue.ToString());
            }
            catch
            {
                employeeID = 0;
            }

            string employeeName = textBoxEmployeeName.Text;
            string employeePos = textBoxPosition.Text;
            string shiftType = comboBoxShiftType.Text;
            string weekDate = comboBoxWeekDate.Text;

            TimeSpan startTime = TimeSpan.Parse(labelStartTime.Text);
            TimeSpan endTime = TimeSpan.Parse(labelEndTime.Text);

            if (shiftDB.isShiftExists(employeeID,startTime, endTime, weekDate) == false)
            {
                if (shiftDB.InsertShift(employeeID, employeeName, employeePos, weekDate, shiftType, startTime, endTime ))
                {
                    MessageBox.Show("Successfully Added New Shift", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed To Added New Shift", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exists Shift");
            }
        }

        void LoadData()
        {

            dataGridViewShift.DataSource = shiftDB.GetDataTableAllSchedules();

            dataGridViewShift.RowHeadersVisible = false;
            dataGridViewShift.AllowUserToAddRows = false;

            dataGridViewShift.Columns["employee_ID"].Width = 50;
            dataGridViewShift.Columns["employee_ID"].HeaderText = "Employee ID";
            dataGridViewShift.Columns["employee_ID"].DisplayIndex = 0;

            dataGridViewShift.Columns["employee_Name"].Width = 100;
            dataGridViewShift.Columns["employee_Name"].HeaderText = "Employee name";
            dataGridViewShift.Columns["employee_Name"].DisplayIndex = 1;

            dataGridViewShift.Columns["employee_Position"].Width = 100;
            dataGridViewShift.Columns["employee_Position"].HeaderText = "Employee position";
            dataGridViewShift.Columns["employee_Position"].DisplayIndex = 2;

            dataGridViewShift.Columns["weekDate"].Width = 100;
            dataGridViewShift.Columns["weekDate"].HeaderText = "Week Date";
            dataGridViewShift.Columns["weekDate"].DisplayIndex = 3;

            dataGridViewShift.Columns["shift_Type"].Width = 100;
            dataGridViewShift.Columns["shift_Type"].HeaderText = "Shift Type";
            dataGridViewShift.Columns["shift_Type"].DisplayIndex = 4;

            dataGridViewShift.Columns["start_Time"].Width = 100;
            dataGridViewShift.Columns["start_Time"].HeaderText = "Starting time";
            dataGridViewShift.Columns["start_Time"].DisplayIndex = 5;

            dataGridViewShift.Columns["end_Time"].Width = 100;
            dataGridViewShift.Columns["end_Time"].HeaderText = "Ending time";
            dataGridViewShift.Columns["end_Time"].DisplayIndex = 6;

            //

            dataGridViewShift.Sort(dataGridViewShift.Columns[0], ListSortDirection.Ascending);

            //

            comboBoxEmployeeID.DataSource = employeeDB.GetAllEmployee_ForComnboBox_Schedule();
            comboBoxEmployeeID.DisplayMember = "id";
            comboBoxEmployeeID.ValueMember = "id";

           
        }
        #endregion

        private void ShiftManagement_Load(object sender, EventArgs e)
        {
            comboBoxWeekDate.Text = "Monday";
            comboBoxShiftType.Text = "Day Shift";
            LoadData();
        }
    }//may cai nut con lai
}
