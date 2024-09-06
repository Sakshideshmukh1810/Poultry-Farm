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
    public partial class expensecategory : Form
    {
        User db = new User();
        public expensecategory()
        {
            InitializeComponent();
        }

        private void expensecategory_Load(object sender, EventArgs e)
        {
            db.FillGridData(catgridv, "Select *from tblcategory");
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
            txtcname.Clear();
            
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
            txtid.Text = db.GetAutoId("Select Max(ID) from tblcategory").ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtcname.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Insert into  tblcategory(ID,Category)Values('" + txtid.Text + "','" + txtcname.Text + "')");
            cleadata();

            btnnew.Focus();
            db.FillGridData(catgridv, "Select *from tblcategory");

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
                txtid.Text = catgridv.SelectedRows[0].Cells["ID"].Value.ToString();
                txtcname.Text = catgridv.SelectedRows[0].Cells["Category"].Value.ToString();
                
                EnabledFales();
                
                txtcname.Focus();
            }
            catch { }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == " ")
                {
                    db.FillGridData(catgridv, "Select * from tblcategory");
                    return;
                }
                if (cmbsearch.SelectedIndex == 0)
                {
                    db.FillGridData(catgridv, "Select *from tblcategory where ID=" + txtsearch.Text);
                }
                
                else
                {
                    db.FillGridData(catgridv, "Select *from tblcategory where Category like'" + txtsearch.Text + "%'");
                }

            }
            catch { }
        }

        private void catgridv_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
