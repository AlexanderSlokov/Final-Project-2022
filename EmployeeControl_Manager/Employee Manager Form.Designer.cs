namespace Final_Project_2022.EmployeeControl_Manager
{
    partial class Employee_Manager_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Manager_Form));
            this.buttonSwitchEmployee = new System.Windows.Forms.Button();
            this.buttonSwitchManagers = new System.Windows.Forms.Button();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdateInformation = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEMAIL = new System.Windows.Forms.TextBox();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.radioButtonFEMALE = new System.Windows.Forms.RadioButton();
            this.radioButtonMALE = new System.Windows.Forms.RadioButton();
            this.buttonUploadImage = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.pictureBoxEMPLOYEE = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEMPLOYEE)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSwitchEmployee
            // 
            this.buttonSwitchEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonSwitchEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSwitchEmployee.FlatAppearance.BorderSize = 0;
            this.buttonSwitchEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitchEmployee.ForeColor = System.Drawing.Color.Snow;
            this.buttonSwitchEmployee.Location = new System.Drawing.Point(776, 9);
            this.buttonSwitchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSwitchEmployee.Name = "buttonSwitchEmployee";
            this.buttonSwitchEmployee.Size = new System.Drawing.Size(539, 47);
            this.buttonSwitchEmployee.TabIndex = 145;
            this.buttonSwitchEmployee.Text = "EMPLOYEE";
            this.buttonSwitchEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSwitchEmployee.UseVisualStyleBackColor = false;
            // 
            // buttonSwitchManagers
            // 
            this.buttonSwitchManagers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonSwitchManagers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSwitchManagers.FlatAppearance.BorderSize = 0;
            this.buttonSwitchManagers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSwitchManagers.ForeColor = System.Drawing.Color.Linen;
            this.buttonSwitchManagers.Location = new System.Drawing.Point(1323, 9);
            this.buttonSwitchManagers.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSwitchManagers.Name = "buttonSwitchManagers";
            this.buttonSwitchManagers.Size = new System.Drawing.Size(455, 47);
            this.buttonSwitchManagers.TabIndex = 146;
            this.buttonSwitchManagers.Text = "MANAGERS";
            this.buttonSwitchManagers.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSwitchManagers.UseVisualStyleBackColor = false;
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefreshList.BackgroundImage")));
            this.buttonRefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshList.Location = new System.Drawing.Point(582, 520);
            this.buttonRefreshList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(149, 47);
            this.buttonRefreshList.TabIndex = 144;
            this.buttonRefreshList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefreshList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.AutoCompleteCustomSource.AddRange(new string[] {
            "employee",
            "manager"});
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Employee",
            "Manager"});
            this.comboBoxPosition.Location = new System.Drawing.Point(166, 322);
            this.comboBoxPosition.Margin = new System.Windows.Forms.Padding(5);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(187, 24);
            this.comboBoxPosition.TabIndex = 143;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label12.Location = new System.Drawing.Point(24, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 25);
            this.label12.TabIndex = 142;
            this.label12.Text = "Position:";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(394, 520);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(180, 47);
            this.buttonDelete.TabIndex = 141;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // buttonUpdateInformation
            // 
            this.buttonUpdateInformation.BackColor = System.Drawing.Color.Turquoise;
            this.buttonUpdateInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateInformation.FlatAppearance.BorderSize = 0;
            this.buttonUpdateInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateInformation.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdateInformation.Location = new System.Drawing.Point(204, 520);
            this.buttonUpdateInformation.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateInformation.Name = "buttonUpdateInformation";
            this.buttonUpdateInformation.Size = new System.Drawing.Size(181, 47);
            this.buttonUpdateInformation.TabIndex = 140;
            this.buttonUpdateInformation.Text = "UPDATE INFORMATION";
            this.buttonUpdateInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateInformation.UseVisualStyleBackColor = false;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddEmployee.FlatAppearance.BorderSize = 0;
            this.buttonAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEmployee.ForeColor = System.Drawing.Color.Linen;
            this.buttonAddEmployee.Location = new System.Drawing.Point(15, 520);
            this.buttonAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(181, 47);
            this.buttonAddEmployee.TabIndex = 139;
            this.buttonAddEmployee.Text = "ADD NEW";
            this.buttonAddEmployee.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonAddEmployee.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label11.Location = new System.Drawing.Point(1147, -34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 32);
            this.label11.TabIndex = 138;
            this.label11.Text = "Employee List";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxShowPassword.Location = new System.Drawing.Point(166, 206);
            this.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(151, 27);
            this.checkBoxShowPassword.TabIndex = 137;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(166, 124);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(187, 22);
            this.textBoxUsername.TabIndex = 136;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.Username.Location = new System.Drawing.Point(24, 121);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(101, 25);
            this.Username.TabIndex = 135;
            this.Username.Text = "Username";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(166, 176);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(187, 22);
            this.textBoxPassword.TabIndex = 134;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label1.Location = new System.Drawing.Point(24, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 133;
            this.label1.Text = "Password:";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(166, 268);
            this.textBoxSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(187, 22);
            this.textBoxSalary.TabIndex = 132;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label10.Location = new System.Drawing.Point(22, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 50);
            this.label10.TabIndex = 131;
            this.label10.Text = "Salary\r\n(Per Hour):";
            // 
            // textBoxEMAIL
            // 
            this.textBoxEMAIL.Location = new System.Drawing.Point(544, 382);
            this.textBoxEMAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEMAIL.Name = "textBoxEMAIL";
            this.textBoxEMAIL.Size = new System.Drawing.Size(187, 22);
            this.textBoxEMAIL.TabIndex = 130;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(776, 69);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 80;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1003, 499);
            this.dataGridViewEmployee.TabIndex = 112;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label9.Location = new System.Drawing.Point(23, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 25);
            this.label9.TabIndex = 129;
            this.label9.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(166, 71);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(187, 22);
            this.textBoxID.TabIndex = 128;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(544, 444);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(187, 22);
            this.textBoxAge.TabIndex = 127;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(166, 20);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(187, 22);
            this.textBoxFullName.TabIndex = 126;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(166, 444);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(248, 22);
            this.dateTimePicker.TabIndex = 125;
            // 
            // radioButtonFEMALE
            // 
            this.radioButtonFEMALE.AutoSize = true;
            this.radioButtonFEMALE.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButtonFEMALE.Location = new System.Drawing.Point(260, 381);
            this.radioButtonFEMALE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFEMALE.Name = "radioButtonFEMALE";
            this.radioButtonFEMALE.Size = new System.Drawing.Size(88, 27);
            this.radioButtonFEMALE.TabIndex = 124;
            this.radioButtonFEMALE.Text = "Female";
            this.radioButtonFEMALE.UseVisualStyleBackColor = true;
            // 
            // radioButtonMALE
            // 
            this.radioButtonMALE.AutoSize = true;
            this.radioButtonMALE.Checked = true;
            this.radioButtonMALE.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.radioButtonMALE.Location = new System.Drawing.Point(166, 381);
            this.radioButtonMALE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMALE.Name = "radioButtonMALE";
            this.radioButtonMALE.Size = new System.Drawing.Size(70, 27);
            this.radioButtonMALE.TabIndex = 123;
            this.radioButtonMALE.TabStop = true;
            this.radioButtonMALE.Text = "Male";
            this.radioButtonMALE.UseVisualStyleBackColor = true;
            // 
            // buttonUploadImage
            // 
            this.buttonUploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonUploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUploadImage.ForeColor = System.Drawing.Color.White;
            this.buttonUploadImage.Location = new System.Drawing.Point(486, 8);
            this.buttonUploadImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUploadImage.Name = "buttonUploadImage";
            this.buttonUploadImage.Size = new System.Drawing.Size(247, 37);
            this.buttonUploadImage.TabIndex = 122;
            this.buttonUploadImage.Text = "Upload Image";
            this.buttonUploadImage.UseVisualStyleBackColor = false;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(544, 327);
            this.textBoxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(187, 22);
            this.textBoxPhone.TabIndex = 121;
            // 
            // pictureBoxEMPLOYEE
            // 
            this.pictureBoxEMPLOYEE.BackColor = System.Drawing.Color.Linen;
            this.pictureBoxEMPLOYEE.Location = new System.Drawing.Point(486, 50);
            this.pictureBoxEMPLOYEE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxEMPLOYEE.Name = "pictureBoxEMPLOYEE";
            this.pictureBoxEMPLOYEE.Size = new System.Drawing.Size(248, 242);
            this.pictureBoxEMPLOYEE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEMPLOYEE.TabIndex = 120;
            this.pictureBoxEMPLOYEE.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label8.Location = new System.Drawing.Point(375, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 119;
            this.label8.Text = "Picture:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label7.Location = new System.Drawing.Point(460, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 118;
            this.label7.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(462, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 117;
            this.label6.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(30, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 116;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(24, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 115;
            this.label4.Text = "Birthdate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(462, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 114;
            this.label3.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(24, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 113;
            this.label2.Text = "Full Name:";
            // 
            // Employee_Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 583);
            this.Controls.Add(this.buttonSwitchEmployee);
            this.Controls.Add(this.buttonSwitchManagers);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdateInformation);
            this.Controls.Add(this.buttonAddEmployee);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxEMAIL);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.radioButtonFEMALE);
            this.Controls.Add(this.radioButtonMALE);
            this.Controls.Add(this.buttonUploadImage);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.pictureBoxEMPLOYEE);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Employee_Manager_Form";
            this.Text = "Employee_Manager_Form";
            this.Load += new System.EventHandler(this.Employee_Manager_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEMPLOYEE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSwitchEmployee;
        private System.Windows.Forms.Button buttonSwitchManagers;
        private System.Windows.Forms.Button buttonRefreshList;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdateInformation;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEMAIL;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton radioButtonFEMALE;
        private System.Windows.Forms.RadioButton radioButtonMALE;
        private System.Windows.Forms.Button buttonUploadImage;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.PictureBox pictureBoxEMPLOYEE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}