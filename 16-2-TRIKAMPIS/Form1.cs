using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_2_TRIKAMPIS
{
    public partial class FormTrikampioPlotas : Form
    {
        public FormTrikampioPlotas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var krastine1 = Convert.ToInt32(textBoxReiksme1.Text);
            var krastine2 = Convert.ToInt32(textBoxReiksme2.Text);
            var plotas = ((double)krastine1 * krastine1) * (double)krastine2* krastine2)


        }
    }
}
