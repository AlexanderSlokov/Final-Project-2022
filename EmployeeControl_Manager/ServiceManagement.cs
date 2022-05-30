using Final_Project_2022.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_2022.EmployeeControl_Manager
{
    public partial class ServiceManagement : Form
    {
       /*
         fServiceType _fServiceType;
        */
        
        
        public ServiceManagement()
        {
            this.DoubleBuffered = true;

            InitializeComponent();

            LoadFullService(GetFullService());
        }

        #region Load
        private void LoadFullService(DataTable table)
        {
            BindingSource source = new BindingSource();
            ChangePrice(table);
            source.DataSource = table;
            dataGridViewService.DataSource = source;
            bindingService.BindingSource = source;
            comboboxID.DataSource = source;
        }
        
        #endregion

        #region Get Data
        private DataTable GetFullService()
        {
            return ServiceDAO.Instance.LoadFullService();
        }

        private void ChangePrice(DataTable table)
        {
            table.Columns.Add("price_New", typeof(string));
            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i]["price_New"] = ((int)table.Rows[i]["price"]).ToString("C0", CultureInfo.CreateSpecificCulture("vi-VN"));
            }
        }

        #endregion

        
    }
}
