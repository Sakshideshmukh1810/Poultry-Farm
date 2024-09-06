namespace Poultry_farm
{
    partial class Purchaseentry
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cid = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpchik = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.cmbcompany = new System.Windows.Forms.ComboBox();
            this.txtvno = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.txtpno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.purchasegridv = new System.Windows.Forms.DataGridView();
            this.Purchase_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bill_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehicle_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chick_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate_Per_Chick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasegridv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poultry Purchase Entry";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 80);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cid);
            this.panel2.Controls.Add(this.txtprice);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtbno);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtpchik);
            this.panel2.Controls.Add(this.txtqty);
            this.panel2.Controls.Add(this.cmbcompany);
            this.panel2.Controls.Add(this.txtvno);
            this.panel2.Controls.Add(this.txtdate);
            this.panel2.Controls.Add(this.txtpno);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 327);
            this.panel2.TabIndex = 2;
            // 
            // cid
            // 
            this.cid.AutoSize = true;
            this.cid.Location = new System.Drawing.Point(410, 184);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(17, 20);
            this.cid.TabIndex = 16;
            this.cid.Text = "1";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(463, 230);
            this.txtprice.Name = "txtprice";
            this.txtprice.ReadOnly = true;
            this.txtprice.Size = new System.Drawing.Size(88, 26);
            this.txtprice.TabIndex = 15;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(394, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Price :";
            // 
            // txtbno
            // 
            this.txtbno.Location = new System.Drawing.Point(474, 82);
            this.txtbno.Name = "txtbno";
            this.txtbno.Size = new System.Drawing.Size(88, 26);
            this.txtbno.TabIndex = 13;
            this.txtbno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbno_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(394, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Bill No :";
            // 
            // txtpchik
            // 
            this.txtpchik.Location = new System.Drawing.Point(162, 286);
            this.txtpchik.Name = "txtpchik";
            this.txtpchik.Size = new System.Drawing.Size(88, 26);
            this.txtpchik.TabIndex = 11;
            this.txtpchik.TextChanged += new System.EventHandler(this.txtpchik_TextChanged);
            this.txtpchik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpchik_KeyPress);
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(162, 230);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(88, 26);
            this.txtqty.TabIndex = 10;
            this.txtqty.TextChanged += new System.EventHandler(this.txtqty_TextChanged);
            this.txtqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtqty_KeyPress);
            // 
            // cmbcompany
            // 
            this.cmbcompany.FormattingEnabled = true;
            this.cmbcompany.Location = new System.Drawing.Point(162, 181);
            this.cmbcompany.Name = "cmbcompany";
            this.cmbcompany.Size = new System.Drawing.Size(238, 28);
            this.cmbcompany.TabIndex = 9;
            this.cmbcompany.SelectedIndexChanged += new System.EventHandler(this.cmbcompany_SelectedIndexChanged);
            // 
            // txtvno
            // 
            this.txtvno.Location = new System.Drawing.Point(162, 138);
            this.txtvno.Name = "txtvno";
            this.txtvno.Size = new System.Drawing.Size(88, 26);
            this.txtvno.TabIndex = 8;
            // 
            // txtdate
            // 
            this.txtdate.CustomFormat = "dd/MM/yyyy";
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdate.Location = new System.Drawing.Point(162, 84);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(176, 26);
            this.txtdate.TabIndex = 7;
            // 
            // txtpno
            // 
            this.txtpno.Location = new System.Drawing.Point(162, 26);
            this.txtpno.Name = "txtpno";
            this.txtpno.ReadOnly = true;
            this.txtpno.Size = new System.Drawing.Size(88, 26);
            this.txtpno.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Rate Per Chik :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Chick Qty :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Company :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vehicle No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Purchase No :";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Gold;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(615, 109);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(80, 40);
            this.btnnew.TabIndex = 3;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Gold;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(615, 181);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(80, 39);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Gold;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(615, 257);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(80, 44);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Gold;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(615, 348);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(80, 48);
            this.btnclose.TabIndex = 6;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtsearch);
            this.panel3.Controls.Add(this.cmbsearch);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(287, 429);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 81);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(275, 31);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(119, 26);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // cmbsearch
            // 
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Items.AddRange(new object[] {
            "Purchase_number",
            "Company",
            "Bill_no"});
            this.cmbsearch.Location = new System.Drawing.Point(141, 30);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(106, 28);
            this.cmbsearch.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Search By :";
            // 
            // purchasegridv
            // 
            this.purchasegridv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.purchasegridv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasegridv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Purchase_number,
            this.Bill_no,
            this.Company,
            this.Vehicle_number,
            this.Chick_Quantity,
            this.Rate_Per_Chick,
            this.Price,
            this.Date});
            this.purchasegridv.Location = new System.Drawing.Point(8, 516);
            this.purchasegridv.Name = "purchasegridv";
            this.purchasegridv.RowTemplate.Height = 24;
            this.purchasegridv.Size = new System.Drawing.Size(704, 221);
            this.purchasegridv.TabIndex = 8;
            this.purchasegridv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.purchasegridv_MouseClick);
            // 
            // Purchase_number
            // 
            this.Purchase_number.DataPropertyName = "Purchase_number";
            this.Purchase_number.HeaderText = "Purchase_number";
            this.Purchase_number.Name = "Purchase_number";
            // 
            // Bill_no
            // 
            this.Bill_no.DataPropertyName = "Bill_no";
            this.Bill_no.HeaderText = "Bill_no";
            this.Bill_no.Name = "Bill_no";
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            // 
            // Vehicle_number
            // 
            this.Vehicle_number.DataPropertyName = "Vehicle_number";
            this.Vehicle_number.HeaderText = "Vehicle_number";
            this.Vehicle_number.Name = "Vehicle_number";
            // 
            // Chick_Quantity
            // 
            this.Chick_Quantity.DataPropertyName = "Chick_Quantity";
            this.Chick_Quantity.HeaderText = "Chick_Quantity";
            this.Chick_Quantity.Name = "Chick_Quantity";
            // 
            // Rate_Per_Chick
            // 
            this.Rate_Per_Chick.DataPropertyName = "Rate_Per_Chick";
            this.Rate_Per_Chick.HeaderText = "Rate_Per_Chick";
            this.Rate_Per_Chick.Name = "Rate_Per_Chick";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Purchaseentry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(728, 749);
            this.Controls.Add(this.purchasegridv);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Purchaseentry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchaseentry";
            this.Load += new System.EventHandler(this.Purchaseentry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchasegridv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpchik;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.ComboBox cmbcompany;
        private System.Windows.Forms.TextBox txtvno;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.TextBox txtpno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView purchasegridv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bill_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehicle_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chick_Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate_Per_Chick;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Label cid;
    }
}