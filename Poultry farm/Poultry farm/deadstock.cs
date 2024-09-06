using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace Poultry_farm
{
    public partial class deadstock : Form
    {
        User db = new User();
        string id;

        String fname;
       
        public deadstock()
        {
            InitializeComponent();
        }
        void FillTable(string sql = "select * from DeadProduct")
        {
            DataTable dt = db.GettableData(sql);
            dg.DataSource = dt;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform fr = new mainform();

            fr.Show();
        }
        void Cleardata()
        {
            cmbsearch.SelectedValue = 0;
            cmbcategory.SelectedValue = 0;
            cmbcompany.SelectedValue = 0;

            txtsearch.Clear();
        }

        private void deadstock_Load(object sender, EventArgs e)
        {
            db.FillGridData(dg, "Select * from DeadProduct");
            db.FillCombo(cmbcategory, "Select * from Product", "ProductName", "ProductNo");
            db.FillCombo(cmbcompany, "Select * from tblcompany", "CompanyName", "ID");
           
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string no = txtno.Text;
            string name = txtname.Text;
            string cat = cmbcategory.Text;
            string brand = cmbcompany.Text;
            string qty = txtqty.Text;
            string price = txtprice.Text;
            string others = txtothers.Text;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Product name cannot be left empty..", "Input Error");
                txtname.Focus();
                return;
            }
            if (string.IsNullOrEmpty(cat))
            {
                MessageBox.Show("ProductFor cannot be left empty..", "Input Error");
                cmbcategory.Focus();
                return;
            }
            if (string.IsNullOrEmpty(brand))
            {
                MessageBox.Show("Brand cannot be left empty..", "Input Error");
                cmbcompany.Focus();
                return;
            }
            if (string.IsNullOrEmpty(qty))
            {
                MessageBox.Show("Qty cannot be left empty..", "Input Error");
                txtqty.Focus();
                return;
            }
            if (!Regex.IsMatch(qty, "^\\d+$"))
            {
                MessageBox.Show("Qty must be numeric..", "Input Error");
                txtqty.Focus();
                return;
            }
            if (string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Price cannot be left empty..", "Input Error");
                txtprice.Focus();
                return;
            }
            if (!Regex.IsMatch(price, "^\\d+(\\.\\d{1,2})?$"))
            {
                MessageBox.Show("Price must be numeric..", "Input Error");
                txtprice.Focus();
                return;
            }



            string sql = string.Format("Insert into DeadProduct values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", no, name, cat, brand, qty, price, others);
            db.ExecuteCommand(sql);
            db.ExecuteCommand("Update product set qty=qty-" + qty + " where ProductNo=" + no);
            MessageBox.Show("Product Dead Stock Record is Saved Successfully...");

            FillTable();
            txtno.Focus();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtsearch.Text))
                {
                    FillTable();
                }
                else
                {
                    FillTable("select * from DeadProduct where " + cmbsearch.Text + " like '%" + txtsearch.Text + "%'");

                }
            }
            catch (Exception )
            {

            }
        }
        void Griddisplay()
        {
            try
            {
                txtno.Text = dg.SelectedRows[0].Cells["ProductNo"].Value.ToString();
                txtname.Text = dg.SelectedRows[0].Cells["ProductName"].Value.ToString();
                cmbcategory.Text = dg.SelectedRows[0].Cells["ProductCategory"].Value.ToString();
                cmbcompany.Text = dg.SelectedRows[0].Cells["Brand"].Value.ToString();
                txtqty.Text = dg.SelectedRows[0].Cells["Qty"].Value.ToString();
                txtprice.Text = dg.SelectedRows[0].Cells["Price"].Value.ToString();
                txtothers.Text = dg.SelectedRows[0].Cells["Others"].Value.ToString();
               
                btnupdate.Enabled = true;
               
                txtname.Focus();
            }
            catch { }
        }

        private void btnget1_Click(object sender, EventArgs e)
        {

            String id = txtno.Text;
            if (String.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please enter product no");
                txtno.Focus();
                return;
            }

            DataTable dt = db.GettableData("select * from Product where ProductNo=" + id);
            if (dt.Rows.Count > 0)
            {
                txtno.Text = id;
                txtname.Text = dt.Rows[0][1].ToString();
                cmbcategory.Text = dt.Rows[0][2].ToString();
                cmbcompany.Text = dt.Rows[0][3].ToString();
                txtqty.Text = dt.Rows[0][4].ToString();
                txtprice.Text = dt.Rows[0][5].ToString();
                txtothers.Text = dt.Rows[0][6].ToString();
                
                txtname.Focus();

            }
        }

        private void dg_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtno.Text == "" || txtname.Text == "" || cmbcategory.Text == "" || cmbcompany.Text == "" || txtqty.Text == "" || txtprice.Text == "" || txtothers.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }
            db.ExecuteSqlQuery("Update DeadProduct SET ProductName='" + txtname.Text + "',ProductCategory='" + cmbcategory.Text + "',Brand='" + cmbcompany.Text + "',Qty='" + txtqty.Text + "' where ProductNo=" + txtno.Text);
            db.FillGridData(dg, "Select * from DeadProduct");
            EnabledFales();
            cleadata();
            
            MessageBox.Show("Update Data successfully");
        }
        void cleadata()
        {
            txtno.Clear();
            txtname.Clear();
            txtqty.Clear();
            txtprice.Clear();
            txtothers.Clear();
        }
        void EnabledFales()
        {
            btnsave.Enabled = false;
            btnupdate.Enabled = false;

            btnclose.Enabled = true;

        }
    }
}
