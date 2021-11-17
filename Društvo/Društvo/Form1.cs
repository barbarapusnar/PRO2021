using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Društvo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Darovi d = new Darovi();
            d.ZapŠt =int.Parse(txtZapŠt.Text);
            d.Datum = dtpDatum.Value;
            d.Namen = txtNamen.Text;
            d.Znesek = decimal.Parse(txtZnesek.Text);
            d.Opombe = txtOpombe.Text;
            //piši v binarno datoteko
            //odpri datoteko in dodaj na konec
            FileStream fs = new FileStream("Darovi.dat", FileMode.Append);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, d);
            fs.Close();
        }
    }
}
