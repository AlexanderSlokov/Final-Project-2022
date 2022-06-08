namespace Final_Project_2022.EmployeeControl_Manager
{
    partial class Attendance
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
            this.labelCheckOutTime = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxShiftType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.labelShiftAnnouncement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewSchedule = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCheckOutTime
            // 
            this.labelCheckOutTime.AllowDrop = true;
            this.labelCheckOutTime.AutoSize = true;
            this.labelCheckOutTime.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckOutTime.ForeColor = System.Drawing.Color.Teal;
            this.labelCheckOutTime.Location = new System.Drawing.Point(250, 159);
            this.labelCheckOutTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCheckOutTime.Name = "labelCheckOutTime";
            this.labelCheckOutTime.Size = new System.Drawing.Size(158, 46);
            this.labelCheckOutTime.TabIndex = 125;
            this.labelCheckOutTime.Text = "20:20:00";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AllowDrop = true;
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.ForeColor = System.Drawing.Color.Teal;
            this.labelStartTime.Location = new System.Drawing.Point(250, 103);
            this.labelStartTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(158, 46);
            this.labelStartTime.TabIndex = 124;
            this.labelStartTime.Text = "00:00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(35, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 123;
            this.label7.Text = "Shift Type";
            // 
            // textBoxShiftType
            // 
            this.textBoxShiftType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxShiftType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxShiftType.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxShiftType.Location = new System.Drawing.Point(202, 228);
            this.textBoxShiftType.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxShiftType.Multiline = true;
            this.textBoxShiftType.Name = "textBoxShiftType";
            this.textBoxShiftType.Size = new System.Drawing.Size(230, 34);
            this.textBoxShiftType.TabIndex = 122;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(33, 179);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 23);
            this.label6.TabIndex = 121;
            this.label6.Text = "Check Out Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(33, 123);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 120;
            this.label5.Text = "Start Time";
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.Turquoise;
            this.buttonCheckIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCheckIn.FlatAppearance.BorderSize = 0;
            this.buttonCheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckIn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.buttonCheckIn.ForeColor = System.Drawing.Color.Red;
            this.buttonCheckIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheckIn.Location = new System.Drawing.Point(141, 301);
            this.buttonCheckIn.Margin = new System.Windows.Forms.Padding(120, 111, 120, 111);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.buttonCheckIn.Size = new System.Drawing.Size(291, 113);
            this.buttonCheckIn.TabIndex = 119;
            this.buttonCheckIn.Text = "CHECK IN";
            this.buttonCheckIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCheckIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // labelShiftAnnouncement
            // 
            this.labelShiftAnnouncement.AutoSize = true;
            this.labelShiftAnnouncement.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.labelShiftAnnouncement.ForeColor = System.Drawing.Color.BlueViolet;
            this.labelShiftAnnouncement.Location = new System.Drawing.Point(13, 24);
            this.labelShiftAnnouncement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShiftAnnouncement.Name = "labelShiftAnnouncement";
            this.labelShiftAnnouncement.Size = new System.Drawing.Size(197, 34);
            this.labelShiftAnnouncement.TabIndex = 126;
            this.labelShiftAnnouncement.Text = "SHIFT INFO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.BlueViolet;
            this.label2.Location = new System.Drawing.Point(628, 418);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 34);
            this.label2.TabIndex = 128;
            this.label2.Text = "Your Today\' Schedule";
            // 
            // dataGridViewSchedule
            // 
            this.dataGridViewSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSchedule.Location = new System.Drawing.Point(537, 80);
            this.dataGridViewSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewSchedule.Name = "dataGridViewSchedule";
            this.dataGridViewSchedule.RowHeadersWidth = 51;
            this.dataGridViewSchedule.Size = new System.Drawing.Size(516, 334);
            this.dataGridViewSchedule.TabIndex = 127;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 474);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewSchedule);
            this.Controls.Add(this.labelShiftAnnouncement);
            this.Controls.Add(this.labelCheckOutTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxShiftType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonCheckIn);
            this.Name = "Attendance";
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSchedule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelCheckOutTime;
        public System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxShiftType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCheckIn;
        private System.Windows.Forms.Label labelShiftAnnouncement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewSchedule;
    }
}