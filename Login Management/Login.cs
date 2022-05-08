using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using Final_Project_2022;
using Final_Project_2022.Classes;

namespace Final_Project_2022
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ForgotPasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DatabaseOperating db = new DatabaseOperating();

            SqlDataAdapter adapter = new SqlDataAdapter();

            //create table to check validity of username and password
            DataTable table = new DataTable();

                                
                SqlCommand command = new SqlCommand("SELECT * FROM HumanResourse WHERE UserName = @User AND Password = @Pass", db.GetConnection);
                
                command.Parameters.Add("@User", SqlDbType.NVarChar).Value = textBox_Username.Text;
                command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = textBox_Password.Text;
                

                adapter.SelectCommand = command;
                adapter.Fill(table);
            
                if ((table.Rows.Count > 0))
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Welcome, and have a great day!");
                    CurrentUser.Email = textBox_Username.Text;
                    //active main form base on position
                    //Main_Form dashBoard = new Main_Form();
                    //dashBoard.Show(this);
                    this.Hide();
                }
               
           
        }


        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBox_Password.PasswordChar = '\0';
            }
            else
            {
                textBox_Password.PasswordChar = '•';
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }   
}
