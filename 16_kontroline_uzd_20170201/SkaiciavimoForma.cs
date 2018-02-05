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

            foreach (var salis in pasaulis.SaliuSarasas)
            {
                if (salis.Pavadinimas == "Lietuva") // vidutinio atlyginimo duomenis suvedžiau tik Lietuvos
                {
                    label17.Text = salis.Pavadinimas;
                    textBox7.Text = salis.VidutinisAtlyginimas().ToString("#.##");
                }
            }

            label2.Text = pasaulis.DaugiausiaiGyventoju().Pavadinimas;
            textBox1.Text = pasaulis.DaugiausiaiGyventoju().GyventojuSkaicius.ToString();

            label5.Text = pasaulis.MaziausiaiGyventoju().Pavadinimas;
            textBox2.Text = pasaulis.MaziausiaiGyventoju().GyventojuSkaicius.ToString();

            label9.Text = pasaulis.DidziausiasPlotas().Pavadinimas;
            textBox3.Text = pasaulis.DidziausiasPlotas().PlotasKvKm.ToString();

            label10.Text = pasaulis.MaziausiasPlotas().Pavadinimas;
            textBox4.Text = pasaulis.MaziausiasPlotas().PlotasKvKm.ToString();

            label13.Text = pasaulis.DidziausiasTankis().Pavadinimas;
            textBox5.Text = pasaulis.DidziausiasTankis().GyvTankis.ToString("#.##");

            label15.Text = pasaulis.MaziausiasTankis().Pavadinimas;
            textBox6.Text = pasaulis.MaziausiasTankis().GyvTankis.ToString("#.##");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
