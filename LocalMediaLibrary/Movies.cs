using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalMediaLibrary
{
    public partial class Movies : Form
    {
        private int index = 0;
        private List<Image> images;
        private List<String> descriptions;
        private List<String> outloc;
        public Movies()
        {
            InitializeComponent();
        }

        private void Lp1_Click(object sender, EventArgs e)
        {
            //run outloc[0];
        }

        private void Li1_Click(object sender, EventArgs e)
        {
            index = 0;
            Movies_Load(sender, e);
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            Cover.Image = images[index];
            Summary.Text = descriptions[index];
        }

        private void Li2_Click(object sender, EventArgs e)
        {
            index = 1;
            Movies_Load(sender, e);
        }

        private void Li3_Click(object sender, EventArgs e)
        {
            index = 2;
            Movies_Load(sender, e);
        }

        private void Li4_Click(object sender, EventArgs e)
        {
            index = 3;
            Movies_Load(sender, e);
        }

        private void Li5_Click(object sender, EventArgs e)
        {
            index = 4;
            Movies_Load(sender, e);
        }

        private void Li6_Click(object sender, EventArgs e)
        {
            index = 5;
            Movies_Load(sender, e);
        }

        private void Li7_Click(object sender, EventArgs e)
        {
            index = 6;
            Movies_Load(sender, e);
        }

        private void Li8_Click(object sender, EventArgs e)
        {
            index = 7;
            Movies_Load(sender, e);
        }

        private void Li9_Click(object sender, EventArgs e)
        {
            index = 8;
            Movies_Load(sender, e);
        }

        private void Li10_Click(object sender, EventArgs e)
        {
            index = 9;
            Movies_Load(sender, e);
        }

        private void Li11_Click(object sender, EventArgs e)
        {
            index = 10;
            Movies_Load(sender, e);
        }

        private void Lp2_Click(object sender, EventArgs e)
        {
            //run outloc[1];
        }

        private void Lp3_Click(object sender, EventArgs e)
        {
            //run outloc[2];
        }

        private void Lp4_Click(object sender, EventArgs e)
        {
            //run outloc[3];
        }

        private void Next_Click(object sender, EventArgs e)
        {

        }

        private void Previous_Click(object sender, EventArgs e)
        {

        }

        private void Tv_Click(object sender, EventArgs e)
        {
            // to tv
        }
    }
}
