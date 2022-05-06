namespace Final_Project_2022
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.createAccLabel = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.ForgotPasswordLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonManager = new System.Windows.Forms.RadioButton();
            this.radioButtonEmployees = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 21);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // createAccLabel
            // 
            this.createAccLabel.AutoSize = true;
            this.createAccLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.createAccLabel.ForeColor = System.Drawing.Color.LightCoral;
            this.createAccLabel.Location = new System.Drawing.Point(18, 401);
            this.createAccLabel.Name = "createAccLabel";
            this.createAccLabel.Size = new System.Drawing.Size(212, 25);
            this.createAccLabel.TabIndex = 20;
            this.createAccLabel.Text = "Do you have an account?";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPassword.ForeColor = System.Drawing.Color.LightCoral;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(180, 335);
            this.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(120, 20);
            this.checkBoxShowPassword.TabIndex = 19;
            this.checkBoxShowPassword.Text = "See Password ";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.LightCoral;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonLogin.Location = new System.Drawing.Point(21, 359);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(279, 40);
            this.buttonLogin.TabIndex = 18;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label3.Location = new System.Drawing.Point(18, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(20, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password:";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(21, 246);
            this.textBox_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(279, 22);
            this.textBox_Username.TabIndex = 15;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(23, 309);
            this.textBox_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '•';
            this.textBox_Password.Size = new System.Drawing.Size(277, 22);
            this.textBox_Password.TabIndex = 14;
            // 
            // ForgotPasswordLabel
            // 
            this.ForgotPasswordLabel.AutoSize = true;
            this.ForgotPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.ForgotPasswordLabel.ForeColor = System.Drawing.Color.LightCoral;
            this.ForgotPasswordLabel.Location = new System.Drawing.Point(18, 426);
            this.ForgotPasswordLabel.Name = "ForgotPasswordLabel";
            this.ForgotPasswordLabel.Size = new System.Drawing.Size(147, 25);
            this.ForgotPasswordLabel.TabIndex = 21;
            this.ForgotPasswordLabel.Text = "Forgot Password";
            this.ForgotPasswordLabel.Click += new System.EventHandler(this.ForgotPasswordLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label2.Location = new System.Drawing.Point(20, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "For:";
            // 
            // radioButtonManager
            // 
            this.radioButtonManager.AutoSize = true;
            this.radioButtonManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonManager.ForeColor = System.Drawing.Color.LightCoral;
            this.radioButtonManager.Location = new System.Drawing.Point(23, 162);
            this.radioButtonManager.Name = "radioButtonManager";
            this.radioButtonManager.Size = new System.Drawing.Size(231, 24);
            this.radioButtonManager.TabIndex = 24;
            this.radioButtonManager.TabStop = true;
            this.radioButtonManager.Text = "Manager (administiator)";
            this.radioButtonManager.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmployees
            // 
            this.radioButtonEmployees.AutoSize = true;
            this.radioButtonEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEmployees.ForeColor = System.Drawing.Color.LightCoral;
            this.radioButtonEmployees.Location = new System.Drawing.Point(23, 188);
            this.radioButtonEmployees.Name = "radioButtonEmployees";
            this.radioButtonEmployees.Size = new System.Drawing.Size(121, 24);
            this.radioButtonEmployees.TabIndex = 25;
            this.radioButtonEmployees.TabStop = true;
            this.radioButtonEmployees.Text = "Employees";
            this.radioButtonEmployees.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(331, 464);
            this.Controls.Add(this.radioButtonEmployees);
            this.Controls.Add(this.radioButtonManager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ForgotPasswordLabel);
            this.Controls.Add(this.createAccLabel);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LoginForm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label createAccLabel;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label ForgotPasswordLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButtonManager;
        private System.Windows.Forms.RadioButton radioButtonEmployees;
    }
}

