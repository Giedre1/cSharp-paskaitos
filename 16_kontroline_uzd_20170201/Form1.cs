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
    public partial class Form1 : Form
    {
        public Pasaulis pasaulis { get; private set; } = new Pasaulis();
        public Form1()
        {
            InitializeComponent();
        }

        private void atidarytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var failoPasirinkimas = new OpenFileDialog();
            failoPasirinkimas.Filter = "csv failai (*.csv)|*.csv";
            failoPasirinkimas.Multiselect = true;

            if (failoPasirinkimas.ShowDialog() == DialogResult.OK)
            {
                foreach (var failas in failoPasirinkimas.FileNames)
                {
                    var salis = new Salis(failas);
                    pasaulis.SaliuSarasas.Add(salis);

                    var skirtukas = new TabPage(String.Format("{0} ({1})", salis.Pavadinimas, salis.Zemynas));
                    tabControl1.Controls.Add(skirtukas);

                    skirtukas.Controls.Add(new DataGridView()
                    {
                        Dock = DockStyle.Fill,
                        DataSource = pasaulis.SaliuSarasas.Last().MiestuSarasas
                    });

                }
            }
        }

        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void skaičiavimaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new SkaiciavimoForma(pasaulis);
            forma.ShowDialog();
        }
    }
}
