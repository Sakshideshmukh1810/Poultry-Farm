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
    public partial class Purchaseentry : Form
    {
        User db = new User();
        public Purchaseentry()
        {
            InitializeComponent();
        }

        private void Purchaseentry_Load(object sender, EventArgs e)
        {
            db.FillCombo(cmbcompany, "Select * from tblcompany", "CompanyName", "ID");
            db.FillGridData(purchasegridv, "Select *from tblPurchase");
            btnnew.Focus();
            EnabledFales();
        }
        void EnabledFales()
        {
            btnsave.Enabled = false;
            btnupdate.Enabled = true;
           
            btnclose.Enabled = true;

        }
        void cleadata()
        {
            txtpno.Clear();
            txtbno.Clear();
            txtvno.Clear();
            txtqty.Clear();
            txtpchik.Clear();
            txtprice.Clear();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            cmbcompany.Focus();
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
            txtpno.Text = db.GetAutoId("Select Max(Purchase_number) from tblpurchase").ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtpno.Text == "" || txtbno.Text == "" || cmbcompany.Text == "" || txtvno.Text == "" || txtqty.Text == "" || txtpchik.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Insert into  tblpurchase(Purchase_number,Bill_no,Company,Vehicle_number,Chick_Quantity,Rate_Per_Chick,Price,Date)Values('" + txtpno.Text + "','" + txtbno.Text + "','" + cmbcompany.Text + "','" + txtvno.Text + "','" + txtqty.Text + "','"+txtpchik.Text+"','"+txtprice.Text+"','" + txtdate.Value.ToString("MM/dd/yyyy") + "')");
            cleadata();

            btnnew.Focus();
            db.FillGridData(purchasegridv, "Select *from tblpurchase");

            MessageBox.Show("saved successfully");
        }
        void Griddisplay()
        {
            try
            {
                txtpno.Text = purchasegridv.SelectedRows[0].Cells["Purchase_number"].Value.ToString();
                txtbno.Text = purchasegridv.SelectedRows[0].Cells["Bill_no"].Value.ToString();
                cmbcompany.Text = purchasegridv.SelectedRows[0].Cells["Company"].Value.ToString();
                txtvno.Text = purchasegridv.SelectedRows[0].Cells["Vehicle_number"].Value.ToString();
                txtqty.Text = purchasegridv.SelectedRows[0].Cells["Chick_Quantity"].Value.ToString();
                txtpchik.Text = purchasegridv.SelectedRows[0].Cells["Rate_Per_Chick"].Value.ToString();
                txtprice.Text = purchasegridv.SelectedRows[0].Cells["Price"].Value.ToString();
                txtdate.Value = DateTime.Parse(purchasegridv.SelectedRows[0].Cells["Date"].Value.ToString());
                EnabledFales();
                btnupdate.Enabled = true;
               
              cmbcompany.Focus();
            }
            catch { }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtpno.Text == "" || txtbno.Text == "" || cmbcompany.Text == "" || txtvno.Text == "" || txtqty.Text == "" || txtpchik.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Update tblpurchase SET Purchase_number='" + txtpno.Text + "',Bill_no='" + txtbno.Text + "',Company='" + cmbcompany.Text + "',Vehicle_number='" + txtvno.Text + "',Chick_Quantity='" + txtqty.Text + "',Rate_Per_Chick='" + txtpchik.Text + "',Price='" + txtprice.Text + "',Date='" + txtdate.Value.ToString("MM/dd/yyyy") + "' where Purchase_number=" + txtpno.Text);
            db.FillGridData(purchasegridv, "Select * from tblpurchase");
            EnabledFales();
            cleadata();
            btnnew.Focus();
            MessageBox.Show("Update Data successfully");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == " ")
                {
                    db.FillGridData(purchasegridv, "Select * from tblpurchase");
                    return;
                }
                if (cmbsearch.SelectedIndex == 0)
                {
                    db.FillGridData(purchasegridv, "Select *from tblpurchase where purchase_number=" + txtsearch.Text);
                }
                else if (cmbsearch.SelectedIndex == 1)
                {
                    db.FillGridData(purchasegridv, "Select * from tblpurchase where Company like'" + txtsearch.Text + "%'");
                }
                else
                {
                    db.FillGridData(purchasegridv, "Select *from tblpurchase where Bill_no like'" + txtsearch.Text + "%'");
                }

            }
            catch { }
        }

        private void purchasegridv_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();  
        }
        public void cal()
        {
            try
            {
                double a = 0;
                double b = 0;
                double c = 0;
               
                if (txtqty.Text != "")
                {
                    a = (float)Convert.ToDouble(txtqty.Text);
                }
                if (txtpchik.Text != "")
                {
                    b = (float)Convert.ToDouble(txtpchik.Text);
                }
               
                c = a*b;
                txtprice.Text = c.ToString();
            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }


        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txtpchik_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void cmbcompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cid.Text = cmbcompany.SelectedValue.ToString();
                DataTable dt = db.GettableData("Select *from tblcompany where ID=" + cid.Text);

            }
            catch
            {


            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform fr = new mainform();

            fr.Show();
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtpchik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtbno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
