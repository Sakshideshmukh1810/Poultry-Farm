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
    public partial class Fcr : Form
    {
        User db = new User();
        public Fcr()
        {
            InitializeComponent();
        }

        private void Fcr_Load(object sender, EventArgs e)
        {
            db.FillGridData(fcrgridv, "Select *from tblfcr");
            btnnew.Focus();
            EnabledFales();
        }
        void EnabledFales()
        {
            btnsave.Enabled = false;   
           btnclose.Enabled = true;

        }
        void cleadata()
        {
            txtid.Clear();
            txtwpchik.Clear();
            txttrchik.Clear();
            txttbag.Clear();
            txtfcr.Clear();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtwpchik.Focus();
            btnsave.Enabled = true;
            GetmaxID();
        }
        void GetmaxID()
        {
            txtid.Text = db.GetAutoId("Select Max(ID) from tblfcr").ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtwpchik.Text == "" || txttrchik.Text == "" || txttbag.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Insert into  tblfcr(ID,weight_per_chick,total_remain_chick,total_bag,FCR,Date)Values('" + txtid.Text + "','" + txtwpchik.Text + "','" + txttrchik.Text + "','" + txttbag.Text + "','" + txtfcr.Text + "','" + txtdate.Value.ToString("MM/dd/yyyy") + "')");
            cleadata();

            btnnew.Focus();
            db.FillGridData(fcrgridv, "Select *from tblfcr");

            MessageBox.Show("saved successfully");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform fr = new mainform();

            fr.Show();
        }
        void Griddisplay()
        {
            try
            {
                txtid.Text = fcrgridv.SelectedRows[0].Cells["ID"].Value.ToString();
                txtwpchik.Text = fcrgridv.SelectedRows[0].Cells["weight_per_chick"].Value.ToString();
                txttrchik.Text = fcrgridv.SelectedRows[0].Cells["total_remain_chick"].Value.ToString();
                txttbag.Text = fcrgridv.SelectedRows[0].Cells["total_bag"].Value.ToString();
                txtfcr.Text = fcrgridv.SelectedRows[0].Cells["FCR"].Value.ToString();
                txtdate.Value = DateTime.Parse(fcrgridv.SelectedRows[0].Cells["Date"].Value.ToString());
                EnabledFales();
               
                txtwpchik.Focus();
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

                if (txttbag.Text != "")
                {
                    a = (float)Convert.ToDouble(txttbag.Text);
                }
                if (txtwpchik.Text != "")
                {
                    b = (float)Convert.ToDouble(txtwpchik.Text);
                }

                c = a / b;
                txtfcr.Text = c.ToString();
            }
            catch (Exception ex)
            {

                string msg = ex.Message;
            }


        }

        private void txtwpchik_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txttbag_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txtfcr_TextChanged(object sender, EventArgs e)
        {
            cal();
        }

        private void txtwpchik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txttrchik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txttbag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtfcr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar == ' ' || char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void fcrgridv_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();  
        }
    }
}
