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
    public partial class RATE : UserControl
    {
       // string ordb = "Data source=orcl;User Id=scott; Password=tiger;";
        //OracleConnection conn;
        public RATE()
        {
            InitializeComponent();
        }
        public RATE(string name, string rate, string date)
        {
            InitializeComponent();
            ltitle.Text = name;
            lrate.Text = rate;
            lyear.Text = date;
        }

        private void RATE_Load(object sender, EventArgs e)
        {
            paneltemp.Visible = false;

        }

        private void MOREBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.con = new OracleConnection(Form1.ordb);
                Form1.con.Open();
                String movie_name = ltitle.Text;
              //  MessageBox.Show(movie_name);
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Form1.con;
                cmd.CommandText = "select movie.movie_name,movie.date_of_puplish , moviecategory.categoryname,movie.avg_rate,director.dir_name  from movie inner join director on movie.director_id = director.dir_id inner join moviecategory ON moviecategory.categoryid = movie.category_id  where movie.movie_name=:name"; cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("name", movie_name);
                OracleDataReader reader = cmd.ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    string name = reader[0].ToString();
                    string year = reader[1].ToString();
                    string category = reader[2].ToString();
                    string rate = reader[3].ToString();
                    string director = reader[4].ToString();
                    rate=Form1.get_avg_Rate(name);
                    if (rate == "null")
                        rate = "0";
                    Form1.update_rate(name, rate);

                    search s = new search(name, category, director, rate, year);
                    s.Visible = true;
                     s.Location = new Point(0, 490 * i + 5);
                    //s.Location = this.Location;
                    paneltemp.Controls.Add(s);
                    paneltemp.Visible = true;

                    paneltemp.BringToFront();
                    s.BringToFront();
                }
                reader.Close();
                Form1.con.Close();
            }
            catch (Exception ex)
            {                    MessageBox.Show(ex.Message);

                MessageBox.Show("NO MORE");
                Form1.con.Close();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
