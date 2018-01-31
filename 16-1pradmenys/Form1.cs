using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_1pradmenys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMygtukas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Labas");
        }

        private void buttonGautiReiksme_Click(object sender, EventArgs e)
        {
            var reiksme = textBoxReiksme.Text;
            labelReiksme.Text = reiksme;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var forma = new InformacijosLangas();
            forma.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var reiksme = textBoxSiusti.Text;
            var forma = new SkaiciavimuForma(reiksme);
            forma.ShowDialog();
        }

        private void buttonIvedimas_Click(object sender, EventArgs e)
        {
            using (var forma = new IvedimoForma())
            {
                forma.ShowDialog();

                if (forma.DialogResult == DialogResult.OK)
                {
                    var zodis = forma.Zodis;
                    labelIvedimas.Text = zodis;
                }
            }
        }

        private void labelIsvedimas_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSiusti_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
