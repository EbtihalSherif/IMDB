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
    public partial class DeleteMovie : UserControl
    {
        public DeleteMovie()
        {
            InitializeComponent();
        }

        private void DeleteMovie_Load(object sender, EventArgs e)
        {

        }

        private void TypeTxt_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection con;
                string ordb = "data source = orcl; user id =scott; password=tiger;";
                con = new OracleConnection(ordb);
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                con.Open();
                cmd.CommandText = "Deletemovie";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("Aname", NameTxt.Text);
                int r = cmd.ExecuteNonQuery();
              
                MessageBox.Show("Done!");
                con.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                    }


        }
    }
}
