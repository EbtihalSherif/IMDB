using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using Oracle.Database.Extensions;
namespace IMDB
{
    public partial class user_profile : UserControl
    {
        public user_profile()
        {
            InitializeComponent();
            Form1.con = new OracleConnection(Form1.ordb);
            Form1.con.Open();
           OracleCommand c = new OracleCommand();
            c.Connection = Form1.con;
            
            c.CommandText = "select USER_NAME,FIRST_NAME,SECOND_NAME,PASSWORD from IMDB_USER where USER_ID=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id",Form1.userID);
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                luname.Text = dr["USER_NAME"].ToString();
                lfname.Text = dr["FIRST_NAME"].ToString();
                llname.Text = dr["SECOND_NAME"].ToString();
                lpass.Text = dr["PASSWORD"].ToString();

            }
            dr.Close();
            Form1.con.Close();
            


        }

        private void ldirector_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void btn_deleteacc_Click(object sender, EventArgs e)
        {
            Form1.con = new OracleConnection(Form1.ordb);
            Form1.con.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = Form1.con;
            c.CommandText = "delete from imdb_user where USER_ID=:id ";
            c.Parameters.Add("id", Form1.userID);
            int r = c.ExecuteNonQuery();
            if(r!=-1)
            {
                MessageBox.Show("user deleted");
                Form1.userID = 0;
                Form1.userName = "";
                this.Hide();
            }
            Form1.con.Close();
        }
    }
}
