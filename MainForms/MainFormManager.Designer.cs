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
            this.buttonprintsalary = new System.Windows.Forms.Button();
            this.ProfileListbutton = new System.Windows.Forms.Button();
            this.EditEmployeeProfilebutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonServiceOrder = new System.Windows.Forms.Button();
            this.buttonServiceManagement = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonEditProfile = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.CurrentAccountLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSalary = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Controls.Add(this.buttonprintsalary);
            this.panel1.Controls.Add(this.ProfileListbutton);
            this.panel1.Controls.Add(this.EditEmployeeProfilebutton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 202);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 193);
            this.panel1.TabIndex = 1;
            // 
            // buttonprintsalary
            // 
            this.buttonprintsalary.BackColor = System.Drawing.Color.Snow;
            this.buttonprintsalary.ForeColor = System.Drawing.Color.Coral;
            this.buttonprintsalary.Location = new System.Drawing.Point(3, 142);
            this.buttonprintsalary.Name = "buttonprintsalary";
            this.buttonprintsalary.Size = new System.Drawing.Size(194, 48);
            this.buttonprintsalary.TabIndex = 7;
            this.buttonprintsalary.Text = "Print Salary Report";
            this.buttonprintsalary.UseVisualStyleBackColor = false;
            this.buttonprintsalary.Click += new System.EventHandler(this.buttonprintsalary_Click);
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
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.buttonServiceOrder);
            this.panel3.Controls.Add(this.buttonServiceManagement);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(218, 202);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 193);
            this.panel3.TabIndex = 3;
            // 
            // buttonServiceOrder
            // 
            this.buttonServiceOrder.BackColor = System.Drawing.Color.Snow;
            this.buttonServiceOrder.ForeColor = System.Drawing.Color.Coral;
            this.buttonServiceOrder.Location = new System.Drawing.Point(3, 93);
            this.buttonServiceOrder.Name = "buttonServiceOrder";
            this.buttonServiceOrder.Size = new System.Drawing.Size(194, 48);
            this.buttonServiceOrder.TabIndex = 11;
            this.buttonServiceOrder.Text = "Service Order";
            this.buttonServiceOrder.UseVisualStyleBackColor = false;
            this.buttonServiceOrder.Click += new System.EventHandler(this.buttonServiceOrder_Click);
            // 
            // buttonServiceManagement
            // 
            this.buttonServiceManagement.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonServiceManagement.Location = new System.Drawing.Point(3, 39);
            this.buttonServiceManagement.Name = "buttonServiceManagement";
            this.buttonServiceManagement.Size = new System.Drawing.Size(194, 48);
            this.buttonServiceManagement.TabIndex = 10;
            this.buttonServiceManagement.Text = "Manage";
            this.buttonServiceManagement.UseVisualStyleBackColor = false;
            this.buttonServiceManagement.Click += new System.EventHandler(this.buttonServiceManagement_Click);
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
            this.panel5.Controls.Add(this.buttonEditProfile);
            this.panel5.Controls.Add(this.pictureBox);
            this.panel5.Controls.Add(this.CurrentAccountLabel);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(12, 48);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(612, 109);
            this.panel5.TabIndex = 4;
            // 
            // buttonEditProfile
            // 
            this.buttonEditProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonEditProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEditProfile.FlatAppearance.BorderSize = 0;
            this.buttonEditProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditProfile.ForeColor = System.Drawing.Color.Snow;
            this.buttonEditProfile.Location = new System.Drawing.Point(479, 4);
            this.buttonEditProfile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditProfile.Name = "buttonEditProfile";
            this.buttonEditProfile.Size = new System.Drawing.Size(130, 101);
            this.buttonEditProfile.TabIndex = 146;
            this.buttonEditProfile.Text = "EDIT PROFILE";
            this.buttonEditProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonEditProfile.UseVisualStyleBackColor = false;
            this.buttonEditProfile.Click += new System.EventHandler(this.buttonEditProfile_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(353, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(119, 100);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // CurrentAccountLabel
            // 
            this.CurrentAccountLabel.AutoSize = true;
            this.CurrentAccountLabel.Location = new System.Drawing.Point(160, 17);
            this.CurrentAccountLabel.Name = "CurrentAccountLabel";
            this.CurrentAccountLabel.Size = new System.Drawing.Size(187, 16);
            this.CurrentAccountLabel.TabIndex = 3;
            this.CurrentAccountLabel.Text = "CURRENT ACCOUNT LABEL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Current Manager :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.buttonSalary);
            this.panel2.Controls.Add(this.buttonAttendance);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(424, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 193);
            this.panel2.TabIndex = 5;
            // 
            // buttonSalary
            // 
            this.buttonSalary.BackColor = System.Drawing.Color.Snow;
            this.buttonSalary.ForeColor = System.Drawing.Color.Coral;
            this.buttonSalary.Location = new System.Drawing.Point(3, 145);
            this.buttonSalary.Name = "buttonSalary";
            this.buttonSalary.Size = new System.Drawing.Size(194, 48);
            this.buttonSalary.TabIndex = 5;
            this.buttonSalary.Text = "Salary Calculator";
            this.buttonSalary.UseVisualStyleBackColor = false;
            this.buttonSalary.Click += new System.EventHandler(this.buttonSalary_Click);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.BackColor = System.Drawing.Color.Snow;
            this.buttonAttendance.ForeColor = System.Drawing.Color.Coral;
            this.buttonAttendance.Location = new System.Drawing.Point(3, 93);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(194, 48);
            this.buttonAttendance.TabIndex = 4;
            this.buttonAttendance.Text = "Attendance";
            this.buttonAttendance.UseVisualStyleBackColor = false;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.ForeColor = System.Drawing.Color.Coral;
            this.button2.Location = new System.Drawing.Point(3, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 48);
            this.button2.TabIndex = 3;
            this.button2.Text = "Manage";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Schedule Management";
            // 
            // MainFormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(641, 407);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "MainFormManager";
            this.Text = "MainFormManager";
            this.Load += new System.EventHandler(this.MainFormManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button EditEmployeeProfilebutton;
        private System.Windows.Forms.Button buttonServiceManagement;
        private System.Windows.Forms.Label CurrentAccountLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button ProfileListbutton;
        private System.Windows.Forms.Button buttonEditProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonServiceOrder;
        private System.Windows.Forms.Button buttonAttendance;
        private System.Windows.Forms.Button buttonSalary;
        private System.Windows.Forms.Button buttonprintsalary;
    }
}