﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;


namespace Poultry_farm
{
    public partial class EmppayReport : Form
    {
        public EmppayReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            Emppaydetail ep = new Emppaydetail();
            Poultry psPoultry = GetData();
            ep.SetDataSource(psPoultry);
            this.crystalReportViewer1.ReportSource = ep;
            this.crystalReportViewer1.RefreshReport();
        }
        private Poultry GetData()
        {
            string constr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from EmployeePayment"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (Poultry psPoultry = new Poultry())
                        {
                            sda.Fill(psPoultry, "EmployeePayment");
                            return psPoultry;
                        }
                    }
                }
            }
        }
    }
}
