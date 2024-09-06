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
    public partial class companyentry : Form
    {
        User db = new User();
        public companyentry()
        {
            InitializeComponent();
        }

        private void companyentry_Load(object sender, EventArgs e)
        {
            db.FillGridData(compgridv, "Select *from tblcompany");
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
            txtid.Clear();
            txtname.Clear();
            txtcontact.Clear();
            txtaddress.Clear();
            txtcity.Clear();
            txtstate.Clear();
            txtcountry.Clear();
            txtemail.Clear();
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
            txtid.Text = db.GetAutoId("Select Max(ID) from tblcompany").ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "" || txtaddress.Text == "" || txtcity.Text == "" || txtstate.Text == "" || txtcountry.Text == "" || txtcontact.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Insert into  tblcompany(ID,CompanyName,Address,City,State,Country,Contact,Email,Date)Values('" + txtid.Text + "','" + txtname.Text + "','" + txtaddress.Text + "','" + txtcity.Text + "','" + txtstate.Text + "','" + txtcountry.Text + "','" + txtcontact.Text + "','" + txtemail.Text + "','" + txtdate.Value.ToString("MM/dd/yyyy") + "')");
            cleadata();

            btnnew.Focus();
            db.FillGridData(compgridv, "Select *from tblcompany");

            MessageBox.Show("saved successfully");
        }
        void Griddisplay()
        {
            try
            {
                txtid.Text = compgridv.SelectedRows[0].Cells["ID"].Value.ToString();
                txtname.Text = compgridv.SelectedRows[0].Cells["CompanyName"].Value.ToString();
                txtaddress.Text = compgridv.SelectedRows[0].Cells["Address"].Value.ToString();
                txtcity.Text = compgridv.SelectedRows[0].Cells["City"].Value.ToString();
                txtstate.Text = compgridv.SelectedRows[0].Cells["State"].Value.ToString();
                txtcountry.Text = compgridv.SelectedRows[0].Cells["Country"].Value.ToString();
                txtcontact.Text = compgridv.SelectedRows[0].Cells["Contact"].Value.ToString();
                txtemail.Text = compgridv.SelectedRows[0].Cells["Email"].Value.ToString();
                txtdate.Value = DateTime.Parse(compgridv.SelectedRows[0].Cells["Date"].Value.ToString());
                EnabledFales();
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
                txtname.Focus();
            }
            catch { }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "" || txtaddress.Text == "" || txtcity.Text == "" || txtstate.Text == "" || txtcountry.Text == "" || txtcontact.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Update tblcompany SET CompanyName='" + txtname.Text + "',Address='" + txtaddress.Text + "',City='" + txtcity.Text + "',State='" + txtstate.Text + "',Country='" + txtcountry.Text + "',Contact='" + txtcontact.Text + "',Email='" + txtemail.Text + "',Date='" + txtdate.Value.ToString("MM/dd/yyyy") + "' where ID=" + txtid.Text);
            db.FillGridData(compgridv, "Select * from tblcompany");
            EnabledFales();
            cleadata();
            btnnew.Focus();
            MessageBox.Show("Update Data successfully");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtname.Text == "" || txtaddress.Text == "" || txtcity.Text == "" || txtstate.Text == "" || txtcountry.Text == "" || txtcontact.Text == "" || txtemail.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }


            if (MessageBox.Show("Do you want delete record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteSqlQuery("Delete from tblcompany where ID=" + txtid.Text);
            }
            db.FillGridData(compgridv, "Select * from tblcompany");
            EnabledFales();
            cleadata();
            btnnew.Focus();
            MessageBox.Show("Delete Data successfully");
            
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == " ")
                {
                    db.FillGridData(compgridv, "Select * from tblcompany ");
                    return;
                }
                if (cmbsearch.SelectedIndex == 0)
                {
                    db.FillGridData(compgridv, "Select *from tblcompany  where ID=" + txtsearch.Text);
                }
                else if (cmbsearch.SelectedIndex == 1)
                {
                    db.FillGridData(compgridv, "Select * from tblcompany where CompanyName like'" + txtsearch.Text + "%'");
                }
                else
                {
                    db.FillGridData(compgridv, "Select *from tblcompany  where Contact like'" + txtsearch.Text + "%'");
                }

            }
            catch { }
        }

        private void compgridv_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();  
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform fr = new mainform();

            fr.Show();
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {

        }
       

    }
}
