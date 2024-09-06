namespace Poultry_farm
{
    partial class expensentry
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.exid = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtremark = new System.Windows.Forms.TextBox();
            this.txtamt = new System.Windows.Forms.TextBox();
            this.cmbexpense = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cmbsearch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.exgridv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expensetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnupdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exgridv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 70);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXPENSE ENTRY";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.exid);
            this.panel2.Controls.Add(this.txtdate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtremark);
            this.panel2.Controls.Add(this.txtamt);
            this.panel2.Controls.Add(this.cmbexpense);
            this.panel2.Controls.Add(this.txtid);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 219);
            this.panel2.TabIndex = 1;
            // 
            // exid
            // 
            this.exid.AutoSize = true;
            this.exid.Location = new System.Drawing.Point(450, 68);
            this.exid.Name = "exid";
            this.exid.Size = new System.Drawing.Size(16, 17);
            this.exid.TabIndex = 10;
            this.exid.Text = "1";
            // 
            // txtdate
            // 
            this.txtdate.CustomFormat = "dd/MM/yyyy";
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdate.Location = new System.Drawing.Point(392, 22);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 27);
            this.txtdate.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Date :";
            // 
            // txtremark
            // 
            this.txtremark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremark.Location = new System.Drawing.Point(184, 168);
            this.txtremark.Name = "txtremark";
            this.txtremark.Size = new System.Drawing.Size(243, 27);
            this.txtremark.TabIndex = 7;
            // 
            // txtamt
            // 
            this.txtamt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamt.Location = new System.Drawing.Point(184, 117);
            this.txtamt.Name = "txtamt";
            this.txtamt.Size = new System.Drawing.Size(243, 27);
            this.txtamt.TabIndex = 6;
            this.txtamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamt_KeyPress);
            // 
            // cmbexpense
            // 
            this.cmbexpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbexpense.FormattingEnabled = true;
            this.cmbexpense.Location = new System.Drawing.Point(184, 65);
            this.cmbexpense.Name = "cmbexpense";
            this.cmbexpense.Size = new System.Drawing.Size(243, 28);
            this.cmbexpense.TabIndex = 5;
            this.cmbexpense.SelectedIndexChanged += new System.EventHandler(this.cmbexpense_SelectedIndexChanged);
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(184, 19);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 27);
            this.txtid.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Remark :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Amount :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Expense Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID :";
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Gold;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(687, 98);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(94, 42);
            this.btnnew.TabIndex = 2;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Gold;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(687, 163);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(94, 48);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Gold;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(687, 294);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(94, 51);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtsearch);
            this.panel3.Controls.Add(this.cmbsearch);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.exgridv);
            this.panel3.Location = new System.Drawing.Point(12, 359);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(751, 359);
            this.panel3.TabIndex = 5;
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(361, 26);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(248, 27);
            this.txtsearch.TabIndex = 3;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // cmbsearch
            // 
            this.cmbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbsearch.FormattingEnabled = true;
            this.cmbsearch.Items.AddRange(new object[] {
            "ID",
            "Expensetype"});
            this.cmbsearch.Location = new System.Drawing.Point(184, 28);
            this.cmbsearch.Name = "cmbsearch";
            this.cmbsearch.Size = new System.Drawing.Size(121, 28);
            this.cmbsearch.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Search By :";
            // 
            // exgridv
            // 
            this.exgridv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.exgridv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exgridv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Expensetype,
            this.Amount,
            this.Remark,
            this.Date});
            this.exgridv.Location = new System.Drawing.Point(19, 82);
            this.exgridv.Name = "exgridv";
            this.exgridv.RowTemplate.Height = 24;
            this.exgridv.Size = new System.Drawing.Size(715, 259);
            this.exgridv.TabIndex = 0;
            this.exgridv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.exgridv_MouseClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Expensetype
            // 
            this.Expensetype.DataPropertyName = "Expensetype";
            this.Expensetype.HeaderText = "Expensetype";
            this.Expensetype.Name = "Expensetype";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "Remark";
            this.Remark.HeaderText = "Remark";
            this.Remark.Name = "Remark";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Gold;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(687, 228);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(94, 46);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // expensentry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(792, 741);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "expensentry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "expensentry";
            this.Load += new System.EventHandler(this.expensentry_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exgridv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtremark;
        private System.Windows.Forms.TextBox txtamt;
        private System.Windows.Forms.ComboBox cmbexpense;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView exgridv;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.ComboBox cmbsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label exid;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expensetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}