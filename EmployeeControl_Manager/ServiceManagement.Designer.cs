namespace Final_Project_2022.EmployeeControl_Manager
{
    partial class ServiceManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceManagement));
            this.btnketthuc = new System.Windows.Forms.Button();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btncapnhat = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btncuoi = new System.Windows.Forms.Button();
            this.btndau = new System.Windows.Forms.Button();
            this.btnxuong = new System.Windows.Forms.Button();
            this.btnlen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxUnitName = new System.Windows.Forms.TextBox();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.GridViewServicesList = new System.Windows.Forms.DataGridView();
            this.labelServiceNameError = new System.Windows.Forms.Label();
            this.labelServiceUnitNameError = new System.Windows.Forms.Label();
            this.labelServicePriceError = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewServicesList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnketthuc
            // 
            this.btnketthuc.BackColor = System.Drawing.Color.Red;
            this.btnketthuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnketthuc.FlatAppearance.BorderSize = 0;
            this.btnketthuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnketthuc.ForeColor = System.Drawing.Color.White;
            this.btnketthuc.Location = new System.Drawing.Point(799, 398);
            this.btnketthuc.Margin = new System.Windows.Forms.Padding(4);
            this.btnketthuc.Name = "btnketthuc";
            this.btnketthuc.Size = new System.Drawing.Size(175, 54);
            this.btnketthuc.TabIndex = 158;
            this.btnketthuc.Text = "EXIT";
            this.btnketthuc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnketthuc.UseVisualStyleBackColor = false;
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.BackColor = System.Drawing.Color.GhostWhite;
            this.buttonRefreshList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefreshList.BackgroundImage")));
            this.buttonRefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRefreshList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshList.Location = new System.Drawing.Point(407, 299);
            this.buttonRefreshList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(176, 47);
            this.buttonRefreshList.TabIndex = 157;
            this.buttonRefreshList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefreshList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRefreshList.UseVisualStyleBackColor = false;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btnthem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnthem.FlatAppearance.BorderSize = 0;
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.ForeColor = System.Drawing.Color.Linen;
            this.btnthem.Location = new System.Drawing.Point(405, 57);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(181, 47);
            this.btnthem.TabIndex = 156;
            this.btnthem.Text = "ADD NEW";
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btncapnhat
            // 
            this.btncapnhat.BackColor = System.Drawing.Color.Turquoise;
            this.btncapnhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncapnhat.FlatAppearance.BorderSize = 0;
            this.btncapnhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncapnhat.ForeColor = System.Drawing.Color.Black;
            this.btncapnhat.Location = new System.Drawing.Point(405, 212);
            this.btncapnhat.Margin = new System.Windows.Forms.Padding(4);
            this.btncapnhat.Name = "btncapnhat";
            this.btncapnhat.Size = new System.Drawing.Size(181, 47);
            this.btncapnhat.TabIndex = 155;
            this.btncapnhat.Text = "UPDATE INFORMATION";
            this.btncapnhat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btncapnhat.UseVisualStyleBackColor = false;
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.Red;
            this.btnxoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxoa.FlatAppearance.BorderSize = 0;
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.ForeColor = System.Drawing.Color.White;
            this.btnxoa.Location = new System.Drawing.Point(405, 134);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(180, 47);
            this.btnxoa.TabIndex = 154;
            this.btnxoa.Text = "DELETE";
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btncuoi
            // 
            this.btncuoi.Location = new System.Drawing.Point(695, 398);
            this.btncuoi.Margin = new System.Windows.Forms.Padding(4);
            this.btncuoi.Name = "btncuoi";
            this.btncuoi.Size = new System.Drawing.Size(72, 54);
            this.btncuoi.TabIndex = 153;
            this.btncuoi.Text = "Last";
            this.btncuoi.UseVisualStyleBackColor = true;
            // 
            // btndau
            // 
            this.btndau.Location = new System.Drawing.Point(615, 399);
            this.btndau.Margin = new System.Windows.Forms.Padding(4);
            this.btndau.Name = "btndau";
            this.btndau.Size = new System.Drawing.Size(72, 54);
            this.btndau.TabIndex = 152;
            this.btndau.Text = "First";
            this.btndau.UseVisualStyleBackColor = true;
            // 
            // btnxuong
            // 
            this.btnxuong.Location = new System.Drawing.Point(487, 398);
            this.btnxuong.Margin = new System.Windows.Forms.Padding(4);
            this.btnxuong.Name = "btnxuong";
            this.btnxuong.Size = new System.Drawing.Size(96, 54);
            this.btnxuong.TabIndex = 151;
            this.btnxuong.Text = "Previous";
            this.btnxuong.UseVisualStyleBackColor = true;
            // 
            // btnlen
            // 
            this.btnlen.Location = new System.Drawing.Point(407, 398);
            this.btnlen.Margin = new System.Windows.Forms.Padding(4);
            this.btnlen.Name = "btnlen";
            this.btnlen.Size = new System.Drawing.Size(72, 54);
            this.btnlen.TabIndex = 150;
            this.btnlen.Text = "Next";
            this.btnlen.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelServicePriceError);
            this.panel1.Controls.Add(this.labelServiceUnitNameError);
            this.panel1.Controls.Add(this.labelServiceNameError);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.textBoxUnitName);
            this.panel1.Controls.Add(this.textBoxServiceName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(615, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 296);
            this.panel1.TabIndex = 149;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(121, 186);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(313, 22);
            this.textBoxPrice.TabIndex = 5;
            // 
            // textBoxUnitName
            // 
            this.textBoxUnitName.Location = new System.Drawing.Point(121, 108);
            this.textBoxUnitName.Name = "textBoxUnitName";
            this.textBoxUnitName.Size = new System.Drawing.Size(313, 22);
            this.textBoxUnitName.TabIndex = 4;
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(121, 31);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(313, 22);
            this.textBoxServiceName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unit Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name of Service:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(12, 19);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(120, 16);
            this.labelTotal.TabIndex = 159;
            this.labelTotal.Text = "number of services";
            // 
            // GridViewServicesList
            // 
            this.GridViewServicesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewServicesList.Location = new System.Drawing.Point(15, 50);
            this.GridViewServicesList.Name = "GridViewServicesList";
            this.GridViewServicesList.RowHeadersWidth = 51;
            this.GridViewServicesList.RowTemplate.Height = 24;
            this.GridViewServicesList.Size = new System.Drawing.Size(335, 402);
            this.GridViewServicesList.TabIndex = 160;
            this.GridViewServicesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridViewServicesList_CellContentClick);
            // 
            // labelServiceNameError
            // 
            this.labelServiceNameError.AutoSize = true;
            this.labelServiceNameError.ForeColor = System.Drawing.Color.Red;
            this.labelServiceNameError.Location = new System.Drawing.Point(121, 60);
            this.labelServiceNameError.Name = "labelServiceNameError";
            this.labelServiceNameError.Size = new System.Drawing.Size(119, 16);
            this.labelServiceNameError.TabIndex = 6;
            this.labelServiceNameError.Text = "ServiceNameError";
            // 
            // labelServiceUnitNameError
            // 
            this.labelServiceUnitNameError.AutoSize = true;
            this.labelServiceUnitNameError.ForeColor = System.Drawing.Color.Red;
            this.labelServiceUnitNameError.Location = new System.Drawing.Point(121, 133);
            this.labelServiceUnitNameError.Name = "labelServiceUnitNameError";
            this.labelServiceUnitNameError.Size = new System.Drawing.Size(142, 16);
            this.labelServiceUnitNameError.TabIndex = 7;
            this.labelServiceUnitNameError.Text = "ServiceUnitNameError";
            // 
            // labelServicePriceError
            // 
            this.labelServicePriceError.AutoSize = true;
            this.labelServicePriceError.ForeColor = System.Drawing.Color.Red;
            this.labelServicePriceError.Location = new System.Drawing.Point(121, 211);
            this.labelServicePriceError.Name = "labelServicePriceError";
            this.labelServicePriceError.Size = new System.Drawing.Size(113, 16);
            this.labelServicePriceError.TabIndex = 8;
            this.labelServicePriceError.Text = "ServicePriceError";
            // 
            // ServiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 466);
            this.Controls.Add(this.GridViewServicesList);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.btnketthuc);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btncapnhat);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btncuoi);
            this.Controls.Add(this.btndau);
            this.Controls.Add(this.btnxuong);
            this.Controls.Add(this.btnlen);
            this.Controls.Add(this.panel1);
            this.Name = "ServiceManagement";
            this.Text = "ServiceManagement";
            this.Load += new System.EventHandler(this.ServiceManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewServicesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnketthuc;
        private System.Windows.Forms.Button buttonRefreshList;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btncapnhat;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btncuoi;
        private System.Windows.Forms.Button btndau;
        private System.Windows.Forms.Button btnxuong;
        private System.Windows.Forms.Button btnlen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxServiceName;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxUnitName;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridView GridViewServicesList;
        private System.Windows.Forms.Label labelServicePriceError;
        private System.Windows.Forms.Label labelServiceUnitNameError;
        private System.Windows.Forms.Label labelServiceNameError;
    }
}