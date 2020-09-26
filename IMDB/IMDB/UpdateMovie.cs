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
    public partial class UpdateMovie : UserControl
    {
        OracleConnection conn;
        string ordb = "data source = orcl; user id =scott; password=tiger;";
        public UpdateMovie()
        {
            InitializeComponent();
        }

        private void find_Click(object sender, EventArgs e)
        {
            try
            {
              
                conn = new OracleConnection(ordb);
                conn.Open();
                
                conn = new OracleConnection(ordb);

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = " select movie.* , moviecategory.categoryname from movie inner join moviecategory on movie.category_id=moviecategory.categoryid where movie_name= :name";
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Add("name", NameTxt.Text.ToString());
                conn.Open();
                OracleDataReader reader = cmd.ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    
                     YearTxt.Text = reader[1].ToString();
                    choosetype.Text = reader[6].ToString();
                     rateTxt.Text = reader[5].ToString();
                     directorTxt.Text = reader[2].ToString();
                     if (rateTxt.Text == "")
                         rateTxt.Text = "0";
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                OracleCommand cmd = new OracleCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "update movie set  date_of_puplish =:d, director_id= :dir_id, category_id= (select categoryid from moviecategory where categoryname=:cate_name) , avg_rate=:rate where movie_name= :n";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("d", YearTxt.Text);
                cmd.Parameters.Add("dir_id", directorTxt.Text);
                cmd.Parameters.Add("cate_name", (choosetype.Text.ToString()));
                cmd.Parameters.Add("rate", rateTxt.Text);
                cmd.Parameters.Add("n", NameTxt.Text);






                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                    MessageBox.Show("Done!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
