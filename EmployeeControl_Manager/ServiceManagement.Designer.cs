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
            this.labelServiceIDError = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelInStockError = new System.Windows.Forms.Label();
            this.textBoxInStock = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.labelServicePriceError = new System.Windows.Forms.Label();
            this.labelServiceUnitNameError = new System.Windows.Forms.Label();
            this.labelServiceNameError = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxUnitName = new System.Windows.Forms.TextBox();
            this.textBoxServiceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.GridViewServicesList = new System.Windows.Forms.DataGridView();
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
            this.btnketthuc.Click += new System.EventHandler(this.btnketthuc_Click);
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
            this.btncapnhat.Click += new System.EventHandler(this.btncapnhat_Click);
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
            this.btncuoi.Click += new System.EventHandler(this.btncuoi_Click);
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
            this.btndau.Click += new System.EventHandler(this.btndau_Click);
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
            this.btnxuong.Click += new System.EventHandler(this.btnxuong_Click);
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
            this.btnlen.Click += new System.EventHandler(this.btnlen_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.labelServiceIDError);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelInStockError);
            this.panel1.Controls.Add(this.textBoxInStock);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.labelServicePriceError);
            this.panel1.Controls.Add(this.labelServiceUnitNameError);
            this.panel1.Controls.Add(this.labelServiceNameError);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.textBoxUnitName);
            this.panel1.Controls.Add(this.textBoxServiceName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(615, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 289);
            this.panel1.TabIndex = 149;
            // 
            // labelServiceIDError
            // 
            this.labelServiceIDError.AutoSize = true;
            this.labelServiceIDError.ForeColor = System.Drawing.Color.Red;
            this.labelServiceIDError.Location = new System.Drawing.Point(124, 50);
            this.labelServiceIDError.Name = "labelServiceIDError";
            this.labelServiceIDError.Size = new System.Drawing.Size(95, 16);
            this.labelServiceIDError.TabIndex = 167;
            this.labelServiceIDError.Text = "ServiceIDError";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(124, 25);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(313, 22);
            this.textBoxID.TabIndex = 166;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 165;
            this.label6.Text = "Service ID:";
            // 
            // labelInStockError
            // 
            this.labelInStockError.AutoSize = true;
            this.labelInStockError.ForeColor = System.Drawing.Color.Red;
            this.labelInStockError.Location = new System.Drawing.Point(124, 252);
            this.labelInStockError.Name = "labelInStockError";
            this.labelInStockError.Size = new System.Drawing.Size(126, 16);
            this.labelInStockError.TabIndex = 164;
            this.labelInStockError.Text = "ServiceInStockError";
            // 
            // textBoxInStock
            // 
            this.textBoxInStock.Location = new System.Drawing.Point(124, 227);
            this.textBoxInStock.Name = "textBoxInStock";
            this.textBoxInStock.Size = new System.Drawing.Size(313, 22);
            this.textBoxInStock.TabIndex = 163;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(7, 234);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(57, 16);
            this.label.TabIndex = 162;
            this.label.Text = "In Stock:";
            // 
            // labelServicePriceError
            // 
            this.labelServicePriceError.AutoSize = true;
            this.labelServicePriceError.ForeColor = System.Drawing.Color.Red;
            this.labelServicePriceError.Location = new System.Drawing.Point(124, 208);
            this.labelServicePriceError.Name = "labelServicePriceError";
            this.labelServicePriceError.Size = new System.Drawing.Size(113, 16);
            this.labelServicePriceError.TabIndex = 8;
            this.labelServicePriceError.Text = "ServicePriceError";
            // 
            // labelServiceUnitNameError
            // 
            this.labelServiceUnitNameError.AutoSize = true;
            this.labelServiceUnitNameError.ForeColor = System.Drawing.Color.Red;
            this.labelServiceUnitNameError.Location = new System.Drawing.Point(124, 155);
            this.labelServiceUnitNameError.Name = "labelServiceUnitNameError";
            this.labelServiceUnitNameError.Size = new System.Drawing.Size(142, 16);
            this.labelServiceUnitNameError.TabIndex = 7;
            this.labelServiceUnitNameError.Text = "ServiceUnitNameError";
            // 
            // labelServiceNameError
            // 
            this.labelServiceNameError.AutoSize = true;
            this.labelServiceNameError.ForeColor = System.Drawing.Color.Red;
            this.labelServiceNameError.Location = new System.Drawing.Point(124, 107);
            this.labelServiceNameError.Name = "labelServiceNameError";
            this.labelServiceNameError.Size = new System.Drawing.Size(119, 16);
            this.labelServiceNameError.TabIndex = 6;
            this.labelServiceNameError.Text = "ServiceNameError";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(124, 183);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(313, 22);
            this.textBoxPrice.TabIndex = 5;
            // 
            // textBoxUnitName
            // 
            this.textBoxUnitName.Location = new System.Drawing.Point(124, 130);
            this.textBoxUnitName.Name = "textBoxUnitName";
            this.textBoxUnitName.Size = new System.Drawing.Size(313, 22);
            this.textBoxUnitName.TabIndex = 4;
            // 
            // textBoxServiceName
            // 
            this.textBoxServiceName.Location = new System.Drawing.Point(124, 78);
            this.textBoxServiceName.Name = "textBoxServiceName";
            this.textBoxServiceName.Size = new System.Drawing.Size(313, 22);
            this.textBoxServiceName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unit Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 81);
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
        private System.Windows.Forms.Label labelServiceIDError;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelInStockError;
        private System.Windows.Forms.TextBox textBoxInStock;
        private System.Windows.Forms.Label label;
    }
}