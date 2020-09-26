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
namespace IMDB
{
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            /*if (s_inPanel.Left == 472)
            {
                s_upPanel.Visible = false;
                s_upPanel.Left = 472;

                s_inPanel.Visible = false;
                s_inPanel.Left = 21;
                s_inPanel.Visible = true;
                s_inPanel.Refresh();
            }*/
            s_upPanel.Visible=false;
            s_inPanel.Visible = true;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            /*  if (s_upPanel.Left == 472)
              {
                  s_inPanel.Visible = false;
                  s_inPanel.Left = 472;

                  s_upPanel.Visible = false;
                  s_upPanel.Left = 21;
                  s_upPanel.Visible = true;
                  s_upPanel.Refresh();
              }*/
            s_inPanel.Visible = false;
            s_upPanel.Visible = true;
        }

        private void signUpDone_Click(object sender, EventArgs e)
        {
            try
            {
              //  OracleConnection con;
                //string ordb = "data source = orcl; user id =scott; password=tiger;";
              Form1.con = new OracleConnection(Form1.ordb);
                Form1.con.Open();

                int maxId, NewId;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Form1.con;
                cmd.CommandText = "GetUserID";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                try
                {
                    maxId = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                    NewId = maxId + 1;
                }
                catch
                {
                    NewId = 1;
                }

                OracleCommand c = new OracleCommand();
                c.Connection = Form1.con;
                c.CommandText = "Insert_New_User";
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.Add("UID", NewId);
                c.Parameters.Add("FName", f_name.Text);
                c.Parameters.Add("LName", s_name.Text);
                c.Parameters.Add("Pass", upass.Text);
                c.Parameters.Add("UName", uname.Text);
                c.ExecuteNonQuery();
                Form1.userID = NewId;
                MessageBox.Show("user added ");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Already Signed UP Before");
            }
            finally
            {
                Form1.con.Close();
            }

        }

        private void signInDone_Click(object sender, EventArgs e)
        {
            Form1.con = new OracleConnection(Form1.ordb);
            try
            {
                Form1.con.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Form1.con;
                cmd.CommandText = "SignIn";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
                cmd.Parameters.Add("uname", usname.Text);
                cmd.Parameters.Add("upassword", uspass.Text);
                cmd.ExecuteNonQuery();

                Form1.userID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
              //  Form1.userName = usname.Text;
                MessageBox.Show("login successfully ^_^");
              
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("invalid user name or password");
            }
            finally
            {
                Form1.con.Close();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
