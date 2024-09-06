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
    public partial class wastesale : Form
    {
        User db = new User();
        public wastesale()
        {
            InitializeComponent();
        }
        void FillTable(string sql = "select * from tblwastesale")
        {
            DataTable dt = db.GettableData(sql);
            dg.DataSource = dt;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            String no = txtid.Text;
            if (String.IsNullOrEmpty(no))
            {
                MessageBox.Show("Please enter Customer ID...");
                return;
            }
            DataTable dt = db.GettableData("select * from tblcust_registration where ID =" + no);
            if (dt.Rows.Count > 0)
            {
                txtcustname.Text = dt.Rows[0][1].ToString();
                txtaddress.Text = dt.Rows[0][3].ToString();
                txtcontact.Text = dt.Rows[0][2].ToString();
                FillTable("Select * from tblwastesale where ID=" + no);

                txtcustname.Focus();

            }
            else
            {
                txtcustname.Clear();
                txtaddress.Clear();
                txtcontact.Clear();
                MessageBox.Show("Record not found...");
            }
        }

       

        private void wastesale_Load(object sender, EventArgs e)
        {
            db.FillGridData(dg, "Select *from tblwastesale");
            btnget.Focus();
            EnabledFales();
        }
        void EnabledFales()
        {
            btnsave.Enabled = true;
            btnupdate.Enabled = true;
            btndelete.Enabled = false;
            btnclose.Enabled = true;

        }
        void cleadata()
        {
            txtid.Clear();
            txtcustname.Clear();

            txtpbag.Clear();
            txtqty.Clear();
            txtamt.Clear();
            txtcontact.Clear();
            txtaddress.Clear();

        }
        void Cleardata()
        {
            cmbsearch.SelectedValue = 0;

            txtsearch.Clear();
        }
        

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtcustname.Text == "" || txtaddress.Text == "" || txtcontact.Text == "" || txtpbag.Text == "" || txtqty.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }
            string no = txtid.Text;
            db.ExecuteSqlQuery("Insert into  tblwastesale(ID,Customername,Address,Contact,Priceofbag,Quantity,Totalamount,Date)Values('" + txtid.Text + "','" + txtcustname.Text + "','" + txtaddress.Text + "','" + txtcontact.Text + "','" + txtpbag.Text + "','" + txtqty.Text + "','" + txtamt.Text + "','" + txtdate.Value.ToString("MM/dd/yyyy") + "')");
            cleadata();

            btnget.Focus();
            db.FillGridData(dg, "Select *from tblwastesale");

            MessageBox.Show("saved successfully");
        }
        void Griddisplay()
        {
            try
            {
                txtid.Text = dg.SelectedRows[0].Cells["ID"].Value.ToString();
                txtcustname.Text = dg.SelectedRows[0].Cells["Customername"].Value.ToString();

                txtaddress.Text = dg.SelectedRows[0].Cells["Address"].Value.ToString();
                txtcontact.Text = dg.SelectedRows[0].Cells["Contact"].Value.ToString();
                txtpbag.Text = dg.SelectedRows[0].Cells["Priceofbag"].Value.ToString();
                txtqty.Text = dg.SelectedRows[0].Cells["Quantity"].Value.ToString();
                txtamt.Text = dg.SelectedRows[0].Cells["Totalamount"].Value.ToString();
                txtdate.Value = DateTime.Parse(dg.SelectedRows[0].Cells["Date"].Value.ToString());
                EnabledFales();
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
                txtcustname.Focus();
            }
            catch { }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtcustname.Text == "" || txtaddress.Text == "" || txtcontact.Text == "" || txtpbag.Text == "" || txtqty.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Update tblwastesale SET Customername='" + txtcustname.Text + "',Address='" + txtaddress.Text + "',Contact='" + txtcontact.Text + "',Priceofbag='" + txtpbag.Text + "',Quantity='" + txtqty.Text + "',Totalamount='" + txtamt.Text + "',Date='" + txtdate.Value.ToString("MM/dd/yyyy") + "' where ID=" + txtid.Text);
            db.FillGridData(dg, "Select * from tblwastesale");
            EnabledFales();
            cleadata();
            btnget.Focus();
            MessageBox.Show("Update Data successfully");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtcustname.Text == "" || txtaddress.Text == "" || txtcontact.Text == "" || txtpbag.Text == "" || txtqty.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }


            if (MessageBox.Show("Do you want delete record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteSqlQuery("Delete from tblwastesale where ID=" + txtid.Text);
            }
            db.FillGridData(dg, "Select * from tblwastesale");
            EnabledFales();
            cleadata();
            btnget.Focus();
            MessageBox.Show("Delete Data successfully");
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == " ")
                {
                    db.FillGridData(dg, "Select * from tblwastesale ");
                    return;
                }
                if (cmbsearch.SelectedIndex == 0)
                {
                    db.FillGridData(dg, "Select *from tblwastesale where ID=" + txtsearch.Text);
                }
                else if (cmbsearch.SelectedIndex == 1)
                {
                    db.FillGridData(dg, "Select * from tblwastesale where Customername like'" + txtsearch.Text + "%'");
                }
                else
                {
                    db.FillGridData(dg, "Select *from tblwastesale where Contact like'" + txtsearch.Text + "%'");
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

        private void dg_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();  
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform fr = new mainform();

            fr.Show();
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

        private void txtamt_TextChanged(object sender, EventArgs e)
        {

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

    }
}
