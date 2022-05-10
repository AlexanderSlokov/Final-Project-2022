﻿using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System;
using Final_Project_2022.Classes;
using System.Data;
using System.Drawing;

namespace Final_Project_2022.EmployeeControl_Manager
{
    public partial class ProfileListForm : Form
    {
        public ProfileListForm()
        {
            InitializeComponent();
        }

        DatabaseOperating databaseOperating = new DatabaseOperating();
        EMPLOYEES employees = new EMPLOYEES();  
        private void ProfileListForm_Load(object sender, EventArgs e)
        {
            dateTimePickerStartDate.CustomFormat = "dd - MM - yyyy";
            dateTimePickerEndDate.CustomFormat = "dd - MM - yyyy";
            dateTimePickerStartDate.Value = new DateTime(1995, 01, 01);

            try
            {
                databaseOperating.openConnection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ID ,ManagerID, Name, Gender, Bdate, Email, Phone, Address,Position, BasicSalary, Picture FROM HumanResourse", databaseOperating.GetConnection);
                DataSet dataSet = new DataSet();

                System.Data.DataTable dataTable = new System.Data.DataTable();
                sqlDataAdapter.Fill(dataSet, "HumanResourse");

                dataTable = dataSet.Tables["HumanResourse"];
                dataGridViewEmployeeList.DataSource = dataTable;
                dataGridViewEmployeeList.Columns[0].HeaderText = "Employee ID";
                dataGridViewEmployeeList.Columns[1].HeaderText = "Employee Manager ID";
                dataGridViewEmployeeList.Columns[2].HeaderText = "Employee Name";
                dataGridViewEmployeeList.Columns[3].HeaderText = "Employee Gender";
                dataGridViewEmployeeList.Columns[4].HeaderText = "Employee Birthday";
                dataGridViewEmployeeList.Columns[5].HeaderText = "Employee Email";
                dataGridViewEmployeeList.Columns[6].HeaderText = "Employee Phone Number";
                dataGridViewEmployeeList.Columns[7].HeaderText = "Employee Address";
                dataGridViewEmployeeList.Columns[8].HeaderText = "Employee Position";
                dataGridViewEmployeeList.Columns[9].HeaderText = "Employee BasicSalary";
                dataGridViewEmployeeList.Columns[10].HeaderText = "Employee Picture";




                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                picCol = (DataGridViewImageColumn)dataGridViewEmployeeList.Columns[10];

                try
                {
                    DataGridViewImageColumn imgCol = (DataGridViewImageColumn)dataGridViewEmployeeList.Columns["Picture"];
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error casting column to image column: " + ex.Message);
                }

                databaseOperating.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            this.Close();
            ProfileListForm studentList = new ProfileListForm();
            studentList.Show();
        }

        private void getMaleData()
        {
            DatabaseOperating databaseOperating = new DatabaseOperating();
            databaseOperating.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ID ,ManagerID, Name, Gender, Bdate, Email, Phone, Address,Position, BasicSalary, Picture FROM HumanResourse WHERE Gender = 'Male'", databaseOperating.GetConnection);
            DataSet dataSet = new DataSet();

            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "HumanResourse");

            dataTable = dataSet.Tables["HumanResourse"];
            dataGridViewEmployeeList.DataSource = dataTable;

            databaseOperating.closeConnection();
        }

        private void getFemaleData()
        {
            DatabaseOperating databaseOperating = new DatabaseOperating();
            databaseOperating.openConnection();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ID ,ManagerID, Name, Gender, Bdate, Email, Phone, Address,Position, BasicSalary, Picture FROM HumanResourse WHERE gender = 'Female'", databaseOperating.GetConnection);
            DataSet dataSet = new DataSet();

            System.Data.DataTable dataTable = new System.Data.DataTable();
            sqlDataAdapter.Fill(dataSet, "HumanResourse");

            dataTable = dataSet.Tables["HumanResourse"];
            dataGridViewEmployeeList.DataSource = dataTable;

            databaseOperating.closeConnection();
        }

        private void getAllData()
        {
            try
            {
                DatabaseOperating databaseOperating = new DatabaseOperating();
                databaseOperating.openConnection();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ID ,ManagerID, Name, Gender, Bdate, Email, Phone, Address,Position, BasicSalary, Picture FROM HumanResourse", databaseOperating.GetConnection);
                DataSet dataSet = new DataSet();

                System.Data.DataTable dataTable = new System.Data.DataTable();
                sqlDataAdapter.Fill(dataSet, "HumanResourse");

                dataTable = dataSet.Tables["HumanResourse"];
                dataGridViewEmployeeList.DataSource = dataTable;

                databaseOperating.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failtal Erorr: " + ex.Message);
            }
        }

        private void ExportDataGridViewToExcel(DataGridView dataGridView, bool isPrint)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            app.Visible = true;

            worksheet = (_Worksheet)workbook.Sheets["Sheet1"];
            worksheet = (_Worksheet)workbook.ActiveSheet;

            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";

            // storing header part in Excel  
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
            }

            //storing EACH row and column value to excel sheet
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].GetType() != typeof(DataGridViewImageCell))
                    {
                        if (dataGridView.Columns[j].HeaderText == "Phone")
                            worksheet.Cells[i + 2, j + 1] = "'" + dataGridView.Rows[i].Cells[j].Value.ToString();
                        else
                            worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        // Save image from dataGridView to local
                        ((Image)dataGridView.Rows[i].Cells[j].Value).Save(System.Windows.Forms.Application.StartupPath + @"\Download\picAvt.png");

                        string imagString = System.Windows.Forms.Application.StartupPath + @"\Download\picAvt.png";
                        Microsoft.Office.Interop.Excel.Range oRange = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[i + 2, j + 1];
                        float Left = (float)((double)oRange.Left);
                        float Top = (float)((double)oRange.Top);
                        const float ImageSize = 80;
                        worksheet.Shapes.AddPicture(imagString, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, Left, Top, ImageSize, ImageSize);
                        oRange.RowHeight = ImageSize + 2;

                    }
                }
            }
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlLandscape;
            if (isPrint)
                worksheet.PrintPreview();
        }

        private void ButtonToEXcelFileList_Click(object sender, EventArgs e)
        {
            ExportDataGridViewToExcel(dataGridViewEmployeeList, true);
        }

        private void buttonCheckList_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            String query;
            DateTime startdate = new DateTime();
            DateTime enddate = new DateTime();
            startdate = dateTimePickerStartDate.Value;
            enddate = dateTimePickerEndDate.Value;
            if (radioButtonYes.Checked)
            {
                if (radioButtonMaleList.Checked)
                {
                    query = "SELECT ID ,ManagerID, Name, Gender, Bdate, Email, Phone, Address,Position, BasicSalary, Picture FROM HumanResourse WHERE Gender = 'Male' AND Bdate BETWEEN'" + startdate + "'AND' " + enddate + "'";
                }
                else if (radioButtonFemaleList.Checked)
                {
                    query = "SELECT ID ,ManagerID, Name, Gender, Bdate, Email, Phone, Address,Position, BasicSalary, Picture FROM HumanResourse WHERE Gender = 'Female' AND Bdate BETWEEN'" + startdate + "'AND' " + enddate + "'";
                }
                else
                {
                    query = "SELECT ID ,ManagerID, Name, Gender, Bdate, Email, Phone, Address,Position, BasicSalary, Picture FROM HumanResourse WHERE Bdate BETWEEN'" + startdate + "'AND' " + enddate + "'";
                }

                command = new SqlCommand(query, databaseOperating.GetConnection);
                fillGrid(command);
            }
            else
            {
                if (radioButtonMaleList.Checked)
                {
                    getMaleData();
                }
                else if (radioButtonFemaleList.Checked)
                {
                    getFemaleData();
                }
                else
                {
                    getAllData();
                }
            }

        }

        private void fillGrid(SqlCommand command)
        {
            dataGridViewEmployeeList.ReadOnly = true;
            dataGridViewEmployeeList.DataSource = employees.getEmployee(command);
            dataGridViewEmployeeList.AllowUserToAddRows = false;
        }
    }
}
