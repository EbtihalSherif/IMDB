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
    public partial class Recommend : UserControl
    {
        private int image_num = 1;
        public Recommend()
        {
            InitializeComponent();
        }

        private void Recommend_Load(object sender, EventArgs e)
        {
            
        }
        private void load_image1()
        {
            if (image_num == 10)
            {
                image_num = 1;

            }
            pictureBox2.ImageLocation = string.Format(@"image2\{0}.jpg", image_num);
            image_num++;
        }
        private void load_image2()
        {
            if (image_num == 10)
            {
                image_num = 1;

            }
            pictureBox3.ImageLocation = string.Format(@"image\{0}.jpg", image_num);
            image_num++;
        }
        private void load_image3()
        {
            if (image_num == 10)
            {
                image_num = 1;

            }
            pictureBox4.ImageLocation = string.Format(@"image3\{0}.jpg", image_num);
            image_num++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            load_image1();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            load_image2();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            load_image3();
        }
    }
}
