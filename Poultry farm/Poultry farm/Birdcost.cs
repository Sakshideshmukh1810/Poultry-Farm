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
    public partial class Birdcost : Form
    {
        User db = new User();
        public Birdcost()
        {
            InitializeComponent();
        }

        private void Birdcost_Load(object sender, EventArgs e)
        {
            db.FillGridData(bcostgridv, "Select *from tblbirdcost");
            
        }
        void cleadata()
        {
            txtfeed.Clear();
            txtmedicine.Clear();
            txtexpense.Clear();
            txttbird.Clear();
            txtpbcost.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtfeed.Text == "" || txtmedicine.Text == "" || txtexpense.Text == "" || txttbird.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Insert into  tblbirdcost(Feed,Medicine,Expense,Totalbird,Perbirdcost,Date)Values('" + txtfeed.Text + "','" + txtmedicine.Text + "','" + txtexpense.Text + "','" + txttbird.Text + "','" + txtpbcost.Text + "','" + txtdate.Value.ToString("MM/dd/yyyy") + "')");
            cleadata();

           
            db.FillGridData(bcostgridv, "Select *from tblbirdcost");

            MessageBox.Show("saved successfully");
        }
        void Griddisplay()
        {
            try
            {
                txtfeed.Text = bcostgridv.SelectedRows[0].Cells["Feed"].Value.ToString();
                txtmedicine.Text = bcostgridv.SelectedRows[0].Cells["Medicine"].Value.ToString();
                txtexpense.Text = bcostgridv.SelectedRows[0].Cells["Expense"].Value.ToString();
                txttbird.Text = bcostgridv.SelectedRows[0].Cells["Totalbird"].Value.ToString();
                txtpbcost.Text = bcostgridv.SelectedRows[0].Cells["Perbirdcost"].Value.ToString();
                txtdate.Value = DateTime.Parse(bcostgridv.SelectedRows[0].Cells["Date"].Value.ToString());
                
                txtfeed.Focus();
            }
            catch { }
        }

        private void bcostgridv_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();  
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
                double d = 0;
                double e = 0;
                if (txtfeed.Text != "")
                {
                    a = (float)Convert.ToDouble(txtfeed.Text);
                }
                if (txtmedicine.Text != "")
                {
                    b = (float)Convert.ToDouble(txtmedicine.Text);
                }
                if (txtexpense.Text != "")
                {
                    c = (float)Convert.ToDouble(txtexpense.Text);
                }
                if (txttbird.Text != "")
                {
                    d = (float)Convert.ToDouble(txttbird.Text);
                }
                e = (a+b+c)/d;
                txtpbcost.Text = e.ToString();
            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }


        }

        private void txtfeed_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txtmedicine_TextChanged(object sender, EventArgs e)
        {
            cal();

        }

        private void txtexpense_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txttbird_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txtfeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtmedicine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtexpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txttbird_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtpbcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
