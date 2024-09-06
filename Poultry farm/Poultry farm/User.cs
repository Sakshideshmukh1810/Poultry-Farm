using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;


namespace Poultry_farm
{
    class User
    {
        public SqlConnection cn;
       

        public User()
        {
           cn =new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Deshmukh\Desktop\Poultry Farm\Poultry farm\Poultry farm\Database1.mdf;Integrated Security=True;User Instance=True");
               cn.Open();
        
    }
        public DataTable GettableData(string sql)
        {
            SqlDataAdapter da=new SqlDataAdapter(sql,cn);
            DataTable dt=new DataTable();
            da.Fill(dt);
            return dt;

        }
        public int ExecuteCommand(string sqlcommand) //Execute Insert,Update and Delete command
        {
            
            SqlCommand cmd = new SqlCommand(sqlcommand, cn);
            int nrows = cmd.ExecuteNonQuery();
            
            return nrows; //returns no of rows affected
        }
        //Execute Parameterized Commands
        //Execute("Insert into stud values(@roll,@name,@address",obj);
        public int Execute(string sqlcommand, Dictionary<string, object> obj)
        {
            
            SqlCommand cmd = new SqlCommand(sqlcommand, cn);
            foreach (string key in obj.Keys)
            {
                cmd.Parameters.AddWithValue(key, obj[key]);
            }
            int nrows = cmd.ExecuteNonQuery();
            
            return nrows; //returns no of rows affected
        }
        public int GetAutoId(string sql)
        {
            int i=1;
            
            try
            {
                DataTable dt=GettableData(sql);
                if(dt.Rows.Count >=1)
                {
                    i=(int.Parse(dt.Rows[0][0].ToString())+1);
                }
                else
                    i=1;
            }
            catch {
                i=1;
            }

            return i;
        }
        public void ExecuteSqlQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public void FillGridData(DataGridView dv, string sql)
        {
            DataTable dt = GettableData(sql);
            dv.DataSource = dt;
        }
    
        public void FillCombo(ComboBox cb,string sql,string dismemb,string val)
        {
            DataTable dt=GettableData(sql);

            cb.ValueMember =val;
            cb.DisplayMember=dismemb;
            cb.DataSource=dt;
            
}
        public void UpdateID(String field)
        {
           
            ExecuteCommand(string.Format("Update PK set {0}={0}+1", field));
            


        }
        
    }
}
