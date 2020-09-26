using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace IMDB
{
    public partial class manage : Form
    {
        OracleDataAdapter adaptermanage;
        OracleCommandBuilder buildermanage;
        DataSet manager;

        public manage()
        {
            InitializeComponent();
        }

        private void manage_Load(object sender, EventArgs e)
        {

        }

        private void btn_Actor_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl ;User Id=scott;Password=tiger;";
            string cmdstr = "select * from actor";

            adaptermanage = new OracleDataAdapter(cmdstr, constr);
            manager = new DataSet();
            adaptermanage.Fill(manager);
            dataGridView1.DataSource = manager.Tables[0];
        }

        private void btn_dir_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=orcl ;User Id=scott;Password=tiger;";
            string cmdstr = "select * from director";

            adaptermanage = new OracleDataAdapter(cmdstr, constr);
            manager = new DataSet();
            adaptermanage.Fill(manager);
            dataGridView1.DataSource = manager.Tables[0];
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            buildermanage = new OracleCommandBuilder(adaptermanage);
            adaptermanage.Update(manager.Tables[0]);
            MessageBox.Show("update successfully");
            dataGridView1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
