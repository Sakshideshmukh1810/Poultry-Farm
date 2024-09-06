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
    public partial class medicinentry : Form
    {
        User db = new User();
        public medicinentry()
        {
            InitializeComponent();
        }

        private void medicinentry_Load(object sender, EventArgs e)
        {
            db.FillGridData(medigridv, "Select *from tblmedicine");
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
            txtmname.Clear();
           
            txtrate.Clear();
            txtqty.Clear();
            txttmt.Clear();
            txtsname.Clear();
            
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtmname.Focus();
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
            txtid.Text = db.GetAutoId("Select Max(ID) from tblmedicine").ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtmname.Text == "" || txtsname.Text == "" || txtrate.Text == "" || txtqty.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Insert into  tblmedicine(ID,Medicinename,Shopname,Rate,Quantity,Totalammount,Date)Values('" + txtid.Text + "','" + txtmname.Text + "','" + txtsname.Text + "','" + txtrate.Text + "','" + txtqty.Text + "','" + txttmt.Text + "','" + txtdate.Value.ToString("MM/dd/yyyy") + "')");
            cleadata();

            btnnew.Focus();
            db.FillGridData(medigridv, "Select *from tblmedicine");

            MessageBox.Show("saved successfully");
        }
        void Griddisplay()
        {
            try
            {
                txtid.Text = medigridv.SelectedRows[0].Cells["ID"].Value.ToString();
                txtmname.Text = medigridv.SelectedRows[0].Cells["Medicinename"].Value.ToString();
                txtsname.Text = medigridv.SelectedRows[0].Cells["Shopname"].Value.ToString();
                txtrate.Text = medigridv.SelectedRows[0].Cells["Rate"].Value.ToString();
                txtqty.Text = medigridv.SelectedRows[0].Cells["Quantity"].Value.ToString();
                txttmt.Text = medigridv.SelectedRows[0].Cells["Totalammount"].Value.ToString();
                
                txtdate.Value = DateTime.Parse(medigridv.SelectedRows[0].Cells["Date"].Value.ToString());
                EnabledFales();
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
                txtmname.Focus();
            }
            catch { }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtmname.Text == "" || txtsname.Text == "" || txtrate.Text == "" || txtqty.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Update tblmedicine SET Medicinename='" + txtmname.Text + "',Shopname='" + txtsname.Text + "',Rate='" + txtrate.Text + "',Quantity='" + txtqty.Text + "',Totalammount='" + txttmt.Text + "',Date='" + txtdate.Value.ToString("MM/dd/yyyy") + "' where ID=" + txtid.Text);
            db.FillGridData(medigridv, "Select * from tblmedicine");
            EnabledFales();
            cleadata();
            btnnew.Focus();
            MessageBox.Show("Update Data successfully");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtmname.Text == "" || txtsname.Text == "" || txtrate.Text == "" || txtqty.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }


            if (MessageBox.Show("Do you want delete record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.ExecuteSqlQuery("Delete from tblmedicine where ID=" + txtid.Text);
            }
            db.FillGridData(medigridv, "Select * from tblmedicine");
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
                    db.FillGridData(medigridv, "Select * from tblmedicine");
                    return;
                }
                if (cmbsearch.SelectedIndex == 0)
                {
                    db.FillGridData(medigridv, "Select *from tblmedicine  where ID=" + txtsearch.Text);
                }
                else if (cmbsearch.SelectedIndex == 1)
                {
                    db.FillGridData(medigridv, "Select * from tblmedicine where Medicinename like'" + txtsearch.Text + "%'");
                }
                else
                {
                    db.FillGridData(medigridv, "Select *from tblmedicine  where Shopname like'" + txtsearch.Text + "%'");
                }

            }
            catch { }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform fr = new mainform();

            fr.Show();
        }
        public void cal()
        {
            try
            {
                double a = 0;
                double b = 0;
                double c = 0;
                if (txtrate.Text != "")
                {
                    a = (float)Convert.ToDouble(txtrate.Text);
                }
                if (txtqty.Text != "")
                {
                    b = (float)Convert.ToDouble(txtqty.Text);
                }
                c = a * b;
                txttmt.Text = c.ToString();
            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }


        }

        private void txtrate_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void medigridv_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();  
        }

        private void txtrate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txttmt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
