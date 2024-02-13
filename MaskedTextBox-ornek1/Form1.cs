using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBox_ornek1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MskTC.Mask = "00000000000";
            MskTelefon.Mask = "(999) 000 00 00";
            mskDTarih.Mask = "00/00/0000";
            MskKatNo.Mask = "0000-0000-0000-0000";
            MskAdres.Mask = "###.###.###.###";
        }
    }
}
