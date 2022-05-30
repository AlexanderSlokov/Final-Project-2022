using Final_Project_2022.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Final_Project_2022.Classes;

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

       

    }
}
