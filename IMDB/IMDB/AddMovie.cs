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
    public partial class AddMovie : UserControl
    {
        OracleConnection conn;
        string ordb = "data source = orcl; user id =scott; password=tiger;";
        public AddMovie()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ordb);
                OracleCommand cmd = new OracleCommand();
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "insert into movie (movie_name, date_of_puplish, director_id, category_id, avg_rate) values ( :name , :d ,:dir_id, (select categoryid from moviecategory where categoryname=:cate_name ) ,:rate)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("name", nametxt.Text.ToString());
                
                cmd.Parameters.Add("d", YearTxt.Text.ToString());
               
                
                cmd.Parameters.Add("dir_id", Director.Text);
                
                cmd.Parameters.Add("cate_name", (chooseType.selectedValue).ToString());
                
                cmd.Parameters.Add("rate", rateTxt.Text);
               
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                    MessageBox.Show("Done!");
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
