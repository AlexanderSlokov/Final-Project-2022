using Final_Project_2022.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Final_Project_2022.EmployeeControl_Manager
{
    public partial class ServiceManagement : Form
    {
        DatabaseOperating dbo = new DatabaseOperating();    
        ServicesDB servicesDB = new ServicesDB();   
        public ServiceManagement()
        {
            InitializeComponent();  
        }

        private void ServiceManagement_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT * FROM services", dbo.GetConnection));
            
            labelServiceNameError.Visible = false;
            labelServiceUnitNameError.Visible = false;
            labelServicePriceError.Visible = false;
        }
        public void fillGrid(SqlCommand command)
        {
            GridViewServicesList.ReadOnly = true;
            GridViewServicesList.DataSource = servicesDB.getServiceList(command);
            GridViewServicesList.AllowUserToAddRows = false;
            labelTotal.Text = ("NUMBER OF SERVICES: " + GridViewServicesList.Rows.Count);
           

        }

        //lam may cai nut theo student management
        private void btnxoa_Click(object sender, EventArgs e)
        {
            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // local variables
            int price = Int32.MinValue;
            string serviceName = string.Empty, unitName = string.Empty;
            bool serviceNameValid = false, unitNameValid = false, priceValid = false;
            // initialize 
            
            Int32.TryParse(textBoxPrice.Text, out price);
            serviceName = textBoxServiceName.Text;
            unitName = textBoxUnitName.Text;    

            // Check valid input
            if (serviceName.Trim() == "")
            {
                labelServiceNameError.Visible = true;
                labelServicePriceError.Text = "Enter a NAME for the service.";
                serviceNameValid = false;
            }
            else
            {
                // if don't exist
                if (servicesDB.checkServiceName(serviceName))
                {
                    labelServiceNameError.Visible = false;
                    serviceNameValid = true;
                }
                // reverse
                else
                {
                    labelServiceNameError.Visible = true;
                    labelServiceNameError.Text = "A Service Name existed";
                    serviceNameValid = false;
                }

            }
            
            if (unitName.Trim() == "")
            {
                labelServiceUnitNameError.Visible = true;
                labelServiceUnitNameError.Text = "Please type the unit name for the service!";
                unitNameValid = false;
            }
            else
            {
             
                    labelServiceUnitNameError.Visible = false;
                    unitNameValid = true;
                
            }

            if (price == 0)
            {
                labelServicePriceError.Visible = true;
                labelServicePriceError.Text = "Please enter price for your service!";
            }
            else
            {
                labelServicePriceError.Visible = false;
                priceValid = true;

            }

            //
            if (serviceNameValid && unitNameValid && priceValid)
            {
                if (servicesDB.InsertNewServices(serviceName, unitName, price))
                {
                    MessageBox.Show("New Service Inserted");
                    
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            this.Close();
            ServiceManagement serviceManagement = new ServiceManagement();
            serviceManagement.Show();
        }

        private void GridViewServicesList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxServiceName.Text = GridViewServicesList.CurrentRow.Cells[0].Value.ToString();
            textBoxUnitName.Text = GridViewServicesList.CurrentRow.Cells[1].Value.ToString();
            textBoxPrice.Text = GridViewServicesList.CurrentRow.Cells[2].Value.ToString();
        }


        //XOA + UPDATE
        #region Extra Functions
        /*
        void showData(int index)
        {
            try
            {
                DataRow datarow = servicesDB.getAllCourses().Rows[index];
                listBoxCourses.SelectedIndex = index;
                textBoxID.Text = datarow.ItemArray[0].ToString();
                textBoxCourseLabel.Text = datarow.ItemArray[1].ToString();
                numericUpDownHoursNumber.Value = int.Parse(datarow.ItemArray[2].ToString());
                textBoxDescription.Text = datarow.ItemArray[3].ToString();
                List<ComboboxItem> items = new List<ComboboxItem>();
                items.Add(new ComboboxItem() { Text = "1", Value = 1 });
                items.Add(new ComboboxItem() { Text = "2", Value = 2 });
                items.Add(new ComboboxItem() { Text = "3", Value = 3 });
                comboBoxSemester.SelectedIndex = Int32.Parse(datarow.ItemArray[4].ToString()) - 1;
            }
            catch
            {

            }
        }
        */
        #endregion

    }
}
