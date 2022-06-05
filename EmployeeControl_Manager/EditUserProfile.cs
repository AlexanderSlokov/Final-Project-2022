using Final_Project_2022.Classes;
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
    public partial class EditUserProfile : Form
    {
        public EditUserProfile()
        {
            InitializeComponent();
        }
        string UserName;     
        string password, passwordConfirm;

        public event EventHandler UpdateMainFormEvent;
        DatabaseOperating DatabaseOperating = new DatabaseOperating();

        protected virtual void OnUpdateMainForm()
        {
            if (UpdateMainFormEvent != null)
            {
                UpdateMainFormEvent(this, EventArgs.Empty);
            }
        }

        bool verif(string input)
        {
            if ((input.Trim()) == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            bool UserNameTyped = false,  passwordCheck = false, passwordTyped = false, passwordConfirmed = false;
            UserName = textBoxUsername.Text;
            password = textBoxPassword.Text;
            passwordConfirm = textBoxConfirmPassword.Text;

            if (!verif(UserName))
            {
                labelUserNameError.Visible = true;
                labelUserNameError.Text = ("Please enter your last name");
                UserNameTyped = false;
            }
            else
            {
                UserNameTyped = true;
                labelUserNameError.Text = string.Empty;
                labelUserNameError.Visible = false;
            }

            // check password
            if (password == "")
            {
                labelPasswordError.Visible = true;
                labelPasswordError.Text = ("Please Enter Password");
                passwordCheck = false;
                passwordTyped = false;
            }
            else
            {
                labelPasswordError.Text = string.Empty;
                passwordTyped = true;
            }
            // check password 2
            if (passwordConfirm == "")
            {
                labelConfirmPasswordError.Visible = true;
                labelConfirmPasswordError.Text = ("Please Confirm Your Password");
                passwordCheck = false;
                passwordConfirmed = false;
            }
            else
            {
                labelConfirmPasswordError.Text = string.Empty;
                passwordConfirmed = true;
            }
            // check 2 password giongnhau
            if (password == passwordConfirm && password.Length != 0 && passwordConfirm.Length != 0)
            {
                passwordCheck = true;

            }
            else
            {
                if (passwordTyped && passwordConfirmed)
                {
                    labelConfirmPasswordError.Visible = true;
                    labelConfirmPasswordError.Text = ("Passwords are not the same");
                    passwordCheck = false;
                }
            }

            if (UserNameTyped == true && passwordCheck == true )
            {
                labelPasswordError.Text = string.Empty;
                
                SqlCommand command = new SqlCommand("UPDATE employee SET username = @un, password = @pass WHERE id = @id", DatabaseOperating.GetConnection);

                command.Parameters.Add("@id", SqlDbType.Int).Value = CurrentUser.Id;              
                command.Parameters.Add("@un", SqlDbType.VarChar).Value = UserName;
                command.Parameters.Add("@pass", SqlDbType.VarChar).Value = password;
               

                DatabaseOperating.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show(this.Parent, "Sucessfully Modified Informations");
                    OnUpdateMainForm();
                    this.Close();
                    DatabaseOperating.closeConnection();
                }
                else
                {
                    DatabaseOperating.closeConnection();
                }
            }
            else
            {
                MessageBox.Show("Please Enter All Information");
            }

        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '•';
                textBoxConfirmPassword.PasswordChar = '•';
            }
        }

        

        private void EditUserProfile_Load(object sender, EventArgs e)
        {
            labelConfirmPasswordError.Visible = false;            
            labelPasswordError.Visible = false;
            labelUserNameError.Visible = false;
        
            checkBoxShowPassword.Checked = false;
            textBoxUsername.Text = CurrentUser.UserName;          
            textBoxPassword.Text = CurrentUser.Pass;
            textBoxConfirmPassword.Text = CurrentUser.Pass;
            
        }
    }
}
