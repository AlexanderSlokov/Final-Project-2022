using Final_Project_2022.Classes;
using Final_Project_2022.Classes.Shift;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
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
        string insert_weekDate,
            insert_shiftType,
            insert_startTime,
            insert_endTime,
            insert_employee_name,
            insert_employee_position;

        //buttons
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
        private void buttonDeleteShift_Click(object sender, EventArgs e)
        {
            int employeeID;
            try
            {
                employeeID = Int32.Parse(comboBoxEmployeeID.Text.ToString());
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

            if (shiftDB.DeleteShift(employeeID, employeeName, employeePos, weekDate, shiftType, startTime, endTime))
            {
                MessageBox.Show("Successfully Delete New Shift", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                LoadData();
            }
            else
            {
                MessageBox.Show("Failed To Delete New Shift", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void buttonClearSchedules_Click(object sender, EventArgs e)
        {
            shiftDB.DeleteAllShifts();
            LoadData();
        }

        private void buttonAutoAssign_Click(object sender, EventArgs e)
        {
            #region Static obj
            EmployeeModel employee = new EmployeeModel();
            EmployeeModel manager = new EmployeeModel();
            EmployeeModel labor = new EmployeeModel();
            #endregion

            #region Get stack
            Stack<EmployeeModel> employeeList = employeeDB.GetEmployeesStack();
            Stack<EmployeeModel> managerList = employeeDB.GetManagersStack();
            Stack<EmployeeModel> laborList = employeeDB.GetLaborsStack();
            #endregion

            #region Clone stack to use more than 1 time
            Stack<EmployeeModel> CloneEmployeeList = employeeDB.GetEmployeesStack();
            Stack<EmployeeModel> CloneManagerList = employeeDB.GetManagersStack();
            Stack<EmployeeModel> CloneLaborList = employeeDB.GetLaborsStack();
            #endregion

            string weekDate = "Monday";
            string shift_type = "Day Shift";
            string endTime = String.Empty, startTime = String.Empty;

            for (int i = 1; i <= 7; i++)
            {
                switch (i)
                {
                    #region Cases of week date
                    case 1:
                        weekDate = WeekDate.Monday;
                        break;
                    case 2:
                        weekDate = WeekDate.Tuesday;
                        break;
                    case 3:
                        weekDate = WeekDate.Wednesday;
                        break;
                    case 4:
                        weekDate = WeekDate.Thursday;
                        break;
                    case 5:
                        weekDate = WeekDate.Friday;
                        break;
                    case 6:
                        weekDate = WeekDate.Saturday;
                        break;
                    case 7:
                        weekDate = WeekDate.Sunday;
                        break;
                        #endregion
                }
                for (int j = 1; j <= 2; j++)
                {
                    switch (j)
                    {
                        case 1:
                            shift_type = "Day Shift";
                            break;
                        case 2:
                            shift_type = "Night Shift";
                            break;

                    }
                    if (shift_type == "Day Shift")
                    {
                        startTime = "7:00:00";
                        endTime = "19:00:00";
                    }
                    else if (shift_type == "Night Shift")
                    {
                        startTime = "20:00:00";
                        endTime = "6:00:00";
                    }

                    if (weekDate == WeekDate.Saturday)
                    {

                        #region all Administiator have to work
                        if (CloneManagerList.Count <= 0)
                        {
                            CloneManagerList = employeeDB.GetManagersStack();
                        }
                        manager = CloneManagerList.Pop();
                        if (shiftDB.isShiftExists(manager.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                        {
                            shiftDB.InsertShift(manager.Id, manager.Name, manager.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                        }
                        #endregion

                        #region 3 labors
                        if (CloneLaborList.Count <= 0)
                        {
                            CloneLaborList = employeeDB.GetLaborsStack();
                        }
                        labor = CloneLaborList.Pop();
                        if (shiftDB.isShiftExists(labor.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                        {
                            shiftDB.InsertShift(labor.Id, labor.Name, labor.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                        }

                        if (CloneLaborList.Count <= 0)
                        {
                            CloneLaborList = employeeDB.GetLaborsStack();
                        }
                        labor = CloneLaborList.Pop();
                        if (shiftDB.isShiftExists(labor.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                        {
                            shiftDB.InsertShift(labor.Id, labor.Name, labor.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                        }

                        if (CloneLaborList.Count <= 0)
                        {
                            CloneLaborList = employeeDB.GetLaborsStack();
                        }
                        labor = CloneLaborList.Pop();
                        if (shiftDB.isShiftExists(labor.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                        {
                            shiftDB.InsertShift(labor.Id, labor.Name, labor.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                        }
                        #endregion

                    }
                    else if (weekDate == WeekDate.Sunday)
                    {
                        #region all Administiator have to work
                        if (CloneManagerList.Count <= 0)
                        {
                            CloneManagerList = employeeDB.GetManagersStack();
                        }
                        manager = CloneManagerList.Pop();
                        if (shiftDB.isShiftExists(manager.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                        {
                            shiftDB.InsertShift(manager.Id, manager.Name, manager.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                        }
                        #endregion

                        #region 3 labors
                        if (CloneLaborList.Count <= 0)
                        {
                            CloneLaborList = employeeDB.GetLaborsStack();
                        }
                        labor = CloneLaborList.Pop();
                        if (shiftDB.isShiftExists(labor.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                        {
                            shiftDB.InsertShift(labor.Id, labor.Name, labor.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                        }

                        if (CloneLaborList.Count <= 0)
                        {
                            CloneLaborList = employeeDB.GetLaborsStack();
                        }
                        labor = CloneLaborList.Pop();
                        if (shiftDB.isShiftExists(labor.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                        {
                            shiftDB.InsertShift(labor.Id, labor.Name, labor.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                        }

                        if (CloneLaborList.Count <= 0)
                        {
                            CloneLaborList = employeeDB.GetLaborsStack();
                        }
                        labor = CloneLaborList.Pop();
                        if (shiftDB.isShiftExists(labor.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                        {
                            shiftDB.InsertShift(labor.Id, labor.Name, labor.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                        }
                        #endregion
                    }
                    else
                    {
                        if ((shift_type == "Day Shift"))
                        {
                            #region 1 manager
                            if (CloneManagerList.Count <= 0)
                            {
                                CloneManagerList = employeeDB.GetManagersStack();
                            }
                            manager = CloneManagerList.Pop();
                            if (shiftDB.isShiftExists(manager.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                            {
                                shiftDB.InsertShift(manager.Id, manager.Name, manager.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                            }
                            #endregion

                            #region 2 employee
                            if (CloneEmployeeList.Count <= 0)
                            {
                                CloneEmployeeList = employeeDB.GetEmployeesStack();

                            }
                            employee = CloneEmployeeList.Pop();
                            if (shiftDB.isShiftExists(employee.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                            {
                                shiftDB.InsertShift(employee.Id, employee.Name, employee.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                            }

                            if (CloneEmployeeList.Count <= 0)
                            {
                                CloneEmployeeList = employeeDB.GetEmployeesStack();

                            }
                            employee = CloneEmployeeList.Pop();
                            if (shiftDB.isShiftExists(employee.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                            {
                                shiftDB.InsertShift(employee.Id, employee.Name, employee.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                            }
                            #endregion

                            #region 4 labors
                            if (CloneLaborList.Count <= 0)
                            {
                                CloneLaborList = employeeDB.GetLaborsStack();
                            }
                            labor = CloneLaborList.Pop();
                            if (shiftDB.isShiftExists(labor.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                            {
                                shiftDB.InsertShift(labor.Id, labor.Name, labor.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                            }

                            if (CloneLaborList.Count <= 0)
                            {
                                CloneLaborList = employeeDB.GetLaborsStack();
                            }
                            labor = CloneLaborList.Pop();
                            if (shiftDB.isShiftExists(labor.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                            {
                                shiftDB.InsertShift(labor.Id, labor.Name, labor.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                            }

                            if (CloneLaborList.Count <= 0)
                            {
                                CloneLaborList = employeeDB.GetLaborsStack();
                            }
                            labor = CloneLaborList.Pop();
                            if (shiftDB.isShiftExists(labor.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                            {
                                shiftDB.InsertShift(labor.Id, labor.Name, labor.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                            }

                            if (CloneLaborList.Count <= 0)
                            {
                                CloneLaborList = employeeDB.GetLaborsStack();
                            }
                            labor = CloneLaborList.Pop();
                            if (shiftDB.isShiftExists(labor.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                            {
                                shiftDB.InsertShift(labor.Id, labor.Name, labor.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                            }
                            #endregion

                        }
                        else if ((shift_type == "Night Shift"))
                        {
                            #region 1 employee 

                            if (CloneEmployeeList.Count <= 0)
                            {
                                CloneEmployeeList = employeeDB.GetEmployeesStack();

                            }
                            employee = CloneEmployeeList.Pop();
                            if (shiftDB.isShiftExists(employee.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                            {
                                shiftDB.InsertShift(employee.Id, employee.Name, employee.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                            }
                            #endregion

                            #region 1 labor

                            if (CloneLaborList.Count <= 0)
                            {
                                CloneLaborList = employeeDB.GetLaborsStack();
                            }
                            labor = CloneLaborList.Pop();
                            if (shiftDB.isShiftExists(labor.Id, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime), weekDate) == false)
                            {
                                shiftDB.InsertShift(labor.Id, labor.Name, labor.Position, weekDate, shift_type, TimeSpan.Parse(startTime), TimeSpan.Parse(endTime));
                            }
                            #endregion
                        }
                    }                  
                }
            }
            LoadData();
        }
       
    
    


        private void buttonUpdateShift_Click(object sender, EventArgs e)
        {//this button
            if (insert_employee_id == 0 ||
           insert_employee_name == null ||
           insert_employee_position == null ||
           insert_startTime == null ||
           insert_endTime == null ||
           insert_shiftType == null ||
           insert_weekDate == null)
            {
                MessageBox.Show("Please click to choose");
            }
            else
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
                string employeePosition = textBoxPosition.Text;
                string weekDate = comboBoxWeekDate.Text;
                string shiftType = comboBoxShiftType.Text;

                TimeSpan startTime = TimeSpan.Parse(labelStartTime.Text);
                TimeSpan endTime = TimeSpan.Parse(labelEndTime.Text);

                if (shiftDB.UpdateShift(employeeID, employeeName, employeePosition, weekDate, shiftType, startTime, endTime))
                {
                    MessageBox.Show("Successfully Update New Shift", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadData();
                }
                else
                {
                    shiftDB.DeleteShift(insert_employee_id, insert_employee_name, insert_employee_position, insert_weekDate, insert_shiftType, TimeSpan.Parse(insert_startTime), TimeSpan.Parse(insert_endTime));


                    shiftDB.InsertShift(employeeID, employeeName, employeePosition, weekDate, shiftType, startTime, endTime);

                    LoadData();
                    insert_employee_id = 0;
                    insert_employee_name = null;
                    insert_employee_position = null;
                    insert_startTime = null;
                    insert_endTime = null;
                    insert_weekDate = null;
                }

            }
        }

        //load form
        private void ShiftManagement_Load(object sender, EventArgs e)
        {
            comboBoxWeekDate.Text = "Monday";
            comboBoxShiftType.Text = "Day Shift";
            LoadData();
        }

        private void dataGridViewShift_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxEmployeeID.SelectedValue = dataGridViewShift.CurrentRow.Cells["employee_ID"].Value.ToString();
            textBoxEmployeeName.Text = dataGridViewShift.CurrentRow.Cells["employee_Name"].Value.ToString();
            textBoxPosition.Text = dataGridViewShift.CurrentRow.Cells["employee_Position"].Value.ToString();
            comboBoxWeekDate.Text = dataGridViewShift.CurrentRow.Cells["weekDate"].Value.ToString();
            comboBoxShiftType.Text = dataGridViewShift.CurrentRow.Cells["shift_Type"].Value.ToString();
            labelStartTime.Text = dataGridViewShift.CurrentRow.Cells["start_Time"].Value.ToString();
            labelEndTime.Text = dataGridViewShift.CurrentRow.Cells["end_Time"].Value.ToString();

            insert_employee_id = Int32.Parse(dataGridViewShift.CurrentRow.Cells["employee_ID"].Value.ToString());
            insert_employee_name = dataGridViewShift.CurrentRow.Cells["employee_Name"].Value.ToString();
            insert_employee_position = dataGridViewShift.CurrentRow.Cells["employee_Position"].Value.ToString();
            insert_weekDate = dataGridViewShift.CurrentRow.Cells["weekDate"].Value.ToString();
            insert_shiftType = dataGridViewShift.CurrentRow.Cells["shift_Type"].Value.ToString();
            insert_startTime = dataGridViewShift.CurrentRow.Cells["start_Time"].Value.ToString();
            insert_endTime = dataGridViewShift.CurrentRow.Cells["end_Time"].Value.ToString();
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

            if (shiftDB.isShiftExists(employeeID, startTime, endTime, weekDate) == false)
            {
                if (shiftDB.InsertShift(employeeID, employeeName, employeePos, weekDate, shiftType, startTime, endTime))
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
                MessageBox.Show(" Shift Existed");
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

      
    }
}
