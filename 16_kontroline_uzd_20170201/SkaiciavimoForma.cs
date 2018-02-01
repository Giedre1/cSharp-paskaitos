using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_kontroline_uzd_20170201
{
    public partial class SkaiciavimoForma : Form
    {
        public SkaiciavimoForma(Pasaulis pasaulis)
        { 
            InitializeComponent();
            //label1.Text = "Daugiausiai gyventojų:";
            label2.Text = pasaulis.DaugiausiaiGyventoju().Pavadinimas;
            textBox1.Text = pasaulis.DaugiausiaiGyventoju().GyventojuSkaicius.ToString();

            //label6.Text = "Mažiausiai gyventojų:";
            label5.Text = pasaulis.MaziausiaiGyventoju().Pavadinimas;
            textBox2.Text = pasaulis.MaziausiaiGyventoju().GyventojuSkaicius.ToString();

            //label7.Text = "Didžiausias plotas:";
            label9.Text = pasaulis.DidziausiasPlotas().Pavadinimas;
            textBox3.Text = pasaulis.DidziausiasPlotas().PlotasKvKm.ToString();

            //label8.Text = "Mažiausias plotas:";
            label10.Text = pasaulis.MaziausiasPlotas().Pavadinimas;
            textBox4.Text = pasaulis.MaziausiasPlotas().PlotasKvKm.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
