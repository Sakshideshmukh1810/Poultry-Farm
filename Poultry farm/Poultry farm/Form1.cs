using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Poultry_farm
{
    public partial class Form1 : Form
    {
      
        User db;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        
            DataTable dt = db.GettableData("select * from  Logintable where Username='" + cmbname.Text + "'AND Password='" + txtpwd.Text + "'");
            if (dt.Rows[0]["Usertype"].ToString().Equals("admin"))
            {
                mainform fr = new mainform();

                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("please enter valid username and password...");
                // cledata();




            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new User();
            db.FillCombo(cmbname, "Select*from Logintable", "Username", "Usertype");

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
