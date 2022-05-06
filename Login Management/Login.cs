using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System;
using Final_Project_2022.Login_Management;

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

            if (radioButtonManager.Checked)
            {                               
                SqlCommand command = new SqlCommand("SELECT * FROM LoginAdminInfo WHERE UserName = @User AND Password = @Pass", db.GetConnection);
                command.Parameters.Add("@User", SqlDbType.NVarChar).Value = textBox_Username.Text;
                command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = textBox_Password.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if ((table.Rows.Count > 0))
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Welcome, and have a great day!");
                    //active main form
                    Main_Form dashBoard = new Main_Form();
                    dashBoard.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password! Please, check again...", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (radioButtonEmployees.Checked)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM LoginEmployeesInfo WHERE UserName = @User AND Password = @Pass", db.GetConnection);
                command.Parameters.Add("@User", SqlDbType.NVarChar).Value = textBox_Username.Text;
                command.Parameters.Add("@Pass", SqlDbType.NVarChar).Value = textBox_Password.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if ((table.Rows.Count > 0))
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Welcome, and have a great day!");
                    //active main form
                    Main_Form dashBoard = new Main_Form();
                    dashBoard.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password! Please, check again...", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void createAccLabel_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show(this);
            this.Hide();
        }
    }   
}
