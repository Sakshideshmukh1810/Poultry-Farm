namespace Poultry_farm
{
    partial class Productbilling
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncust = new System.Windows.Forms.Button();
            this.txtdiscamt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnet = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtcustno = new System.Windows.Forms.TextBox();
            this.txtdiscp = new System.Windows.Forms.TextBox();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.txtfdate = new System.Windows.Forms.DateTimePicker();
            this.txtno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnpet = new System.Windows.Forms.Button();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtpname = new System.Windows.Forms.TextBox();
            this.txtptno = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lv1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dg = new System.Windows.Forms.DataGridView();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbfield = new System.Windows.Forms.ComboBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnremove = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 70);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product billing";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncust);
            this.groupBox1.Controls.Add(this.txtdiscamt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtnet);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.txtcustno);
            this.groupBox1.Controls.Add(this.txtdiscp);
            this.groupBox1.Controls.Add(this.txtamt);
            this.groupBox1.Controls.Add(this.txtfdate);
            this.groupBox1.Controls.Add(this.txtno);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 221);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bill Detail";
            // 
            // btncust
            // 
            this.btncust.BackColor = System.Drawing.Color.Orange;
            this.btncust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncust.Location = new System.Drawing.Point(415, 29);
            this.btncust.Name = "btncust";
            this.btncust.Size = new System.Drawing.Size(75, 32);
            this.btncust.TabIndex = 16;
            this.btncust.Text = "Get";
            this.btncust.UseVisualStyleBackColor = false;
            this.btncust.Click += new System.EventHandler(this.btncust_Click);
            // 
            // txtdiscamt
            // 
            this.txtdiscamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscamt.Location = new System.Drawing.Point(413, 133);
            this.txtdiscamt.Name = "txtdiscamt";
            this.txtdiscamt.Size = new System.Drawing.Size(100, 27);
            this.txtdiscamt.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(313, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Disc Amt :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtnet
            // 
            this.txtnet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnet.Location = new System.Drawing.Point(413, 176);
            this.txtnet.Name = "txtnet";
            this.txtnet.Size = new System.Drawing.Size(100, 27);
            this.txtnet.TabIndex = 13;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(415, 96);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 27);
            this.txtname.TabIndex = 12;
            // 
            // txtcustno
            // 
            this.txtcustno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustno.Location = new System.Drawing.Point(303, 25);
            this.txtcustno.Name = "txtcustno";
            this.txtcustno.Size = new System.Drawing.Size(100, 27);
            this.txtcustno.TabIndex = 11;
            // 
            // txtdiscp
            // 
            this.txtdiscp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscp.Location = new System.Drawing.Point(109, 176);
            this.txtdiscp.Name = "txtdiscp";
            this.txtdiscp.Size = new System.Drawing.Size(100, 27);
            this.txtdiscp.TabIndex = 10;
            this.txtdiscp.TextChanged += new System.EventHandler(this.txtdiscp_TextChanged);
            // 
            // txtamt
            // 
            this.txtamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamt.Location = new System.Drawing.Point(109, 130);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(100, 27);
            this.txtamt.TabIndex = 9;
            // 
            // txtfdate
            // 
            this.txtfdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfdate.Location = new System.Drawing.Point(107, 71);
            this.txtfdate.Name = "txtfdate";
            this.txtfdate.Size = new System.Drawing.Size(200, 27);
            this.txtfdate.TabIndex = 8;
            this.txtfdate.ValueChanged += new System.EventHandler(this.txtfdate_ValueChanged);
            // 
            // txtno
            // 
            this.txtno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtno.Location = new System.Drawing.Point(107, 25);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 27);
            this.txtno.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(321, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Net Amt :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cust Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(214, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Cust No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dis%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Bill Amt :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "BillDate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "BillNo :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnadd);
            this.groupBox2.Controls.Add(this.btnpet);
            this.groupBox2.Controls.Add(this.txtqty);
            this.groupBox2.Controls.Add(this.txtprice);
            this.groupBox2.Controls.Add(this.txtpname);
            this.groupBox2.Controls.Add(this.txtptno);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(524, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Bill Form";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.Orange;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(390, 87);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 29);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnpet
            // 
            this.btnpet.BackColor = System.Drawing.Color.Orange;
            this.btnpet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpet.Location = new System.Drawing.Point(16, 87);
            this.btnpet.Name = "btnpet";
            this.btnpet.Size = new System.Drawing.Size(75, 29);
            this.btnpet.TabIndex = 8;
            this.btnpet.Text = "Get";
            this.btnpet.UseVisualStyleBackColor = false;
            this.btnpet.Click += new System.EventHandler(this.btnpet_Click);
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(377, 54);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(100, 27);
            this.txtqty.TabIndex = 7;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(252, 54);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(100, 27);
            this.txtprice.TabIndex = 6;
            // 
            // txtpname
            // 
            this.txtpname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpname.Location = new System.Drawing.Point(129, 54);
            this.txtpname.Name = "txtpname";
            this.txtpname.Size = new System.Drawing.Size(100, 27);
            this.txtpname.TabIndex = 5;
            // 
            // txtptno
            // 
            this.txtptno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtptno.Location = new System.Drawing.Point(6, 54);
            this.txtptno.Name = "txtptno";
            this.txtptno.Size = new System.Drawing.Size(100, 27);
            this.txtptno.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(409, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 24);
            this.label13.TabIndex = 3;
            this.label13.Text = "Qty";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(282, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 24);
            this.label12.TabIndex = 2;
            this.label12.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(120, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Product Name ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Product No";
            // 
            // lv1
            // 
            this.lv1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lv1.Location = new System.Drawing.Point(12, 473);
            this.lv1.Name = "lv1";
            this.lv1.Size = new System.Drawing.Size(524, 202);
            this.lv1.TabIndex = 3;
            this.lv1.UseCompatibleStateImageBehavior = false;
            this.lv1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ProductNo";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ProductName";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qty";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total";
            this.columnHeader5.Width = 124;
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillNo,
            this.BillDate,
            this.CustNo,
            this.CustName,
            this.BillAmt,
            this.DiscountP,
            this.Discount,
            this.NetAmt});
            this.dg.Location = new System.Drawing.Point(570, 174);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.RowTemplate.Height = 24;
            this.dg.Size = new System.Drawing.Size(351, 491);
            this.dg.TabIndex = 4;
            this.dg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dg_MouseClick);
            // 
            // BillNo
            // 
            this.BillNo.DataPropertyName = "BillNo";
            this.BillNo.HeaderText = "BillNo";
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            // 
            // BillDate
            // 
            this.BillDate.DataPropertyName = "BillDate";
            this.BillDate.HeaderText = "BillDate";
            this.BillDate.Name = "BillDate";
            this.BillDate.ReadOnly = true;
            // 
            // CustNo
            // 
            this.CustNo.DataPropertyName = "CustNo";
            this.CustNo.HeaderText = "CustNo";
            this.CustNo.Name = "CustNo";
            this.CustNo.ReadOnly = true;
            // 
            // CustName
            // 
            this.CustName.DataPropertyName = "CustName";
            this.CustName.HeaderText = "CustName";
            this.CustName.Name = "CustName";
            this.CustName.ReadOnly = true;
            // 
            // BillAmt
            // 
            this.BillAmt.DataPropertyName = "BillAmt";
            this.BillAmt.HeaderText = "BillAmt";
            this.BillAmt.Name = "BillAmt";
            this.BillAmt.ReadOnly = true;
            // 
            // DiscountP
            // 
            this.DiscountP.DataPropertyName = "DiscountP";
            this.DiscountP.HeaderText = "DiscountP";
            this.DiscountP.Name = "DiscountP";
            this.DiscountP.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // NetAmt
            // 
            this.NetAmt.DataPropertyName = "NetAmt";
            this.NetAmt.HeaderText = "NetAmt";
            this.NetAmt.Name = "NetAmt";
            this.NetAmt.ReadOnly = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(570, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 24);
            this.label14.TabIndex = 5;
            this.label14.Text = "Search by:";
            // 
            // cmbfield
            // 
            this.cmbfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfield.FormattingEnabled = true;
            this.cmbfield.Items.AddRange(new object[] {
            "BillNo",
            "BillDate",
            "CustNo",
            "CustName"});
            this.cmbfield.Location = new System.Drawing.Point(676, 122);
            this.cmbfield.Name = "cmbfield";
            this.cmbfield.Size = new System.Drawing.Size(121, 28);
            this.cmbfield.TabIndex = 6;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(832, 122);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(100, 27);
            this.txtsearch.TabIndex = 7;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // btnremove
            // 
            this.btnremove.BackColor = System.Drawing.Color.Gold;
            this.btnremove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnremove.Location = new System.Drawing.Point(230, 681);
            this.btnremove.Name = "btnremove";
            this.btnremove.Size = new System.Drawing.Size(89, 40);
            this.btnremove.TabIndex = 8;
            this.btnremove.Text = "Remove";
            this.btnremove.UseVisualStyleBackColor = false;
            this.btnremove.Click += new System.EventHandler(this.btnremove_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Gold;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(402, 681);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 40);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Gold;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(535, 681);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 40);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Gold;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(685, 681);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(88, 40);
            this.btndelete.TabIndex = 11;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Gold;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(43, 681);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(75, 40);
            this.btnnew.TabIndex = 12;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // Productbilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 733);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnremove);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.cmbfield);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.lv1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Productbilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productbilling";
            this.Load += new System.EventHandler(this.Productbilling_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdiscamt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnet;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtcustno;
        private System.Windows.Forms.TextBox txtdiscp;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.DateTimePicker txtfdate;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtpname;
        private System.Windows.Forms.TextBox txtptno;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lv1;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbfield;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btncust;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnpet;
        private System.Windows.Forms.Button btnremove;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetAmt;
    }
}