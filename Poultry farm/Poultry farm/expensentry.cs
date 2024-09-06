using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Poultry_farm
{
    public partial class expensentry : Form
    {
        User db = new User();
        public expensentry()
        {
            InitializeComponent();
        }

        private void expensentry_Load(object sender, EventArgs e)
        {
            db.FillCombo(cmbexpense, "Select * from tblcategory", "Category", "ID");
            db.FillGridData(exgridv, "Select *from tblexentry");
            btnnew.Focus();
            EnabledFales();
        }
        void EnabledFales()
        {
            btnsave.Enabled = false;
            btnupdate.Enabled = false;
           
            btnclose.Enabled = true;

        }
        void cleadata()
        {
            txtid.Clear();
            
            txtamt.Clear();
            txtremark.Clear();
            
        }

        private void cmbexpense_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                exid.Text = cmbexpense.SelectedValue.ToString();
                DataTable dt = db.GettableData("Select *from tblcategory where ID=" + exid.Text);
                
            }
            catch
            {
                

            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            cmbexpense.Focus();
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
            txtid.Text = db.GetAutoId("Select Max(ID) from tblexentry").ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || cmbexpense.Text == "" || txtamt.Text == "" || txtremark.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Insert into  tblexentry(ID,Expensetype,Amount,Remark,Date)Values('" + txtid.Text + "','" + cmbexpense.Text + "','" + txtamt.Text + "','" + txtremark.Text + "','" + txtdate.Value.ToString("MM/dd/yyyy") + "')");
            cleadata();

            btnnew.Focus();
            db.FillGridData(exgridv, "Select *from tblexentry");

            MessageBox.Show("saved successfully");
        }
        void Griddisplay()
        {
            try
            {
                txtid.Text = exgridv.SelectedRows[0].Cells["ID"].Value.ToString();
                cmbexpense.Text = exgridv.SelectedRows[0].Cells["Expensetype"].Value.ToString();
                txtamt.Text = exgridv.SelectedRows[0].Cells["Amount"].Value.ToString();
                txtremark.Text = exgridv.SelectedRows[0].Cells["Remark"].Value.ToString();
                
                txtdate.Value = DateTime.Parse(exgridv.SelectedRows[0].Cells["Date"].Value.ToString());
                EnabledFales();
                btnupdate.Enabled = true;
               
                cmbexpense.Focus();
            }
            catch { }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || cmbexpense.Text == "" || txtamt.Text == "" || txtremark.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Update tblexentry SET Expensetype='" + cmbexpense.Text + "',Amount='" + txtamt.Text + "',Remark='" + txtremark.Text + "',Date='" + txtdate.Value.ToString("MM/dd/yyyy") + "' where ID=" + txtid.Text);
            db.FillGridData(exgridv, "Select * from tblexentry");
            EnabledFales();
            cleadata();
            btnnew.Focus();
            MessageBox.Show("Update Data successfully");
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == " ")
                {
                    db.FillGridData(exgridv, "Select * from tblexentry");
                    return;
                }
                if (cmbsearch.SelectedIndex == 0)
                {
                    db.FillGridData(exgridv, "Select *from tblexentry where ID=" + txtsearch.Text);
                }
                else if(cmbsearch.SelectedIndex == 1)
                {
                    db.FillGridData(exgridv, "Select * from tblexentry where Expensetype like'" + txtsearch.Text + "%'");
                }
                
            }
            catch { }
        }

        private void exgridv_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();  
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform fr = new mainform();

            fr.Show();
        }

        private void txtamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
