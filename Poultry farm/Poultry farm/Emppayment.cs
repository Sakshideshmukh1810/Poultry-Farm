using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace Poultry_farm
{
    public partial class Emppayment : Form
    {
        User db = new User();
        public Emppayment()
        {
            InitializeComponent();
        }
        void FillTable(string sql = "select * from EmployeePayment")
        {
            DataTable dt = db.GettableData(sql);
            dg.DataSource = dt;
        }

        private void Emppayment_Load(object sender, EventArgs e)
        {
            FillTable();
            cmbpaymode.SelectedIndex = 0;
            lblnetpay.Text = "0.00";
            lblpaydate.Text = DateTime.Now.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            String paydate = DateTime.Now.ToString("yyyy-MM-dd");
            String fromdate = txtfdate.Value.ToString("yyyy-MM-dd");
            String todate = txtfdate.Value.ToString("yyyy-MM-dd");

            int d2 = (int)(txttdate.Value - txtfdate.Value).TotalDays;
            int d1 = Enumerable.Range(1, d2).Select(x => txtfdate.Value.AddDays(x))
            .Count(x => x.DayOfWeek == DayOfWeek.Sunday);
            int d = d2 - d1;
            int PayID = db.GetAutoId("Select Max(PayID) from EmployeePayment") ;

            string no = txtno.Text;
            string name = txtname.Text;
            string days = txtdays.Text;
            string salary = txtsalary.Text;
            string advance = txtadvance.Text;
            string deduction = txtdeduction.Text;
            string paymode = cmbpaymode.Text;
            string details = txtdetails.Text;
            if (String.IsNullOrEmpty(deduction))
            {
                deduction = "0";
            }
            
            double salday = double.Parse(salary) / d;
            double tsalary = salday * int.Parse(days);
            tsalary = tsalary - (double.Parse(advance) + double.Parse(deduction));
            lblnetpay.Text = tsalary + "";
            string netpay = lblnetpay.Text;

            if (string.IsNullOrEmpty(no))
            {
                MessageBox.Show("Employee ID cannot be left empty..", "Input Error");
                txtno.Focus();
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Employee name cannot be left empty..", "Input Error");
                txtname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(salary))
            {
                MessageBox.Show("Employee Salary cannot be left empty..", "Input Error");
                txtsalary.Focus();
                return;
            }

            
           

            string sql = string.Format("Insert into EmployeePayment (PayID,PayDate,FromDate,ToDate,EmpNo,EmpName,PresentDays,Salary,Advance,Deduction,PayMode,Details,NetPay) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", PayID, paydate, fromdate, todate, no, name, days, salary, advance, deduction, paymode, details, netpay);
            db.ExecuteCommand(sql);
            MessageBox.Show("Employee Payment entry made Successfully......");
            FillTable();
            txtno.Focus();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtno.Clear();
            txtname.Clear();
            txtsalary.Clear();
            txtdays.Clear();
            txtadvance.Clear();
            txtdeduction.Clear();
            txtdetails.Clear();
            txtno.Focus();
        }

        private void btnget_Click(object sender, EventArgs e)
        {
            String no = txtno.Text;
            if (String.IsNullOrEmpty(no))
            {
                MessageBox.Show("Please enter Employee ID...");
                return;
            }
            DataTable dt = db.GettableData("select * from Employee where EmployeeNo=" + no);
            if (dt.Rows.Count > 0)
            {
                txtname.Text = dt.Rows[0][1].ToString();
                txtsalary.Text = dt.Rows[0][6].ToString();
                FillTable("Select * from EmployeePayment where EmpNo=" + no);

                txtname.Focus();

            }
            else
            {
                txtname.Clear();
                txtsalary.Clear();
                MessageBox.Show("Record not found...");
            }
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            FillTable();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dg.CurrentRow;
            if (dr != null)
            {
                //delete row
                DialogResult ans = MessageBox.Show("Do you want to delete selected row?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (ans == DialogResult.Yes)
                {
                    String id = dr.Cells[0].Value.ToString();
                    db.ExecuteCommand("delete from EmployeePayment where PayId='" + id + "'");
                    FillTable();
                }
            }
            else
            {
                MessageBox.Show("Select row to delete...");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            mainform fr = new mainform();

            fr.Show();
            //this.Hide();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        void Griddisplay()
        {
            try
            {
                txtno.Text = dg.SelectedRows[0].Cells["EmpNo"].Value.ToString();
                txtname.Text = dg.SelectedRows[0].Cells["EmpName"].Value.ToString();
                txtsalary.Text = dg.SelectedRows[0].Cells["Salary"].Value.ToString();
                txtdays.Text = dg.SelectedRows[0].Cells["PresentDays"].Value.ToString();
                txtadvance.Text = dg.SelectedRows[0].Cells["Advance"].Value.ToString();
                txtdeduction.Text = dg.SelectedRows[0].Cells["Deduction"].Value.ToString();
                lblpaydate.Text = dg.SelectedRows[0].Cells["PayDate"].Value.ToString();
                txtfdate.Value = DateTime.Parse(dg.SelectedRows[0].Cells["FromDate"].Value.ToString());
                txttdate.Value = DateTime.Parse(dg.SelectedRows[0].Cells["ToDate"].Value.ToString());
                lblnetpay.Text = dg.SelectedRows[0].Cells["NetPay"].Value.ToString();
                
                btndelete.Enabled = true;
                txtname.Focus();
            }
            catch { }
        }

        private void dg_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();
        }

    }
}
