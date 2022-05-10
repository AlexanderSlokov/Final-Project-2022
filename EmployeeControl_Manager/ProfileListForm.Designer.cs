namespace Final_Project_2022.EmployeeControl_Manager
{
    partial class ProfileListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileListForm));
            this.radioButtonFemaleList = new System.Windows.Forms.RadioButton();
            this.radioButtonAllGenderList = new System.Windows.Forms.RadioButton();
            this.radioButtonMaleList = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewEmployeeList = new System.Windows.Forms.DataGridView();
            this.ButtonToEXcelFileList = new System.Windows.Forms.Button();
            this.buttonCheckList = new System.Windows.Forms.Button();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButtonFemaleList
            // 
            this.radioButtonFemaleList.AutoSize = true;
            this.radioButtonFemaleList.Location = new System.Drawing.Point(800, 72);
            this.radioButtonFemaleList.Name = "radioButtonFemaleList";
            this.radioButtonFemaleList.Size = new System.Drawing.Size(74, 20);
            this.radioButtonFemaleList.TabIndex = 19;
            this.radioButtonFemaleList.TabStop = true;
            this.radioButtonFemaleList.Text = "Female";
            this.radioButtonFemaleList.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllGenderList
            // 
            this.radioButtonAllGenderList.AutoSize = true;
            this.radioButtonAllGenderList.Location = new System.Drawing.Point(492, 72);
            this.radioButtonAllGenderList.Name = "radioButtonAllGenderList";
            this.radioButtonAllGenderList.Size = new System.Drawing.Size(91, 20);
            this.radioButtonAllGenderList.TabIndex = 18;
            this.radioButtonAllGenderList.TabStop = true;
            this.radioButtonAllGenderList.Text = "All Gender";
            this.radioButtonAllGenderList.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaleList
            // 
            this.radioButtonMaleList.AutoSize = true;
            this.radioButtonMaleList.Location = new System.Drawing.Point(660, 72);
            this.radioButtonMaleList.Name = "radioButtonMaleList";
            this.radioButtonMaleList.Size = new System.Drawing.Size(58, 20);
            this.radioButtonMaleList.TabIndex = 17;
            this.radioButtonMaleList.TabStop = true;
            this.radioButtonMaleList.Text = "Male";
            this.radioButtonMaleList.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Picking up students by gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(660, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pick Student Birth Date From:";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(462, 21);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(183, 22);
            this.dateTimePickerStartDate.TabIndex = 13;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(693, 21);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(181, 22);
            this.dateTimePickerEndDate.TabIndex = 12;
            // 
            // dataGridViewEmployeeList
            // 
            this.dataGridViewEmployeeList.AllowUserToOrderColumns = true;
            this.dataGridViewEmployeeList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(144)))), ((int)(((byte)(244)))));
            this.dataGridViewEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeList.Location = new System.Drawing.Point(171, 119);
            this.dataGridViewEmployeeList.Name = "dataGridViewEmployeeList";
            this.dataGridViewEmployeeList.RowHeadersWidth = 51;
            this.dataGridViewEmployeeList.RowTemplate.Height = 100;
            this.dataGridViewEmployeeList.Size = new System.Drawing.Size(703, 350);
            this.dataGridViewEmployeeList.TabIndex = 11;
            // 
            // ButtonToEXcelFileList
            // 
            this.ButtonToEXcelFileList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonToEXcelFileList.BackgroundImage")));
            this.ButtonToEXcelFileList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonToEXcelFileList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonToEXcelFileList.Location = new System.Drawing.Point(8, 393);
            this.ButtonToEXcelFileList.Name = "ButtonToEXcelFileList";
            this.ButtonToEXcelFileList.Size = new System.Drawing.Size(157, 77);
            this.ButtonToEXcelFileList.TabIndex = 22;
            this.ButtonToEXcelFileList.Text = "To EXcel File";
            this.ButtonToEXcelFileList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonToEXcelFileList.UseVisualStyleBackColor = true;
            // 
            // buttonCheckList
            // 
            this.buttonCheckList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCheckList.BackgroundImage")));
            this.buttonCheckList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonCheckList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckList.Location = new System.Drawing.Point(8, 297);
            this.buttonCheckList.Name = "buttonCheckList";
            this.buttonCheckList.Size = new System.Drawing.Size(157, 76);
            this.buttonCheckList.TabIndex = 21;
            this.buttonCheckList.Text = "Check";
            this.buttonCheckList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCheckList.UseVisualStyleBackColor = true;
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefreshList.BackgroundImage")));
            this.buttonRefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshList.Location = new System.Drawing.Point(8, 203);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(157, 74);
            this.buttonRefreshList.TabIndex = 20;
            this.buttonRefreshList.Text = "Refresh";
            this.buttonRefreshList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            // 
            // ProfileListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 481);
            this.Controls.Add(this.ButtonToEXcelFileList);
            this.Controls.Add(this.buttonCheckList);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.radioButtonFemaleList);
            this.Controls.Add(this.radioButtonAllGenderList);
            this.Controls.Add(this.radioButtonMaleList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dataGridViewEmployeeList);
            this.Name = "ProfileListForm";
            this.Text = "ProfileListForm";
            this.Load += new System.EventHandler(this.ProfileListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonFemaleList;
        private System.Windows.Forms.RadioButton radioButtonAllGenderList;
        private System.Windows.Forms.RadioButton radioButtonMaleList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeList;
        private System.Windows.Forms.Button ButtonToEXcelFileList;
        private System.Windows.Forms.Button buttonCheckList;
        private System.Windows.Forms.Button buttonRefreshList;
    }
}