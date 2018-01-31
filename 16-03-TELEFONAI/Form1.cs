using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16_03_TELEFONAI
{
    public partial class Form1 : Form
    {
        public List<Telefonas> Telefonai { get; private set; } // = new List<Telefonas>(); - deklaracija

        public Form1()
        {
            InitializeComponent();
            Telefonai = new List<Telefonas>();  // įsirašome į konstruktorių  - inicializacija
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void baigtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nuskaitytiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var failoPasirinkimoLangas = new OpenFileDialog())
            {
                failoPasirinkimoLangas.Filter = "csv failai (*.csv) | *.csv"; // kaireje mums, desineje c#

                if (failoPasirinkimoLangas.ShowDialog() == DialogResult.OK) ;
                {
                    // MessageBox.Show(failoPasirinkimoLangas.FileName); - cia ateiciai, kad pasitikrinti failo kelia
                    // nuskaitinejimas

                    using (var skaitytuvas = new System.IO.StreamReader
                        (failoPasirinkimoLangas.FileName))
                    {
                        string eilute;
                        var eil = 0;

                        while ((eilute = skaitytuvas.ReadLine()) != null)
                        {
                            // MessageBox.Show(eilute);

                            if (eil == 0)
                            {
                                eil++;
                                continue; // soka i while pradzia
                            }
                       
                            var telefonas = new Telefonas(eilute);
                            Telefonai.Add(telefonas);
                        }

                        dataGridView1.DataSource = Telefonai;
                    }

                }
            }
        }

        private void skaičiavimaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var forma = new Skaiciavimai(Telefonai);
            forma.ShowDialog();
        }
    }
}
