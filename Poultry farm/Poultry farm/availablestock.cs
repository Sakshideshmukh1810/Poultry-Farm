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
    public partial class availablestock : Form
    {
        User db = new User();
        string id;
        
        String fname;
       
        public availablestock()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform fr = new mainform();

            fr.Show();
        }

        private void availablestock_Load(object sender, EventArgs e)
        {
            db.FillGridData(dg, "Select * from Product");
            
            db.FillCombo(cmbcompany, "Select * from tblcompany", "CompanyName", "ID");
            txtothers.Text = "NA";
            btnnew.Focus();
            EnabledFales();
        }
        private void btnget_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dg.CurrentRow;
            if (row != null)
            {
                id = row.Cells[0].Value.ToString();

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
                    
                    fname = Path.GetTempFileName();
                   
                    
                    btnsave.Text = "Update";
                    txtname.Focus();

                }
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtno.Text == "" || txtname.Text == "" || cmbcategory.Text == "" || cmbcompany.Text == "" || txtqty.Text == "" || txtprice.Text =="" ||txtothers.Text =="")
            {
                MessageBox.Show("Missing Fields");
                return;
            }

            db.ExecuteSqlQuery("Insert into  Product(ProductNo,ProductName,ProductCategory,Brand,Qty,Price,Others)Values('" + txtno.Text + "','" + txtname.Text + "','" + cmbcategory.Text + "','" + cmbcompany.Text + "','" + txtqty.Text + "','" + txtprice.Text+"','"+txtothers + "')");
            cleadata();

            btnnew.Focus();
            db.FillGridData(dg, "Select * from Product");

            MessageBox.Show("saved successfully");
            
          
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
                EnabledFales();
                btnupdate.Enabled = true;
                btndelete.Enabled = true;
                txtname.Focus();
            }
            catch { }
        }

        private void btndeleate_Click(object sender, EventArgs e)
        {
            //delete row
            DialogResult ans = MessageBox.Show("Do you want to delete selected row?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (ans == DialogResult.Yes)
            {
                String id = txtno.Text;
                int i = db.ExecuteCommand("delete from Product where ProductNo='" + id + "'");
                if (i == 0)
                    MessageBox.Show("Record is not found...");
                else
                    MessageBox.Show("Record is deleted successfully...");
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == " ")
                {
                    db.FillGridData(dg, "Select * from Product");
                    return;
                }
                if (cmbsearch.SelectedIndex == 0)
                {
                    db.FillGridData(dg, "Select *from Product where ProductNo=" + txtsearch.Text);
                }
                else if (cmbsearch.SelectedIndex == 1)
                {
                    db.FillGridData(dg, "Select * from Product where ProductName like'" + txtsearch.Text + "%'");
                }
                else
                {
                    db.FillGridData(dg, "Select *from Product where ProductCategory like'" + txtsearch.Text + "%'");
                }

            }
            catch { }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtname.Focus();
            btnsave.Enabled = true;
            GetmaxID();

        }
        void GetmaxID()
        {
            txtno.Text = db.GetAutoId("Select Max(ProductNo) from Product").ToString();
        }
        void Cleardata()
        {
            cmbsearch.SelectedValue = 0;
            cmbcategory.SelectedValue = 0;
            cmbcompany.SelectedValue = 0;

            txtsearch.Clear();
        }
        void EnabledFales()
        {
            btnsave.Enabled = false;
            btnupdate.Enabled = false;
           
            btnclose.Enabled = true;

        }
        void cleadata()
        {
            txtno.Clear();
            txtname.Clear();
            txtqty.Clear();
            txtprice.Clear();
            txtothers.Clear();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtno.Text == "" || txtname.Text == "" || cmbcategory.Text == "" || cmbcompany.Text == "" || txtqty.Text == "" || txtprice.Text == "" || txtothers.Text == "")
            {
                MessageBox.Show("Missing Fields");
                return;
            }
            db.ExecuteSqlQuery("Update Product SET ProductName='" + txtname.Text + "',ProductCategory='" + cmbcategory.Text + "',Brand='" + cmbcompany.Text + "',Qty='" + txtqty.Text + "',Price='" + txtprice.Text + "' ,Others='" + txtothers.Text + "' where ProductNo=" + txtno.Text);
            db.FillGridData(dg, "Select * from Product");
            EnabledFales();
            cleadata();
            btnnew.Focus();
            MessageBox.Show("Update Data successfully");
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

        private void dg_MouseClick(object sender, MouseEventArgs e)
        {
            Griddisplay();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       
    }
}
