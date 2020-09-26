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
    public partial class search : UserControl
    {
        //OracleConnection conn;
        // string ordb = "data source = orcl; user id =scott; password=tiger;";
        public search()
        {
            InitializeComponent();
        }

        public search(string name, string category, string director, string rate, string date)
        {
            InitializeComponent();
            ltitle.Text = name;
            lgenre.Text = category;
            ldirector.Text = director;
            lrate.Text = rate;
            lyear.Text = date;
        }

        private void bunifuCustomTextbox1_MouseEnter(object sender, EventArgs e)
        {
            if (reviewTxt.Text == "write your review...")
            {
                reviewTxt.Text = "";
                reviewTxt.ForeColor = Color.Black;
            }
        }

        private void bunifuCustomTextbox1_MouseLeave(object sender, EventArgs e)
        {
            if (reviewTxt.Text == "")
            {
                reviewTxt.Text = "write your review...";
                reviewTxt.ForeColor = Color.DarkGray;
            }
        }

        private void director_Click(object sender, EventArgs e)
        {

        }

        private void search_Load(object sender, EventArgs e)
        {

        }

        private void reviewTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Form1.userID.ToString() == "")
                    MessageBox.Show("please login first");
                else
                {
                    try
                    {
                        Form1.con = new OracleConnection(Form1.ordb);
                        Form1.con.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = Form1.con;
                        cmd.CommandText = "INSERT_REVIEW";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("U_ID", Form1.userID);
                        cmd.Parameters.Add("M_NAME", ltitle.Text);
                        cmd.Parameters.Add("REVIEW", reviewTxt.Text);
                        OracleDataReader dr = cmd.ExecuteReader();

                        MessageBox.Show("REVIEW ADDED");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SORRY , YOU ALREADY ADDED ONE ! ");
                    }
                    finally
                    {
                        Form1.con.Close();
                    }
                }
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (Form1.userID == 0)
            {
                MessageBox.Show("Please Login first");
            }
            else
            {

                Form1.con = new OracleConnection(Form1.ordb);
                OracleCommand cmd = new OracleCommand();
                try
                {
                    Form1.con.Open();


                    cmd.Connection = Form1.con;
                    cmd.CommandText = "Insert into USER_RATE Values (:USER_ID,:MOVIE_NAME,:RATE_NUMBER)";
                    cmd.Parameters.Add("USER_ID", Form1.userID);
                    cmd.Parameters.Add("MOVIE_NAME", ltitle.Text);
                    cmd.Parameters.Add("RATE_NUMBER", stars.Value);
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                        MessageBox.Show("Thank you for your Rate");
                }
                catch
                {
                    cmd = new OracleCommand();
                    cmd.Connection = Form1.con;
                    cmd.CommandText = "Update USER_RATE SET RATE_NUMBER=:RATE_NUMBER where USER_ID=:USER_ID and MOVIE_NAME=:MOVIE_NAME";
                    cmd.Parameters.Add("RATE_NUMBER", stars.Value);
                    cmd.Parameters.Add("USER_ID", Form1.userID);
                    cmd.Parameters.Add("MOVIE_NAME", ltitle.Text);
                    int r = cmd.ExecuteNonQuery();
                    if (r != -1)
                        MessageBox.Show("Thank you for your Rate");
                }
                finally
                {
                    Form1.con.Close();
                }
            }
        }
    }
}
