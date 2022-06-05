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

        int pos;
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
           
            labelServiceIDError.Visible = false;    
            labelInStockError.Visible = false;      
        }
        public void fillGrid(SqlCommand command)
        {
            GridViewServicesList.ReadOnly = true;
            GridViewServicesList.DataSource = servicesDB.getServiceList(command);
            GridViewServicesList.AllowUserToAddRows = false;
            labelTotal.Text = ("NUMBER OF SERVICES: " + GridViewServicesList.Rows.Count);
           

        }

     
        private void btnxoa_Click(object sender, EventArgs e)
        {
            int id = Int32.MinValue;
            Int32.TryParse(textBoxID.Text, out id);
           
            try
            {
               

                if ((MessageBox.Show("Are You Sure You Want To Delete This Service?", "Remove Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {
                    if (servicesDB.deleteService(id))
                    {
                        MessageBox.Show("Service Deleted", "Remove Service", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //clear fields
                        textBoxServiceName.Text = "";
                        textBoxUnitName.Text = "";                     
                        textBoxPrice.Text = "";
                       
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            //
            catch
            {
                MessageBox.Show("Enter A valid Numerid ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos = 0;
            //
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            // local variables
            int price = Int32.MinValue;
            int id = Int32.MinValue;
            
            string serviceName = string.Empty, unitName = string.Empty, InStock = string.Empty;
            bool serviceNameValid = false, unitNameValid = false, priceValid = false, idValid = false, InStockValid = false;
            // initialize 
            
            Int32.TryParse(textBoxPrice.Text, out price);
            Int32.TryParse(textBoxID.Text, out id);
            serviceName = textBoxServiceName.Text;
            unitName = textBoxUnitName.Text;    
            InStock = textBoxInStock.Text;  
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

            if (InStock.Trim() == "")
            {
                labelInStockError.Visible = true;
                labelInStockError.Text = "Please type the availability for the service!";
                InStockValid = false;
            }
            else
            {

                labelInStockError.Visible = false;
                InStockValid = true;

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

            if (id.ToString() == "")
            {
                labelServiceIDError.Visible = true;
                labelServiceIDError.Text = "Please enter ID for your service!";
            }
            else
            {
                labelServiceIDError.Visible = false;
                idValid = true;

            }

            //
            if (serviceNameValid && unitNameValid && priceValid && idValid && InStockValid)
            {
                if (servicesDB.InsertNewServices(id,serviceName, unitName, InStock, price))
                {
                    MessageBox.Show("New Service Inserted");
                    
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            string serviceName = string.Empty;
            serviceName = textBoxServiceName.Text;

            string unitName = string.Empty;
            unitName = textBoxUnitName.Text;

            string inStock = string.Empty;
            inStock = textBoxInStock.Text;    

            int price = Int32.MinValue;
            Int32.TryParse(textBoxPrice.Text, out price);
            int id = Int32.MinValue;
            Int32.TryParse(textBoxID.Text, out id);

            bool SNValid = false, unitValid = false, priceValid = false, InStockValid = false, IdValid = false;

            if (serviceName.Trim() == "")
            {
                labelServiceNameError.Visible = true;
                labelServiceNameError.Text = "Enter a NAME for the service.";
                SNValid = false;
            }
            else
            {
                labelServiceNameError.Visible = false;
                SNValid = true;
            }

            if (inStock.Trim() == "")
            {
                labelInStockError.Visible = true;
                labelInStockError.Text = "Enter a AVAILABILITY for the service.";
                InStockValid = false;
            }
            else
            {
                labelInStockError.Visible = false;
                InStockValid = true;
            }

            if (unitName.Trim() == "")
            {
                labelServiceUnitNameError.Visible = true;
                labelServiceUnitNameError.Text = "Please type the unit name for the service!";
                unitValid = false;
            }
            else
            {

                labelServiceUnitNameError.Visible = false;
                unitValid = true;

            }

            if (price == 0)
            {
                labelServicePriceError.Visible = true;
                labelServicePriceError.Text = "Please enter price for your service!";
                priceValid = false;
            }
            else
            {
                labelServicePriceError.Visible = false;
                priceValid = true;

            }

            if (id.ToString() == "")
            {
                labelServiceIDError.Visible = true;
                labelServiceIDError.Text = "Please enter NEW ID for your service!";
                IdValid = false;    
            }
            else
            {
                labelServiceIDError.Visible = false;
                IdValid = true;

            }

            if (SNValid && unitValid && priceValid && InStockValid && IdValid)
            {
                if (servicesDB.updateService(id, serviceName, unitName, price, inStock))
                {
                    MessageBox.Show("Service Updated!", "Update Infomation of Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Service yet Updated!", "Update Infomation of Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            textBoxID.Text = GridViewServicesList.CurrentRow.Cells[0].Value.ToString(); 
            textBoxServiceName.Text = GridViewServicesList.CurrentRow.Cells[1].Value.ToString();
            textBoxUnitName.Text = GridViewServicesList.CurrentRow.Cells[2].Value.ToString();
            textBoxPrice.Text = GridViewServicesList.CurrentRow.Cells[3].Value.ToString();
            textBoxInStock.Text = GridViewServicesList.CurrentRow.Cells[4].Value.ToString();    

            
        }

        private void btndau_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }
        private void btncuoi_Click(object sender, EventArgs e)
        {
            pos = servicesDB.getAllServices().Rows.Count - 1;
            showData(pos);
        }
        //XOA + UPDATE + BON CAI NUT
        #region Extra Functions

        void showData(int index)
        {
            try
            {
                DataRow datarow = servicesDB.getAllServices().Rows[index];
                textBoxID.Text = datarow.ItemArray[0].ToString();
                textBoxServiceName.Text = datarow.ItemArray[1].ToString();
                textBoxUnitName.Text = datarow.ItemArray[2].ToString();
                textBoxPrice.Text = datarow.ItemArray[3].ToString();
                textBoxInStock.Text = datarow.ItemArray[4].ToString();

            }
            catch {}
        }

        #endregion

        private void btnlen_Click(object sender, EventArgs e)
        {
            if (pos < (servicesDB.getAllServices().Rows.Count - 1))
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void btnxuong_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void btnketthuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
