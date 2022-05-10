using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System;
using Final_Project_2022.Classes;
using System.Data;

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
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT ID,ManagerID, Name, Gender, Bdate, Email, Phone, Address,Position, BasicSalary, Picture FROM HumanResourse", databaseOperating.GetConnection);
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
    }
}
