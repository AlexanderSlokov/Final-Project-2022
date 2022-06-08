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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonToPrinter = new System.Windows.Forms.Button();
            this.buttonToText = new System.Windows.Forms.Button();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonToPrinter);
            this.panelButtons.Controls.Add(this.buttonToText);
            this.panelButtons.Location = new System.Drawing.Point(262, 361);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(267, 60);
            this.panelButtons.TabIndex = 6;
            // 
            // buttonToPrinter
            // 
            this.buttonToPrinter.BackColor = System.Drawing.Color.FloralWhite;
            this.buttonToPrinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonToPrinter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonToPrinter.Location = new System.Drawing.Point(132, -3);
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
            this.buttonToText.Location = new System.Drawing.Point(0, -3);
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
            this.dataGridViewCourses.Location = new System.Drawing.Point(113, 30);
            this.dataGridViewCourses.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 51;
            this.dataGridViewCourses.Size = new System.Drawing.Size(575, 317);
            this.dataGridViewCourses.TabIndex = 5;
            // 
            // Print_Salary_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.dataGridViewCourses);
            this.Name = "Print_Salary_Report";
            this.Text = "Print_Salary_Report";
            this.Load += new System.EventHandler(this.Print_Salary_Report_Load);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonToPrinter;
        private System.Windows.Forms.Button buttonToText;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
    }
}