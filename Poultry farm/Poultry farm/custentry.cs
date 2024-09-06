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
    public partial class custentry : Form
    {
        User db = new User();
        public custentry()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform fr = new mainform();

            fr.Show();
        }

        private void custentry_Load(object sender, EventArgs e)
        {
            db.FillGridData(custgridv, "Select *from tblcust_registration");
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
            txtcustname.Clear();
            txtcontact.Clear();
            txtaddress.Clear();
            txtshopname.Clear();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtcustname.Focus();
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
            txtid.Text = db.GetAutoId("Select Max(ID) from tblcust_registration").ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtcustname.Text == "" || txtcontact.Text == "" || txtaddress.Text == "" || txtshopname.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Insert into  tblcust_registration(ID,Name,Contact,Address,Shopname,Date)Values('" + txtid.Text + "','" + txtcustname.Text + "','" + txtcontact.Text + "','" + txtaddress.Text + "','" + txtshopname.Text + "','" + txtdate.Value.ToString("MM/dd/yyyy") + "')");
            cleadata();

            btnnew.Focus();
            db.FillGridData(custgridv, "Select *from tblcust_registration");
            
            MessageBox.Show("saved successfully");
        }
        void Griddisplay()
        {
            try
            {
                txtid.Text = custgridv.SelectedRows[0].Cells["ID"].Value.ToString();
                txtcustname.Text = custgridv.SelectedRows[0].Cells["Name"].Value.ToString();
                txtcontact.Text = custgridv.SelectedRows[0].Cells["Contact"].Value.ToString();
                txtaddress.Text = custgridv.SelectedRows[0].Cells["Address"].Value.ToString();
                txtshopname.Text = custgridv.SelectedRows[0].Cells["Shopname"].Value.ToString();
                txtdate.Value = DateTime.Parse(custgridv.SelectedRows[0].Cells["Date"].Value.ToString());
                EnabledFales();
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
                txtcustname.Focus();
            }
            catch { }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtcustname.Text == "" || txtcontact.Text == "" || txtaddress.Text == "" || txtshopname.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Update tblcust_registration SET Name='" + txtcustname.Text + "',Contact='" + txtcontact.Text + "',Address='" + txtaddress.Text + "',Shopname='" + txtshopname.Text + "',Date='" + txtdate.Value.ToString("MM/dd/yyyy") + "' where ID=" + txtid.Text);
            db.FillGridData(custgridv, "Select * from tblcust_registration");
            EnabledFales();
            cleadata();
            btnnew.Focus();
            MessageBox.Show("Update Data successfully");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtcustname.Text == "" || txtcontact.Text == "" || txtaddress.Text == "" || txtshopname.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }


            if (MessageBox.Show("Do you want delete record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteSqlQuery("Delete from tblcust_registration where ID=" + txtid.Text);
            }
            db.FillGridData(custgridv, "Select * from tblcust_registration");
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
                    db.FillGridData(custgridv, "Select * from tblcust_registration");
                    return;
                }
                if (cmbsearch.SelectedIndex == 0)
                {
                    db.FillGridData(custgridv, "Select *from tblcust_registration where ID=" + txtsearch.Text);
                }
                else if (cmbsearch.SelectedIndex == 1)
                {
                    db.FillGridData(custgridv, "Select * from tblcust_registration where Name like'" + txtsearch.Text + "%'");
                }
                else
                {
                    db.FillGridData(custgridv, "Select *from tblcust_registration where Contact like'" + txtsearch.Text + "%'");
                }

            }
            catch { }

        }

        private void custgridv_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();  
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

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
