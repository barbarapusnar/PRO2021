using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestSeznama
{
    public partial class Form1 : Form
    {
        ArrayList a = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            a.Add(txtVnos.Text);
            txtKonzola.Text = "Dodan k seznamu nov element " + txtVnos.Text;
            txtVnos.Text = "";
            txtVnos.Focus();
        }

        private void btnIzpis_Click(object sender, EventArgs e)
        {
            txtKonzola.Text = "Elementi seznama:"+Environment.NewLine;
            //for (int k = 0; k < a.Count; k++)
            //{
            //    txtKonzola.Text += a[k]+Environment.NewLine;
            //}
            foreach (string x in a)
            {
                txtKonzola.Text += x+ Environment.NewLine;
            }
        }
    }
}
