namespace Final_Project_2022.MainForms
{
    partial class MainFormManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProfileListbutton = new System.Windows.Forms.Button();
            this.EditEmployeeProfilebutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonServiceManagement = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CurrentAccountLabel = new System.Windows.Forms.Label();
            this.EditProfilebutton = new System.Windows.Forms.Button();
            this.LogOutbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome, manager!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.ProfileListbutton);
            this.panel1.Controls.Add(this.EditEmployeeProfilebutton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 149);
            this.panel1.TabIndex = 1;
            // 
            // ProfileListbutton
            // 
            this.ProfileListbutton.BackColor = System.Drawing.Color.Snow;
            this.ProfileListbutton.Location = new System.Drawing.Point(3, 93);
            this.ProfileListbutton.Name = "ProfileListbutton";
            this.ProfileListbutton.Size = new System.Drawing.Size(194, 48);
            this.ProfileListbutton.TabIndex = 6;
            this.ProfileListbutton.Text = "Profile List";
            this.ProfileListbutton.UseVisualStyleBackColor = false;
            this.ProfileListbutton.Click += new System.EventHandler(this.ProfileListbutton_Click);
            // 
            // EditEmployeeProfilebutton
            // 
            this.EditEmployeeProfilebutton.BackColor = System.Drawing.Color.Snow;
            this.EditEmployeeProfilebutton.ForeColor = System.Drawing.Color.Coral;
            this.EditEmployeeProfilebutton.Location = new System.Drawing.Point(3, 39);
            this.EditEmployeeProfilebutton.Name = "EditEmployeeProfilebutton";
            this.EditEmployeeProfilebutton.Size = new System.Drawing.Size(194, 48);
            this.EditEmployeeProfilebutton.TabIndex = 3;
            this.EditEmployeeProfilebutton.Text = "Edit Employee Profile";
            this.EditEmployeeProfilebutton.UseVisualStyleBackColor = false;
            this.EditEmployeeProfilebutton.Click += new System.EventHandler(this.EditEmployeeProfilebutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Emloyees Profile Center";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonServiceManagement);
            this.panel3.Controls.Add(this.button);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(218, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 149);
            this.panel3.TabIndex = 3;
            // 
            // buttonServiceManagement
            // 
            this.buttonServiceManagement.Location = new System.Drawing.Point(3, 93);
            this.buttonServiceManagement.Name = "buttonServiceManagement";
            this.buttonServiceManagement.Size = new System.Drawing.Size(194, 48);
            this.buttonServiceManagement.TabIndex = 10;
            this.buttonServiceManagement.Text = "Management";
            this.buttonServiceManagement.UseVisualStyleBackColor = true;
            this.buttonServiceManagement.Click += new System.EventHandler(this.buttonServiceManagement_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(3, 39);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(194, 48);
            this.button.TabIndex = 9;
            this.button.Text = "Add New";
            this.button.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Service Management";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.CurrentAccountLabel);
            this.panel5.Controls.Add(this.EditProfilebutton);
            this.panel5.Controls.Add(this.LogOutbutton);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(12, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(830, 109);
            this.panel5.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(479, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // CurrentAccountLabel
            // 
            this.CurrentAccountLabel.AutoSize = true;
            this.CurrentAccountLabel.Location = new System.Drawing.Point(125, 14);
            this.CurrentAccountLabel.Name = "CurrentAccountLabel";
            this.CurrentAccountLabel.Size = new System.Drawing.Size(187, 16);
            this.CurrentAccountLabel.TabIndex = 3;
            this.CurrentAccountLabel.Text = "CURRENT ACCOUNT LABEL";
            // 
            // EditProfilebutton
            // 
            this.EditProfilebutton.Location = new System.Drawing.Point(618, 4);
            this.EditProfilebutton.Name = "EditProfilebutton";
            this.EditProfilebutton.Size = new System.Drawing.Size(197, 53);
            this.EditProfilebutton.TabIndex = 2;
            this.EditProfilebutton.Text = "Edit Profile";
            this.EditProfilebutton.UseVisualStyleBackColor = true;
            // 
            // LogOutbutton
            // 
            this.LogOutbutton.Location = new System.Drawing.Point(618, 63);
            this.LogOutbutton.Name = "LogOutbutton";
            this.LogOutbutton.Size = new System.Drawing.Size(197, 41);
            this.LogOutbutton.TabIndex = 1;
            this.LogOutbutton.Text = "Log Out";
            this.LogOutbutton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Current Account :";
            // 
            // MainFormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(858, 368);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "MainFormManager";
            this.Text = "MainFormManager";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button EditProfilebutton;
        private System.Windows.Forms.Button LogOutbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EditEmployeeProfilebutton;
        private System.Windows.Forms.Button buttonServiceManagement;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label CurrentAccountLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ProfileListbutton;
    }
}