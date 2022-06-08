using Final_Project_2022.Classes;
using Final_Project_2022.Classes.Salary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_2022.EmployeeControl_Manager
{
    public partial class Salary_Calc : Form
    {
        public Salary_Calc()
        {
            InitializeComponent();
        }

        SalaryDB salaryDB = new SalaryDB();
        ShiftDB shiftDB = new ShiftDB();    

        int collected_employee_ID = 0;
        int late_check_in_hours;
        int soon_check_out_hours;
        int minus_check_in_salary;
        int minus_check_out_salary;
        int working_hours;
        int working_salary;
        int total;

        TimeSpan collected_start_time;
        TimeSpan collected_end_time;
        DateTime collected_check_in;
        DateTime collected_check_out;
        string   confirm_status;

        private void Salary_Calc_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            dataGridView.DataSource = salaryDB.GetDataTable_Salary();

            dataGridView.RowHeadersVisible = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            dataGridView.Columns["employee_ID"].HeaderText = "Employee ID";
            dataGridView.Columns["employee_ID"].DisplayIndex = 0;

           
            dataGridView.Columns["week_Date"].HeaderText = "Week Date";
            dataGridView.Columns["week_Date"].DisplayIndex = 1;

          
            dataGridView.Columns["start_Time"].HeaderText = "Start time";
            dataGridView.Columns["start_Time"].DisplayIndex = 2;
            
           
            dataGridView.Columns["end_Time"].HeaderText = "End Time";
            dataGridView.Columns["end_Time"].DisplayIndex = 3;

           
            dataGridView.Columns["check_In"].HeaderText = "Check In Time";
            dataGridView.Columns["check_In"].DisplayIndex = 4;

            dataGridView.Columns["check_Out"].HeaderText = "Check Out Time";
            dataGridView.Columns["check_Out"].DisplayIndex = 5;

            
            dataGridView.Columns["Status"].HeaderText = "Confirm Status";
            dataGridView.Columns["Status"].DisplayIndex = 6;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            collected_check_in = DateTime.Parse(dataGridView.CurrentRow.Cells["check_In"].Value.ToString());
            collected_check_out = DateTime.Parse(dataGridView.CurrentRow.Cells["check_Out"].Value.ToString());

            textBoxID.Text = dataGridView.CurrentRow.Cells["employee_ID"].Value.ToString();
            textBoxStartTime.Text = dataGridView.CurrentRow.Cells["start_Time"].Value.ToString();         
            textBoxEndTIme.Text = dataGridView.CurrentRow.Cells["end_Time"].Value.ToString();

            textBoxCheckIN.Text = collected_check_in.ToString("HH:mm:ss");
            textBoxCheckOut.Text = collected_check_out.ToString("HH:mm:ss");


            collected_employee_ID = Int32.Parse(dataGridView.CurrentRow.Cells["employee_ID"].Value.ToString());
            collected_start_time = TimeSpan.Parse(dataGridView.CurrentRow.Cells["start_Time"].Value.ToString());        
            collected_end_time = TimeSpan.Parse(dataGridView.CurrentRow.Cells["end_Time"].Value.ToString());
           
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            string employee_pos;
            int employee_salary_per_hour;
           

            if (textBoxID.Text == "")
            {
                MessageBox.Show("click on table to get data first.");
            }
            else
            {
                DataTable table = new DataTable();
                table = shiftDB.getEmployeeInfoByID(collected_employee_ID);
                employee_pos = table.Rows[0][2].ToString();
                employee_salary_per_hour = Int32.Parse(table.Rows[0][8].ToString());

                //catching employee quit working while in schedule
                if (collected_check_out.ToString().Trim() == "")
                {
                    working_salary = 0;
                    working_hours = 0;


                    textBoxHourSum.Text = "Not Check Out, Not Worked";
                    textBoxSalary.Text = "No salary";
                    textBoxTotal.Text = "No Money!";
                    buttonUpdateInformation.Visible = false;

                }
                //calc time
                late_check_in_hours = collected_check_in.Hour - collected_start_time.Hours;
                soon_check_out_hours = collected_end_time.Hours - collected_check_out.Hour;
                
                /*
                if (late_check_in_hours >= 4)
                {
                    working_hours = 0;
                    working_salary = 0;
                    total = 0;
                    textBoxSalary.Text = "Over Schedule";
                    buttonUpdateInformation.Visible = false;

                }
                */
                //else if (late_check_in_hours > 0 && late_check_in_hours <= 4)
                //{
                    textBoxLateCheckIN.Text = late_check_in_hours.ToString();
                    textBoxSoonCheckOUT.Text = soon_check_out_hours.ToString(); 

                    minus_check_in_salary = late_check_in_hours * MinusCalc(employee_pos);
                    textBoxMinusCheckIN.Text = minus_check_in_salary.ToString();

                    minus_check_out_salary = soon_check_out_hours * MinusCalc(employee_pos);
                    textBoxMinusCheckOUT.Text = minus_check_out_salary.ToString();

                    working_hours = collected_check_out.Hour - collected_check_in.Hour;
                    working_salary = working_hours * employee_salary_per_hour;

                    textBoxHourSum.Text = working_hours.ToString();
                    textBoxSalary.Text = working_salary.ToString(); 

                    total = working_salary - (minus_check_in_salary + minus_check_out_salary);
                    textBoxTotal.Text = total.ToString();
                //}
            }
        }
        public int MinusCalc(string pos)
        {
            int minusSalary;

            if (pos == "Manager")
            {
                minusSalary = 200000;
                return minusSalary;
            }
            else if (pos == "Employee")
            {
                minusSalary = 120000;
                return minusSalary;
            }
            else if (pos == "Labor")
            {
                minusSalary = 80000;
                return minusSalary;
            }
            else
            {
                minusSalary = 0;
                return minusSalary;
            }
        }

        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            LoadData();
            buttonUpdateInformation.Visible = true;
        }

        private void buttonUpdateInformation_Click(object sender, EventArgs e)
        {


            if (textBoxTotal.Text == "" && textBoxHourSum.Text == "" && textBoxID.Text == "")
            {
                MessageBox.Show("Please make the calculation for spencific employee first!", MessageBoxIcon.Warning.ToString());
            }
            else
            {
                int working_hour = Int32.Parse(textBoxHourSum.Text.ToString());
                int late_hour = Int32.Parse(textBoxLateCheckIN.Text.ToString()) + Int32.Parse(textBoxSoonCheckOUT.Text.ToString());
                int salary = Int32.Parse(textBoxTotal.Text.ToString());

                if (salaryDB.IsEmployeeExistByID(collected_employee_ID) == false)
                {
                    confirm_status = "Confirmed";
                    salaryDB.Add_Employee_SalaryReport(collected_employee_ID, working_hour, late_hour, salary, confirm_status);
                }
                else
                {
                    MessageBox.Show("Report existed!", MessageBoxIcon.Warning.ToString());
                }
            }
        }
    }

}