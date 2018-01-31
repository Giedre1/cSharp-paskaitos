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
    public partial class SkaiciavimuForma : Form
    {
        public SkaiciavimuForma()
        {
            InitializeComponent();
        }

        public SkaiciavimuForma(string zodis)
        {
            InitializeComponent();
            label1.Text = zodis;
        }
    }
}
