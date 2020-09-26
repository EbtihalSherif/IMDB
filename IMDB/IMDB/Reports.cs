using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace IMDB
{
    public partial class Reports : Form
    {
        CrystalReport1 CR;
        CrystalReport2 CR2;
        CrystalReport3 CR3;
        public Reports()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            try
            {
                CR = new CrystalReport1();
                CR2 = new CrystalReport2();
                foreach (ParameterDiscreteValue v in CR2.ParameterFields[0].DefaultValues)
                    comboBox1.Items.Add(v.Value);
                CR3 = new CrystalReport3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    


        private void btn_MoviesReports_Click(object sender, EventArgs e)
        {
            try
            {
                crystalReportViewer1.ReportSource = CR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                CR2.SetParameterValue(0, comboBox1.Text);
                crystalReportViewer1.ReportSource = CR2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // int avge = numericUpDown1.DecimalPlaces;
                CR3.SetParameterValue(0, textBox1.Text);
                crystalReportViewer1.ReportSource = CR3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
