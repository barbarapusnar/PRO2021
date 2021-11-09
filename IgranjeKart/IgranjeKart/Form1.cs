using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgranjeKart
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //vrednost je naključno število med 1 in 12, barva je naključno število
            //med 1 in 4
            Karta k = new Karta((Vrednosti)r.Next(1, 14), (Barve)r.Next(1, 5));
            MessageBox.Show(k.Ime);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //generiraj 5 naključnih kart
            string rezultat = "";
            List<Karta> kup = new List<Karta>();
            for (int k = 0; k < 5; k++)
            {
                Karta karta = 
                    new Karta((Vrednosti)r.Next(1, 14), (Barve)r.Next(1, 5));
                kup.Add(karta);
                rezultat += karta.Ime + Environment.NewLine;
            }
            //uredi kup kart
            kup.Sort(new Primerjava());
            rezultat += "Urejen kup" + Environment.NewLine;
            foreach (Karta x in kup)
            {
                rezultat += x.Ime + Environment.NewLine;
            }
            MessageBox.Show(rezultat);
        }
    }
}
