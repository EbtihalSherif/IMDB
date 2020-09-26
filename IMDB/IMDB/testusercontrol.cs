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
    public partial class testusercontrol : UserControl
    {
        public testusercontrol()
        {
            InitializeComponent();
        }

        private void testusercontrol_Load(object sender, EventArgs e)
        {
            OracleDataAdapter adapter;
            OracleCommandBuilder builder;
            DataSet ds;

            string constr = "Data Source=orcl ;User Id=scott;Password=tiger;";
            string cmdstr = "";

            //  cmdstr = "select * from movie";
            cmdstr = @" select movie.movie_name,movie.date_of_puplish , moviecategory.categoryname,movie.avg_rate,director.dir_name  from movie inner join director on movie.director_id = director.dir_id inner join moviecategory ON moviecategory.categoryid = movie.category_id ";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
