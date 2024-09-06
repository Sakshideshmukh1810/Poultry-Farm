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
    public partial class feedentry : Form
    {
        User db = new User();
        public feedentry()
        {
            InitializeComponent();
        }

        private void feedentry_Load(object sender, EventArgs e)
        {
            db.FillGridData(feedgridv, "Select *from tblfeed");
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
            txtcname.Clear();

            txtpbag.Clear();
            txtqty.Clear();
            txtamt.Clear();
            txtcontact.Clear();
            txtaddress.Clear();

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtcname.Focus();
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
            txtid.Text = db.GetAutoId("Select Max(ID) from tblfeed").ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtcname.Text == "" || txtaddress.Text == "" || txtcontact.Text == "" || txtpbag.Text == "" || txtqty.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Insert into  tblfeed(ID,Companyname,Address,Contact,Priceofbag,Quantity,Totalamount,Date)Values('" + txtid.Text + "','" + txtcname.Text + "','" + txtaddress.Text + "','" + txtcontact.Text + "','" + txtpbag.Text + "','" + txtqty.Text + "','" + txtamt.Text + "','" + txtdate.Value.ToString("MM/dd/yyyy") + "')");
            cleadata();

            btnnew.Focus();
            db.FillGridData(feedgridv, "Select *from tblfeed");

            MessageBox.Show("saved successfully");
        }
        void Griddisplay()
        {
            try
            {
                txtid.Text = feedgridv.SelectedRows[0].Cells["ID"].Value.ToString();
                txtcname.Text = feedgridv.SelectedRows[0].Cells["Companyname"].Value.ToString();
                
                txtaddress.Text = feedgridv.SelectedRows[0].Cells["Address"].Value.ToString();
                txtcontact.Text = feedgridv.SelectedRows[0].Cells["Contact"].Value.ToString();
                txtpbag.Text = feedgridv.SelectedRows[0].Cells["Priceofbag"].Value.ToString();
                txtqty.Text = feedgridv.SelectedRows[0].Cells["Quantity"].Value.ToString();
                txtamt.Text = feedgridv.SelectedRows[0].Cells["Totalamount"].Value.ToString();
                txtdate.Value = DateTime.Parse(feedgridv.SelectedRows[0].Cells["Date"].Value.ToString());
                EnabledFales();
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
                txtcname.Focus();
            }
            catch { }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtcname.Text == "" || txtaddress.Text == "" || txtcontact.Text == "" || txtpbag.Text == "" || txtqty.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Update tblfeed SET Companyname='" + txtcname.Text + "',Address='" + txtaddress.Text + "',Contact='" + txtcontact.Text + "',Priceofbag='" + txtpbag.Text + "',Quantity='" + txtqty.Text + "',Totalamount='" + txtamt.Text + "',Date='" + txtdate.Value.ToString("MM/dd/yyyy") + "' where ID=" + txtid.Text);
            db.FillGridData(feedgridv, "Select * from tblfeed");
            EnabledFales();
            cleadata();
            btnnew.Focus();
            MessageBox.Show("Update Data successfully");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtcname.Text == "" || txtaddress.Text == "" || txtcontact.Text == "" || txtpbag.Text == "" || txtqty.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }


            if (MessageBox.Show("Do you want delete record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteSqlQuery("Delete from tblfeed where ID=" + txtid.Text);
            }
            db.FillGridData(feedgridv, "Select * from tblfeed");
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
                    db.FillGridData(feedgridv, "Select * from tblfeed ");
                    return;
                }
                if (cmbsearch.SelectedIndex == 0)
                {
                    db.FillGridData(feedgridv, "Select *from tblfeed where ID=" + txtsearch.Text);
                }
                else if (cmbsearch.SelectedIndex == 1)
                {
                    db.FillGridData(feedgridv, "Select * from tblfeed where Companyname like'" + txtsearch.Text + "%'");
                }
                else
                {
                    db.FillGridData(feedgridv, "Select *from tblfeed where Contact like'" + txtsearch.Text + "%'");
                }

            }
            catch { }
        }
        public void cal()
        {
            try
            {
                double a = 0;
                double b = 0;
                double c = 0;
                if (txtpbag.Text != "")
                {
                    a = (float)Convert.ToDouble(txtpbag.Text);
                }
                if (txtqty.Text != "")
                {
                    b = (float)Convert.ToDouble(txtqty.Text);
                }
                c = a * b;
                txtamt.Text = c.ToString();
            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }


        }

        private void txtpbag_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void feedgridv_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();  
        }

        private void btnclose_Click(object sender, EventArgs e)
        {

            this.Close();
            mainform fr = new mainform();

            fr.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtpbag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
