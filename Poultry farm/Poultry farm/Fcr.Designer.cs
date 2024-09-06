namespace Poultry_farm
{
    partial class Fcr
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
            this.txtfcr = new System.Windows.Forms.TextBox();
            this.txttbag = new System.Windows.Forms.TextBox();
            this.txttrchik = new System.Windows.Forms.TextBox();
            this.txtwpchik = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.fcrgridv = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcrgridv)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(715, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "FCR CALCULATION";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtfcr);
            this.panel2.Controls.Add(this.txttbag);
            this.panel2.Controls.Add(this.txttrchik);
            this.panel2.Controls.Add(this.txtwpchik);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(18, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 262);
            this.panel2.TabIndex = 1;
            // 
            // txtfcr
            // 
            this.txtfcr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfcr.Location = new System.Drawing.Point(270, 202);
            this.txtfcr.Name = "txtfcr";
            this.txtfcr.ReadOnly = true;
            this.txtfcr.Size = new System.Drawing.Size(252, 27);
            this.txtfcr.TabIndex = 8;
            this.txtfcr.TextChanged += new System.EventHandler(this.txtfcr_TextChanged);
            this.txtfcr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfcr_KeyPress);
            // 
            // txttbag
            // 
            this.txttbag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttbag.Location = new System.Drawing.Point(270, 142);
            this.txttbag.Name = "txttbag";
            this.txttbag.Size = new System.Drawing.Size(252, 27);
            this.txttbag.TabIndex = 7;
            this.txttbag.TextChanged += new System.EventHandler(this.txttbag_TextChanged);
            this.txttbag.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttbag_KeyPress);
            // 
            // txttrchik
            // 
            this.txttrchik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttrchik.Location = new System.Drawing.Point(270, 87);
            this.txttrchik.Name = "txttrchik";
            this.txttrchik.Size = new System.Drawing.Size(252, 27);
            this.txttrchik.TabIndex = 6;
            this.txttrchik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttrchik_KeyPress);
            // 
            // txtwpchik
            // 
            this.txtwpchik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwpchik.Location = new System.Drawing.Point(270, 31);
            this.txtwpchik.Name = "txtwpchik";
            this.txtwpchik.Size = new System.Drawing.Size(252, 27);
            this.txtwpchik.TabIndex = 5;
            this.txtwpchik.TextChanged += new System.EventHandler(this.txtwpchik_TextChanged);
            this.txtwpchik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtwpchik_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(182, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "FCR :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(132, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total Bags :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Remaining Chick :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Weight Per Chik(Gram) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date :";
            // 
            // txtdate
            // 
            this.txtdate.CustomFormat = "dd/MM/yyyy";
            this.txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtdate.Location = new System.Drawing.Point(416, 106);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(200, 27);
            this.txtdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID :";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(162, 105);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(100, 27);
            this.txtid.TabIndex = 4;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.Gold;
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Location = new System.Drawing.Point(598, 156);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(86, 41);
            this.btnnew.TabIndex = 5;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = false;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.Gold;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(598, 242);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(86, 49);
            this.btnsave.TabIndex = 6;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Gold;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(598, 327);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(86, 42);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // fcrgridv
            // 
            this.fcrgridv.AllowUserToAddRows = false;
            this.fcrgridv.AllowUserToDeleteRows = false;
            this.fcrgridv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.fcrgridv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fcrgridv.Location = new System.Drawing.Point(29, 456);
            this.fcrgridv.Name = "fcrgridv";
            this.fcrgridv.ReadOnly = true;
            this.fcrgridv.RowTemplate.Height = 24;
            this.fcrgridv.Size = new System.Drawing.Size(655, 267);
            this.fcrgridv.TabIndex = 8;
            this.fcrgridv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fcrgridv_MouseClick);
            // 
            // Fcr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(715, 740);
            this.Controls.Add(this.fcrgridv);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Name = "Fcr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fcr";
            this.Load += new System.EventHandler(this.Fcr_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fcrgridv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtfcr;
        private System.Windows.Forms.TextBox txttbag;
        private System.Windows.Forms.TextBox txttrchik;
        private System.Windows.Forms.TextBox txtwpchik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView fcrgridv;
    }
}