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
    public partial class mainform : Form
    {
        User db = new User();
        public mainform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            custlist.Show();

        }

        private void custlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (custlist.Text == "Add Customer")
            {
                custentry ct = new custentry();
                ct.Show();
              //  this.Hide();
            }
            
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            emplist.Visible = false;
            custlist.Visible = false;
            chickenlist.Visible = false;
            expenselist.Visible = false;
            stocklist.Visible = false;
            reportlist.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            companyentry cm = new companyentry();
            cm.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            medicinentry mc = new medicinentry();
            mc.Show();
           // this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            feedentry fe = new feedentry();
            fe.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chickenlist.Show();
           
        }

        private void chickenlist_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (chickenlist.Text == "waste sale")
            {
                wastesale wa = new wastesale();
                wa.Show();
                //this.Hide();
            }
            if (chickenlist.Text == "Birdcost")
            {
                Birdcost br = new Birdcost();
                br.Show();
                //this.Hide();
            }
            if (chickenlist.Text == "Purchase")
            {
                Purchaseentry pe = new Purchaseentry();
                pe.Show();
            //  this.Hide();
            }
            if (chickenlist.Text == "FCR")
            {
                Fcr fc = new Fcr();
                fc.Show();
               // this.Hide();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            expenselist.Show();
        }

        private void expenselist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (expenselist.Text == "Add Expenses")
            {
                expensentry ex = new expensentry();
                ex.Show();
               // this.Hide();
            }
            if (expenselist.Text == "Expense Category")
            {
                expensecategory ec = new expensecategory();
                ec.Show();
               // this.Hide();
            }
            
        }

        private void banklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (emplist.Text == "Employee Entry")
            {
                Empentry ep = new Empentry();
                ep.Show();
                // this.Hide();
            }
            if (emplist.Text == "Employee Payment")
            {
                Emppayment em = new Emppayment();
                em.Show();
                // this.Hide();
            }
        }

        private void btnbank_Click(object sender, EventArgs e)
        {
            emplist.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            
            Form1 fo = new Form1();

            fo.Show();
        }

        private void stocklist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stocklist.Text == "Available stock")
            {
                availablestock av = new availablestock();
                av.Show();
             //  this.Hide();
            }
            if (stocklist.Text == "Dead stock")
            {
                deadstock ds = new deadstock();
                ds.Show();
               
              //  this.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            stocklist.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Productbilling pb = new Productbilling();
            pb.Show();
           // this.Hide();
        }

        private void btnexit_Click_1(object sender, EventArgs e)
        {
            Form1 fo = new Form1();
            fo.Show();
            
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            reportlist.Show();
        }

        private void reportlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (reportlist.Text == "CompanyReport")
            {
                CompanyReport cr = new CompanyReport();
                cr.Show();
                //  this.Hide();
            }
            if (reportlist.Text == "MedicieneentryReport")
            {
                MedicineentryReport mr = new MedicineentryReport();
                mr.Show();
                //  this.Hide();
            }
            if (reportlist.Text == "customerReport")
            {
                customerReport ct = new customerReport();
                ct.Show();
                //  this.Hide();
            }
            if (reportlist.Text == "feedReport")
            {
                feedReport f = new feedReport();
                f.Show();
                //  this.Hide();
            }
            if (reportlist.Text == "expenseReport")
            {
                expenseReport ep = new expenseReport();
                ep.Show();
                //  this.Hide();
            }
            if (reportlist.Text == "deadReport")
            {
                deadReport d = new deadReport();
                d.Show();
                //  this.Hide();
            }
            if (reportlist.Text == "productReport")
            {
                productReport p = new productReport();
                p.Show();
                //  this.Hide();
            }
            if (reportlist.Text == "purchaseReport")
            {
                purchaseReport pc = new purchaseReport();
                pc.Show();
                //  this.Hide();
            }
             if (reportlist.Text == "billingReport")
            {
                billingReport b = new billingReport();
                b.Show();
                //  this.Hide();
             }
                  if (reportlist.Text == "EmployeeReport")
            {
               EmployeeReport l = new EmployeeReport();
                l.Show();
                //  this.Hide();
                  }
                       if (reportlist.Text == "EmppayReport")
            {
                EmppayReport y = new EmppayReport();
                y.Show();
                //  this.Hide();
                       }
                       if (reportlist.Text == "wasteReport")
                       {
                           wasteReport w = new wasteReport();
                           w.Show();
                           //  this.Hide();
                       }
        }
    }
}
