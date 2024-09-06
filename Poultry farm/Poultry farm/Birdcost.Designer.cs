namespace Poultry_farm
{
    partial class Birdcost
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
            this.txtpbcost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txttbird = new System.Windows.Forms.TextBox();
            this.txtexpense = new System.Windows.Forms.TextBox();
            this.txtmedicine = new System.Windows.Forms.TextBox();
            this.txtfeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bcostgridv = new System.Windows.Forms.DataGridView();
            this.Feed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totalbird = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perbirdcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bcostgridv)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(649, 86);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Per Bird Cost Finder\r\n";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtpbcost);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txttbird);
            this.panel2.Controls.Add(this.txtexpense);
            this.panel2.Controls.Add(this.txtmedicine);
            this.panel2.Controls.Add(this.txtfeed);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 147);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 251);
            this.panel2.TabIndex = 1;
            // 
            // txtpbcost
            // 
            this.txtpbcost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtpbcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpbcost.Location = new System.Drawing.Point(284, 129);
            this.txtpbcost.Name = "txtpbcost";
            this.txtpbcost.Size = new System.Drawing.Size(196, 41);
            this.txtpbcost.TabIndex = 9;
            this.txtpbcost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpbcost_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(302, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Per Bird Cost :";
            // 
            // txttbird
            // 
            this.txttbird.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttbird.Location = new System.Drawing.Point(129, 191);
            this.txttbird.Name = "txttbird";
            this.txttbird.Size = new System.Drawing.Size(118, 27);
            this.txttbird.TabIndex = 7;
            this.txttbird.TextChanged += new System.EventHandler(this.txttbird_TextChanged);
            this.txttbird.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttbird_KeyPress);
            // 
            // txtexpense
            // 
            this.txtexpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtexpense.Location = new System.Drawing.Point(129, 129);
            this.txtexpense.Name = "txtexpense";
            this.txtexpense.Size = new System.Drawing.Size(118, 27);
            this.txtexpense.TabIndex = 6;
            this.txtexpense.TextChanged += new System.EventHandler(this.txtexpense_TextChanged);
            this.txtexpense.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtexpense_KeyPress);
            // 
            // txtmedicine
            // 
            this.txtmedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmedicine.Location = new System.Drawing.Point(129, 73);
            this.txtmedicine.Name = "txtmedicine";
            this.txtmedicine.Size = new System.Drawing.Size(118, 27);
            this.txtmedicine.TabIndex = 5;
            this.txtmedicine.TextChanged += new System.EventHandler(this.txtmedicine_TextChanged);
            this.txtmedicine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmedicine_KeyPress);
            // 
            // txtfeed
            // 
            this.txtfeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfeed.Location = new System.Drawing.Point(129, 24);
            this.txtfeed.Name = "txtfeed";
            this.txtfeed.Size = new System.Drawing.Size(118, 27);
            this.txtfeed.TabIndex = 4;
            this.txtfeed.TextChanged += new System.EventHandler(this.txtfeed_TextChanged);
            this.txtfeed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfeed_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total Bird :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Expense :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Medicine :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Feed :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(221, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Date :";
            // 
            // txtdate
            // 
            this.txtdate.CustomFormat = "dd/MM/yyyy";
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdate.Location = new System.Drawing.Point(293, 102);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 27);
            this.txtdate.TabIndex = 3;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Gold;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(540, 295);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(80, 46);
            this.btnclose.TabIndex = 4;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Gold;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(540, 210);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(80, 38);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bcostgridv);
            this.panel3.Location = new System.Drawing.Point(12, 434);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(621, 212);
            this.panel3.TabIndex = 6;
            // 
            // bcostgridv
            // 
            this.bcostgridv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bcostgridv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bcostgridv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Feed,
            this.Medicine,
            this.Expense,
            this.Totalbird,
            this.Perbirdcost,
            this.Date});
            this.bcostgridv.Location = new System.Drawing.Point(14, 21);
            this.bcostgridv.Name = "bcostgridv";
            this.bcostgridv.RowTemplate.Height = 24;
            this.bcostgridv.Size = new System.Drawing.Size(593, 176);
            this.bcostgridv.TabIndex = 0;
            this.bcostgridv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bcostgridv_MouseClick);
            // 
            // Feed
            // 
            this.Feed.DataPropertyName = "Feed";
            this.Feed.HeaderText = "Feed";
            this.Feed.Name = "Feed";
            // 
            // Medicine
            // 
            this.Medicine.DataPropertyName = "Medicine";
            this.Medicine.HeaderText = "Medicine";
            this.Medicine.Name = "Medicine";
            // 
            // Expense
            // 
            this.Expense.DataPropertyName = "Expense";
            this.Expense.HeaderText = "Expense";
            this.Expense.Name = "Expense";
            // 
            // Totalbird
            // 
            this.Totalbird.DataPropertyName = "Totalbird";
            this.Totalbird.HeaderText = "Totalbird";
            this.Totalbird.Name = "Totalbird";
            // 
            // Perbirdcost
            // 
            this.Perbirdcost.DataPropertyName = "Perbirdcost";
            this.Perbirdcost.HeaderText = "Perbirdcost";
            this.Perbirdcost.Name = "Perbirdcost";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Birdcost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(649, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Birdcost";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Birdcost";
            this.Load += new System.EventHandler(this.Birdcost_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bcostgridv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtpbcost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttbird;
        private System.Windows.Forms.TextBox txtexpense;
        private System.Windows.Forms.TextBox txtmedicine;
        private System.Windows.Forms.TextBox txtfeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView bcostgridv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expense;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totalbird;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perbirdcost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}