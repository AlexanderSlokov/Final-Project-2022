namespace Final_Project_2022.EmployeeControl_Manager
{
    partial class Salary_Calc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary_Calc));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxStartTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCheckIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxLateCheckIN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxMinusCheckIN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMinusCheckOUT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxSoonCheckOUT = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxCheckOut = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxEndTIme = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxHourSum = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.buttonUpdateInformation = new System.Windows.Forms.Button();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonRefreshList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(516, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(695, 482);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(40, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 125;
            this.label7.Text = "Start Time";
            // 
            // textBoxStartTime
            // 
            this.textBoxStartTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxStartTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStartTime.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxStartTime.Location = new System.Drawing.Point(205, 102);
            this.textBoxStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStartTime.Multiline = true;
            this.textBoxStartTime.Name = "textBoxStartTime";
            this.textBoxStartTime.Size = new System.Drawing.Size(230, 34);
            this.textBoxStartTime.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(169, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 23);
            this.label1.TabIndex = 127;
            this.label1.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxID.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxID.Location = new System.Drawing.Point(205, 10);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(230, 38);
            this.textBoxID.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(38, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 129;
            this.label2.Text = "Check IN Time";
            // 
            // textBoxCheckIN
            // 
            this.textBoxCheckIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxCheckIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCheckIN.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxCheckIN.Location = new System.Drawing.Point(205, 160);
            this.textBoxCheckIN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCheckIN.Multiline = true;
            this.textBoxCheckIN.Name = "textBoxCheckIN";
            this.textBoxCheckIN.Size = new System.Drawing.Size(230, 34);
            this.textBoxCheckIN.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 130;
            this.label3.Text = "CALCULATOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 23);
            this.label4.TabIndex = 131;
            this.label4.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(15, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(458, 23);
            this.label5.TabIndex = 132;
            this.label5.Text = "________________________________________________________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(45, 233);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 23);
            this.label6.TabIndex = 134;
            this.label6.Text = "Late HOUR(s):";
            // 
            // textBoxLateCheckIN
            // 
            this.textBoxLateCheckIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxLateCheckIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLateCheckIN.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxLateCheckIN.Location = new System.Drawing.Point(205, 229);
            this.textBoxLateCheckIN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLateCheckIN.Multiline = true;
            this.textBoxLateCheckIN.Name = "textBoxLateCheckIN";
            this.textBoxLateCheckIN.Size = new System.Drawing.Size(230, 34);
            this.textBoxLateCheckIN.TabIndex = 133;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(15, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(458, 23);
            this.label8.TabIndex = 135;
            this.label8.Text = "________________________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(45, 294);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 23);
            this.label9.TabIndex = 137;
            this.label9.Text = "Minus:";
            // 
            // textBoxMinusCheckIN
            // 
            this.textBoxMinusCheckIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxMinusCheckIN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMinusCheckIN.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxMinusCheckIN.Location = new System.Drawing.Point(205, 283);
            this.textBoxMinusCheckIN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMinusCheckIN.Multiline = true;
            this.textBoxMinusCheckIN.Name = "textBoxMinusCheckIN";
            this.textBoxMinusCheckIN.Size = new System.Drawing.Size(230, 34);
            this.textBoxMinusCheckIN.TabIndex = 136;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(15, 341);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(434, 23);
            this.label10.TabIndex = 138;
            this.label10.Text = "*****************************************************";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(45, 571);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 23);
            this.label11.TabIndex = 148;
            this.label11.Text = "Minus:";
            // 
            // textBoxMinusCheckOUT
            // 
            this.textBoxMinusCheckOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxMinusCheckOUT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMinusCheckOUT.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxMinusCheckOUT.Location = new System.Drawing.Point(205, 567);
            this.textBoxMinusCheckOUT.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMinusCheckOUT.Multiline = true;
            this.textBoxMinusCheckOUT.Name = "textBoxMinusCheckOUT";
            this.textBoxMinusCheckOUT.Size = new System.Drawing.Size(230, 34);
            this.textBoxMinusCheckOUT.TabIndex = 147;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(15, 540);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(458, 23);
            this.label12.TabIndex = 146;
            this.label12.Text = "________________________________________________________________";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(45, 517);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 23);
            this.label13.TabIndex = 145;
            this.label13.Text = "Soon HOUR(s):";
            // 
            // textBoxSoonCheckOUT
            // 
            this.textBoxSoonCheckOUT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxSoonCheckOUT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSoonCheckOUT.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxSoonCheckOUT.Location = new System.Drawing.Point(205, 513);
            this.textBoxSoonCheckOUT.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSoonCheckOUT.Multiline = true;
            this.textBoxSoonCheckOUT.Name = "textBoxSoonCheckOUT";
            this.textBoxSoonCheckOUT.Size = new System.Drawing.Size(230, 34);
            this.textBoxSoonCheckOUT.TabIndex = 144;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(15, 475);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(458, 23);
            this.label14.TabIndex = 143;
            this.label14.Text = "________________________________________________________________";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(38, 444);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 23);
            this.label15.TabIndex = 142;
            this.label15.Text = "Check Out Time";
            // 
            // textBoxCheckOut
            // 
            this.textBoxCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCheckOut.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxCheckOut.Location = new System.Drawing.Point(205, 444);
            this.textBoxCheckOut.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCheckOut.Multiline = true;
            this.textBoxCheckOut.Name = "textBoxCheckOut";
            this.textBoxCheckOut.Size = new System.Drawing.Size(230, 34);
            this.textBoxCheckOut.TabIndex = 141;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(40, 395);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 23);
            this.label16.TabIndex = 140;
            this.label16.Text = "End Time";
            // 
            // textBoxEndTIme
            // 
            this.textBoxEndTIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxEndTIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxEndTIme.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxEndTIme.Location = new System.Drawing.Point(205, 386);
            this.textBoxEndTIme.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEndTIme.Multiline = true;
            this.textBoxEndTIme.Name = "textBoxEndTIme";
            this.textBoxEndTIme.Size = new System.Drawing.Size(230, 34);
            this.textBoxEndTIme.TabIndex = 139;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(512, 522);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 23);
            this.label17.TabIndex = 150;
            this.label17.Text = "Working Hour(s)";
            // 
            // textBoxHourSum
            // 
            this.textBoxHourSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxHourSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHourSum.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxHourSum.Location = new System.Drawing.Point(664, 513);
            this.textBoxHourSum.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHourSum.Multiline = true;
            this.textBoxHourSum.Name = "textBoxHourSum";
            this.textBoxHourSum.Size = new System.Drawing.Size(230, 34);
            this.textBoxHourSum.TabIndex = 149;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(907, 522);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 23);
            this.label18.TabIndex = 152;
            this.label18.Text = "Salary:";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSalary.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxSalary.Location = new System.Drawing.Point(980, 513);
            this.textBoxSalary.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSalary.Multiline = true;
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(230, 34);
            this.textBoxSalary.TabIndex = 151;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(591, 576);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 23);
            this.label19.TabIndex = 154;
            this.label19.Text = "Total:";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.textBoxTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotal.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.textBoxTotal.Location = new System.Drawing.Point(664, 567);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTotal.Multiline = true;
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(230, 34);
            this.textBoxTotal.TabIndex = 153;
            // 
            // buttonUpdateInformation
            // 
            this.buttonUpdateInformation.BackColor = System.Drawing.Color.Turquoise;
            this.buttonUpdateInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateInformation.FlatAppearance.BorderSize = 0;
            this.buttonUpdateInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateInformation.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdateInformation.Location = new System.Drawing.Point(664, 618);
            this.buttonUpdateInformation.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdateInformation.Name = "buttonUpdateInformation";
            this.buttonUpdateInformation.Size = new System.Drawing.Size(230, 47);
            this.buttonUpdateInformation.TabIndex = 155;
            this.buttonUpdateInformation.Text = "CONFIRM INFORMATION";
            this.buttonUpdateInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUpdateInformation.UseVisualStyleBackColor = false;
            this.buttonUpdateInformation.Click += new System.EventHandler(this.buttonUpdateInformation_Click);
            // 
            // buttonCalc
            // 
            this.buttonCalc.AllowDrop = true;
            this.buttonCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.buttonCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalc.FlatAppearance.BorderSize = 0;
            this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonCalc.ForeColor = System.Drawing.Color.White;
            this.buttonCalc.Location = new System.Drawing.Point(980, 621);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(230, 44);
            this.buttonCalc.TabIndex = 156;
            this.buttonCalc.Text = "CALC";
            this.buttonCalc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // buttonRefreshList
            // 
            this.buttonRefreshList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRefreshList.BackgroundImage")));
            this.buttonRefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRefreshList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefreshList.Location = new System.Drawing.Point(980, 566);
            this.buttonRefreshList.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefreshList.Name = "buttonRefreshList";
            this.buttonRefreshList.Size = new System.Drawing.Size(230, 47);
            this.buttonRefreshList.TabIndex = 157;
            this.buttonRefreshList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefreshList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRefreshList.UseVisualStyleBackColor = true;
            this.buttonRefreshList.Click += new System.EventHandler(this.buttonRefreshList_Click);
            // 
            // Salary_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 682);
            this.Controls.Add(this.buttonRefreshList);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.buttonUpdateInformation);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxHourSum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxMinusCheckOUT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxSoonCheckOUT);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBoxCheckOut);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxEndTIme);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxMinusCheckIN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLateCheckIN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCheckIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxStartTime);
            this.Controls.Add(this.dataGridView);
            this.Name = "Salary_Calc";
            this.Text = "Salary_Calc";
            this.Load += new System.EventHandler(this.Salary_Calc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxStartTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCheckIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxLateCheckIN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxMinusCheckIN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxMinusCheckOUT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxSoonCheckOUT;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxCheckOut;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxEndTIme;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxHourSum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Button buttonUpdateInformation;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonRefreshList;
    }
}