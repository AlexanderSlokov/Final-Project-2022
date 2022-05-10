using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Project_2022.EmployeeControl_Manager;

namespace Final_Project_2022.MainForms
{
    public partial class MainFormManager : Form
    {
        public MainFormManager()
        {
            InitializeComponent();
        }

        private void ProfileListbutton_Click(object sender, EventArgs e)
        {
            ProfileListForm profileList = new ProfileListForm();
            profileList.ShowDialog();   
        }
    }
}
