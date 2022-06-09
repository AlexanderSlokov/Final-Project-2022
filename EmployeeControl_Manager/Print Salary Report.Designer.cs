namespace Final_Project_2022.EmployeeControl_Manager
{
    partial class Print_Salary_Report
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
            this.buttonToPrinter = new System.Windows.Forms.Button();
            this.buttonToText = new System.Windows.Forms.Button();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.labelEndTime = new System.Windows.Forms.Label();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labeLQ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonToPrinter
            // 
            this.buttonToPrinter.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonToPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToPrinter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonToPrinter.Location = new System.Drawing.Point(845, 4);
            this.buttonToPrinter.Margin = new System.Windows.Forms.Padding(4);
            this.buttonToPrinter.Name = "buttonToPrinter";
            this.buttonToPrinter.Size = new System.Drawing.Size(135, 63);
            this.buttonToPrinter.TabIndex = 2;
            this.buttonToPrinter.Text = "To Printer";
            this.buttonToPrinter.UseVisualStyleBackColor = false;
            this.buttonToPrinter.Click += new System.EventHandler(this.buttonToPrinter_Click);
            // 
            // buttonToText
            // 
            this.buttonToText.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonToText.Location = new System.Drawing.Point(702, 4);
            this.buttonToText.Margin = new System.Windows.Forms.Padding(4);
            this.buttonToText.Name = "buttonToText";
            this.buttonToText.Size = new System.Drawing.Size(135, 63);
            this.buttonToText.TabIndex = 1;
            this.buttonToText.Text = "To Text";
            this.buttonToText.UseVisualStyleBackColor = false;
            this.buttonToText.Click += new System.EventHandler(this.buttonToText_Click);
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(13, 107);
            this.dataGridViewCourses.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 51;
            this.dataGridViewCourses.Size = new System.Drawing.Size(967, 317);
            this.dataGridViewCourses.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(12, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(810, 25);
            this.label12.TabIndex = 143;
            this.label12.Text = "Attention: All records will be reset after 6:30 AM. Please print or save to preve" +
    "nt data lost! ";
            // 
            // labelEndTime
            // 
            this.labelEndTime.AllowDrop = true;
            this.labelEndTime.AutoSize = true;
            this.labelEndTime.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndTime.ForeColor = System.Drawing.Color.Teal;
            this.labelEndTime.Location = new System.Drawing.Point(400, 41);
            this.labelEndTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelEndTime.Name = "labelEndTime";
            this.labelEndTime.Size = new System.Drawing.Size(112, 32);
            this.labelEndTime.TabIndex = 156;
            this.labelEndTime.Text = "06:30:00";
            // 
            // labelStartTime
            // 
            this.labelStartTime.AllowDrop = true;
            this.labelStartTime.AutoSize = true;
            this.labelStartTime.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartTime.ForeColor = System.Drawing.Color.Teal;
            this.labelStartTime.Location = new System.Drawing.Point(400, 9);
            this.labelStartTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(112, 32);
            this.labelStartTime.TabIndex = 155;
            this.labelStartTime.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(272, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 154;
            this.label3.Text = "Reset Time";
            // 
            // labeLQ
            // 
            this.labeLQ.AutoSize = true;
            this.labeLQ.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.labeLQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.labeLQ.Location = new System.Drawing.Point(272, 19);
            this.labeLQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeLQ.Name = "labeLQ";
            this.labeLQ.Size = new System.Drawing.Size(116, 23);
            this.labeLQ.TabIndex = 153;
            this.labeLQ.Text = "Current Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 32);
            this.label1.TabIndex = 157;
            this.label1.Text = "Salary report";
            // 
            // Print_Salary_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelEndTime);
            this.Controls.Add(this.labelStartTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labeLQ);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonToText);
            this.Controls.Add(this.buttonToPrinter);
            this.Controls.Add(this.dataGridViewCourses);
            this.Name = "Print_Salary_Report";
            this.Text = "Print_Salary_Report";
            this.Load += new System.EventHandler(this.Print_Salary_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonToPrinter;
        private System.Windows.Forms.Button buttonToText;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label labelEndTime;
        public System.Windows.Forms.Label labelStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labeLQ;
        private System.Windows.Forms.Label label1;
    }
}