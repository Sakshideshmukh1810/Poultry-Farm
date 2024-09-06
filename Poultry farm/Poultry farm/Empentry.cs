using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Poultry_farm
{
    public partial class Empentry : Form
    {
        User db = new User();
        DataTable dt = new DataTable();
        string id;
        String fname;
        public Empentry()
        {
            InitializeComponent();
        }

       
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtno.Text == "" || txtname.Text == "" || txtmobile.Text == "" || txtaddress.Text == "" || txtsalary.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }
           
            

            db.ExecuteSqlQuery("Insert into  Employee(EmployeeNo,EmployeeName,Address,DOB,DOJ,MobileNo,Salary)Values('" + txtno.Text + "','" + txtname.Text + "','" + txtaddress.Text + "','" + txtbdate.Value.ToString("MM/dd/yyyy") + "','" + txtjdate.Value.ToString("MM/dd/yyyy") + "','" + txtmobile.Text + "','" + txtsalary.Text + "')");
            cleadata();

            btnnew.Focus();
            db.FillGridData(dg, "Select *from Employee");
            MessageBox.Show("Employee Record is Saved Successfully...");
           
        }

        
        private void btndelete_Click(object sender, EventArgs e)
        {
            //delete row
            DialogResult ans = MessageBox.Show("Do you want to delete selected row?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                String id = txtno.Text;
                int i = db.ExecuteCommand("delete from Employee where EmployeeNo='" + id + "'");
                if (i == 0)
                    MessageBox.Show("Record is not found...");
                else
                    MessageBox.Show("Record is deleted successfully...");

            }

        }

        

       
        private void btnget_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dg.CurrentRow;
            if (row != null)
            {
                id = row.Cells[0].Value.ToString();

                DataTable dt = db.GettableData("select * from Employee where EmployeeNo=" + id);
                if (dt.Rows.Count > 0)
                {
                    txtno.Text = id;
                    txtname.Text = dt.Rows[0][1].ToString();
                    txtaddress.Text = dt.Rows[0][2].ToString();
                    txtbdate.Value = DateTime.Parse(dt.Rows[0][3].ToString());
                    txtjdate.Value = DateTime.Parse(dt.Rows[0][4].ToString());
                    txtmobile.Text = dt.Rows[0][5].ToString();
                    txtsalary.Text = dt.Rows[0][6].ToString();
                    byte[] b = (byte[])dt.Rows[0][7];
                    fname = Path.GetTempFileName();
                    File.WriteAllBytes(fname, b);
                   
                    btnsave.Text = "Update";
                    txtname.Focus();

                }
            }

        }

        private void btnlist_Click(object sender, EventArgs e)
        {


        }
        void FillTable(string sql = "select * from Employee")
        {
            DataTable dt = db.GettableData(sql);
            dg.DataSource = dt;
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtsearch.Text))
                {
                    FillTable();
                }
                else
                {
                    FillTable("select * from Employee where " + cmbsearch.Text + " like '%" + txtsearch.Text + "%'");

                }
            }
            catch (Exception )
            {

            }
        }

        private void Empentry_Load(object sender, EventArgs e)
        {
            db.FillGridData(dg, "Select *from Employee");
            btnnew.Focus();
            EnabledFales();
        }
        void EnabledFales()
        {
            btnsave.Enabled = false;
            btnupdate.Enabled = false;
            btndelete.Enabled = false;
            btnclose.Enabled = true;

        }
        void cleadata()
        {
            txtno.Clear();
            txtname.Clear();
            
            txtaddress.Clear();
            txtmobile.Clear();
            txtsalary.Clear();
           
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtname.Focus();
            btnsave.Enabled = true;
            GetmaxID();
        }
        void Cleardata()
        {
            cmbsearch.SelectedValue = 0;

            txtsearch.Clear();
        }
        void GetmaxID()
        {
            txtno.Text = db.GetAutoId("Select Max(EmployeeNo) from Employee").ToString();
        }
        void Griddisplay()
        {
            try
            {
                txtno.Text = dg.SelectedRows[0].Cells["EmployeeNo"].Value.ToString();
                txtname.Text = dg.SelectedRows[0].Cells["EmployeeName"].Value.ToString();
                
                txtaddress.Text = dg.SelectedRows[0].Cells["Address"].Value.ToString();
                
                txtbdate.Value = DateTime.Parse(dg.SelectedRows[0].Cells["DOB"].Value.ToString());
                txtjdate.Value = DateTime.Parse(dg.SelectedRows[0].Cells["DOJ"].Value.ToString());
                txtmobile.Text = dg.SelectedRows[0].Cells["MobileNo"].Value.ToString();
                txtsalary.Text = dg.SelectedRows[0].Cells["Salary"].Value.ToString();
                
               
                EnabledFales();
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
                txtname.Focus();
            }
            catch { }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtno.Text == "" || txtname.Text == "" || txtmobile.Text == "" || txtaddress.Text == "" || txtsalary.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }
            db.ExecuteSqlQuery("Update Employee SET EmployeeName='" + txtname.Text + "',Address='" + txtaddress.Text + "',DOB='" + txtbdate.Value.ToString("MM/dd/yyyy") + "',DOJ='" + txtjdate.Value.ToString("MM/dd/yyyy") + "',MobileNo='" + txtmobile.Text + "',Salary='" + txtsalary.Text + "'where EmployeeNo=" + txtno.Text);
            db.FillGridData(dg, "Select * from Employee");
            EnabledFales();
            cleadata();
            btnnew.Focus();
            MessageBox.Show("Update Data successfully");
        }

        private void dg_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();  
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtsalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
