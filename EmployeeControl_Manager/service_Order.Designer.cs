namespace Final_Project_2022.EmployeeControl_Manager
{
    partial class service_Order
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
            this.dataGridViewServiceList = new System.Windows.Forms.DataGridView();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.textBoxServicePrice = new System.Windows.Forms.TextBox();
            this.textBoxResqNum = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEXIT = new System.Windows.Forms.Button();
            this.buttonSAVE = new System.Windows.Forms.Button();
            this.comboBoxRoomID = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewServiceList
            // 
            this.dataGridViewServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServiceList.Location = new System.Drawing.Point(13, 89);
            this.dataGridViewServiceList.Name = "dataGridViewServiceList";
            this.dataGridViewServiceList.RowHeadersWidth = 51;
            this.dataGridViewServiceList.RowTemplate.Height = 24;
            this.dataGridViewServiceList.Size = new System.Drawing.Size(445, 403);
            this.dataGridViewServiceList.TabIndex = 0;
            this.dataGridViewServiceList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServiceList_CellContentClick);
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(180, 75);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(259, 22);
            this.textBoxServiceName.TabIndex = 4;
            // 
            // textBoxServicePrice
            // 
            this.textBoxServicePrice.Location = new System.Drawing.Point(180, 137);
            this.textBoxServicePrice.Name = "textBoxServicePrice";
            this.textBoxServicePrice.Size = new System.Drawing.Size(259, 22);
            this.textBoxServicePrice.TabIndex = 5;
            // 
            // textBoxResqNum
            // 
            this.textBoxResqNum.Location = new System.Drawing.Point(259, 267);
            this.textBoxResqNum.Name = "textBoxResqNum";
            this.textBoxResqNum.Size = new System.Drawing.Size(180, 22);
            this.textBoxResqNum.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEXIT);
            this.panel1.Controls.Add(this.buttonSAVE);
            this.panel1.Controls.Add(this.comboBoxRoomID);
            this.panel1.Controls.Add(this.dateTimePicker);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxResqNum);
            this.panel1.Controls.Add(this.textBoxServiceName);
            this.panel1.Controls.Add(this.textBoxServicePrice);
            this.panel1.Location = new System.Drawing.Point(489, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 403);
            this.panel1.TabIndex = 7;
            // 
            // buttonEXIT
            // 
            this.buttonEXIT.BackColor = System.Drawing.Color.Red;
            this.buttonEXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEXIT.FlatAppearance.BorderSize = 0;
            this.buttonEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEXIT.ForeColor = System.Drawing.Color.White;
            this.buttonEXIT.Location = new System.Drawing.Point(259, 338);
            this.buttonEXIT.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEXIT.Name = "buttonEXIT";
            this.buttonEXIT.Size = new System.Drawing.Size(180, 47);
            this.buttonEXIT.TabIndex = 142;
            this.buttonEXIT.Text = "EXIT";
            this.buttonEXIT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonEXIT.UseVisualStyleBackColor = false;
            // 
            // buttonSAVE
            // 
            this.buttonSAVE.BackColor = System.Drawing.Color.Turquoise;
            this.buttonSAVE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSAVE.FlatAppearance.BorderSize = 0;
            this.buttonSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSAVE.ForeColor = System.Drawing.Color.Black;
            this.buttonSAVE.Location = new System.Drawing.Point(23, 338);
            this.buttonSAVE.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSAVE.Name = "buttonSAVE";
            this.buttonSAVE.Size = new System.Drawing.Size(215, 47);
            this.buttonSAVE.TabIndex = 141;
            this.buttonSAVE.Text = "SAVE";
            this.buttonSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSAVE.UseVisualStyleBackColor = false;
            this.buttonSAVE.Click += new System.EventHandler(this.buttonSAVE_Click);
            // 
            // comboBoxRoomID
            // 
            this.comboBoxRoomID.FormattingEnabled = true;
            this.comboBoxRoomID.Location = new System.Drawing.Point(180, 14);
            this.comboBoxRoomID.Name = "comboBoxRoomID";
            this.comboBoxRoomID.Size = new System.Drawing.Size(259, 24);
            this.comboBoxRoomID.TabIndex = 120;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(180, 200);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(259, 22);
            this.dateTimePicker.TabIndex = 119;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label6.Location = new System.Drawing.Point(14, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 118;
            this.label6.Text = "Room ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label5.Location = new System.Drawing.Point(14, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 117;
            this.label5.Text = "Service Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label4.Location = new System.Drawing.Point(14, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 116;
            this.label4.Text = "Service Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label3.Location = new System.Drawing.Point(14, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 115;
            this.label3.Text = "Order Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.label2.Location = new System.Drawing.Point(14, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 114;
            this.label2.Text = "Number of Request:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 36);
            this.label7.TabIndex = 8;
            this.label7.Text = "Service Order";
            // 
            // service_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 514);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewServiceList);
            this.Name = "service_Order";
            this.Text = "service_Order";
            this.Load += new System.EventHandler(this.service_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServiceList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewServiceList;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.TextBox textBoxServicePrice;
        private System.Windows.Forms.TextBox textBoxResqNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxRoomID;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSAVE;
        private System.Windows.Forms.Button buttonEXIT;
        private System.Windows.Forms.Label label7;
    }
}