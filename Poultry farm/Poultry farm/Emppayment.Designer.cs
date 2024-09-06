namespace Poultry_farm
{
    partial class Emppayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblnetpay = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbpaymode = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtdeduction = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtadvance = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblpaydate = new System.Windows.Forms.Label();
            this.txttdate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdetails = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnget = new System.Windows.Forms.Button();
            this.txtfdate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnetpay
            // 
            this.lblnetpay.AutoSize = true;
            this.lblnetpay.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnetpay.ForeColor = System.Drawing.Color.Maroon;
            this.lblnetpay.Location = new System.Drawing.Point(646, 100);
            this.lblnetpay.Name = "lblnetpay";
            this.lblnetpay.Size = new System.Drawing.Size(87, 26);
            this.lblnetpay.TabIndex = 27;
            this.lblnetpay.Text = "Net Pay";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Gold;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(68, 666);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(96, 33);
            this.btndelete.TabIndex = 26;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.Gold;
            this.btnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Location = new System.Drawing.Point(629, 430);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(72, 33);
            this.btnshow.TabIndex = 25;
            this.btnshow.Text = "Show All";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.EnableHeadersVisualStyles = false;
            this.dg.Location = new System.Drawing.Point(12, 469);
            this.dg.Name = "dg";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg.Size = new System.Drawing.Size(754, 191);
            this.dg.TabIndex = 24;
            this.dg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dg_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cmbpaymode);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtdeduction);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtadvance);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtsalary);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtdays);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblpaydate);
            this.groupBox1.Controls.Add(this.txttdate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtdetails);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.btnget);
            this.groupBox1.Controls.Add(this.txtfdate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 295);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Payment Entry";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Gold;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(173, 243);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 33);
            this.btnclose.TabIndex = 28;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(586, 190);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "(if any)";
            // 
            // cmbpaymode
            // 
            this.cmbpaymode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbpaymode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbpaymode.FormattingEnabled = true;
            this.cmbpaymode.Items.AddRange(new object[] {
            "Cash",
            "Cheque",
            "Online"});
            this.cmbpaymode.Location = new System.Drawing.Point(128, 194);
            this.cmbpaymode.Name = "cmbpaymode";
            this.cmbpaymode.Size = new System.Drawing.Size(116, 28);
            this.cmbpaymode.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 24);
            this.label15.TabIndex = 19;
            this.label15.Text = "Pay Mode";
            // 
            // txtdeduction
            // 
            this.txtdeduction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdeduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeduction.Location = new System.Drawing.Point(562, 162);
            this.txtdeduction.Name = "txtdeduction";
            this.txtdeduction.Size = new System.Drawing.Size(116, 27);
            this.txtdeduction.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(463, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 24);
            this.label13.TabIndex = 17;
            this.label13.Text = "Deduction";
            // 
            // txtadvance
            // 
            this.txtadvance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadvance.Location = new System.Drawing.Point(341, 163);
            this.txtadvance.Name = "txtadvance";
            this.txtadvance.Size = new System.Drawing.Size(116, 27);
            this.txtadvance.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(250, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "Advance";
            // 
            // txtsalary
            // 
            this.txtsalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary.Location = new System.Drawing.Point(140, 96);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(168, 27);
            this.txtsalary.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(9, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "Monthly Salary";
            // 
            // txtdays
            // 
            this.txtdays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdays.Location = new System.Drawing.Point(128, 163);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(116, 27);
            this.txtdays.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Present Days";
            // 
            // lblpaydate
            // 
            this.lblpaydate.AutoSize = true;
            this.lblpaydate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaydate.Location = new System.Drawing.Point(463, 34);
            this.lblpaydate.Name = "lblpaydate";
            this.lblpaydate.Size = new System.Drawing.Size(86, 24);
            this.lblpaydate.TabIndex = 26;
            this.lblpaydate.Text = "Pay Date";
            // 
            // txttdate
            // 
            this.txttdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttdate.Location = new System.Drawing.Point(491, 126);
            this.txttdate.Name = "txttdate";
            this.txttdate.Size = new System.Drawing.Size(239, 27);
            this.txttdate.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(389, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "To Date";
            // 
            // txtdetails
            // 
            this.txtdetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdetails.Location = new System.Drawing.Point(331, 196);
            this.txtdetails.Multiline = true;
            this.txtdetails.Name = "txtdetails";
            this.txtdetails.Size = new System.Drawing.Size(228, 59);
            this.txtdetails.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(390, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Pay Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(260, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Details";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Gold;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(86, 243);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(72, 33);
            this.btnclear.TabIndex = 24;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Gold;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(13, 243);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(67, 33);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Pay";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnget
            // 
            this.btnget.BackColor = System.Drawing.Color.Orange;
            this.btnget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnget.Location = new System.Drawing.Point(301, 28);
            this.btnget.Name = "btnget";
            this.btnget.Size = new System.Drawing.Size(72, 30);
            this.btnget.TabIndex = 2;
            this.btnget.Text = "Get";
            this.btnget.UseVisualStyleBackColor = false;
            this.btnget.Click += new System.EventHandler(this.btnget_Click);
            // 
            // txtfdate
            // 
            this.txtfdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfdate.Location = new System.Drawing.Point(110, 126);
            this.txtfdate.Name = "txtfdate";
            this.txtfdate.Size = new System.Drawing.Size(263, 27);
            this.txtfdate.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "From Date";
            // 
            // txtname
            // 
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(140, 66);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(263, 27);
            this.txtname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Emp Name";
            // 
            // txtno
            // 
            this.txtno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtno.Location = new System.Drawing.Point(140, 31);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(89, 27);
            this.txtno.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emp No";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(537, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 26);
            this.label14.TabIndex = 23;
            this.label14.Text = "Net Pay";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 78);
            this.panel1.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(166, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(491, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employee Payment Form";
            // 
            // Emppayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblnetpay);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Name = "Emppayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emppayment";
            this.Load += new System.EventHandler(this.Emppayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnetpay;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbpaymode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtdeduction;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtadvance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblpaydate;
        private System.Windows.Forms.DateTimePicker txttdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnget;
        private System.Windows.Forms.DateTimePicker txtfdate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnclose;
    }
}