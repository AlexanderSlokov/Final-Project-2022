using Final_Project_2022.Classes;
using Final_Project_2022.Classes.Room;
using Final_Project_2022.Classes.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project_2022.EmployeeControl_Manager
{
    public partial class service_Order : Form
    {

        DatabaseOperating database = new DatabaseOperating();  
        ServicesDB servicesDB = new ServicesDB();
        RoomDB room = new RoomDB();
        Service_Order order = new Service_Order();
        Room_Bill_DB Room_Bill_DB = new Room_Bill_DB(); 
      
        public service_Order()
        {
            InitializeComponent();

            dateTimePicker.Value = DateTime.Now;
        }

       

        private void service_Order_Load(object sender, EventArgs e)
        {
            
            LoadData();
            
        }

        public void fillGrid(SqlCommand command)
        {
            dataGridViewServiceList.ReadOnly = true;
            dataGridViewServiceList.DataSource = servicesDB.getServiceList(command);
            dataGridViewServiceList.AllowUserToAddRows = false;         
        }

        public void InsertServiceBill()
        {
           
            
            string RoomID =  comboBoxRoomID.SelectedValue.ToString();
            int id_room_bill = Room_Bill_DB.Get_idRoomBill_On_idRoom(RoomID);
           
            string serviceName = textBoxServiceName.Text;          
            string orderDate = dateTimePicker.Text.ToString();

            int Number;
            try
            {
                Number = Int32.Parse(textBoxResqNum.Text);
            }
            catch
            {
                Number = 0;
            }

                if (order.InsertServiceOrder(id_room_bill,serviceName,orderDate, Number))
                {
                    MessageBox.Show("Successfully Added New Shift", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed To Added New Order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        public void LoadData()
        {
            fillGrid(new SqlCommand("SELECT * FROM services", database.GetConnection));

            dataGridViewServiceList.RowHeadersVisible = false;
            dataGridViewServiceList.AllowUserToAddRows = false;

            dataGridViewServiceList.Columns["ID"].Width = 50;
            dataGridViewServiceList.Columns["ID"].HeaderText = "Service ID";
            dataGridViewServiceList.Columns["ID"].DisplayIndex = 0;

            dataGridViewServiceList.Columns["ServiceName"].Width = 100;
            dataGridViewServiceList.Columns["ServiceName"].HeaderText = "Service Name";
            dataGridViewServiceList.Columns["ServiceName"].DisplayIndex = 1;

            dataGridViewServiceList.Columns["Unit"].Width = 100;
            dataGridViewServiceList.Columns["Unit"].HeaderText = "Unit of Service";
            dataGridViewServiceList.Columns["Unit"].DisplayIndex = 2;

            dataGridViewServiceList.Columns["Price"].Width = 100;
            dataGridViewServiceList.Columns["Price"].HeaderText = "Service Price";
            dataGridViewServiceList.Columns["Price"].DisplayIndex = 3;

            dataGridViewServiceList.Columns["InStock"].Width = 100;
            dataGridViewServiceList.Columns["InStock"].HeaderText = "Current In Stock";
            dataGridViewServiceList.Columns["InStock"].DisplayIndex = 4;

            

            comboBoxRoomID.DataSource = room.GetAllRoom_InUse_ForComboBox();
            comboBoxRoomID.DisplayMember = "idRoom";
            comboBoxRoomID.ValueMember = "idRoom";   
        }



        private void buttonSAVE_Click(object sender, EventArgs e)
        {
            InsertServiceBill();
        }

        private void dataGridViewServiceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxServiceName.Text = dataGridViewServiceList.CurrentRow.Cells["ServiceName"].Value.ToString();
            textBoxServicePrice.Text = dataGridViewServiceList.CurrentRow.Cells["Price"].Value.ToString();

            
        }
    }
}
