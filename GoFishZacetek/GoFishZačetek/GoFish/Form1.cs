using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoFish
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Igra igra;

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtIme.Text))
            {
                MessageBox.Show("Vnesi svoje ime", "Ne morem še začeti");
                return;
            }
            igra = new Igra(txtIme.Text, new List<string> { "Pepi", "Maša" }, txtIgra);
            buttonStart.Enabled = false;
            txtIme.Enabled = false;
            buttonAsk.Enabled = true;
            UpdateForm();
        }

        private void UpdateForm()
        {
            lstVRokah.Items.Clear();
            foreach (String cardName in igra.KarteIgralca())
                lstVRokah.Items.Add(cardName);
            txtKompleti.Text = igra.OpišiKomplete();
            txtIgra.Text += igra.OpišiVRokah();
            txtIgra.SelectionStart = txtIgra.Text.Length;
            txtIgra.ScrollToCaret();
        }

        private void buttonAsk_Click(object sender, EventArgs e)
        {
            txtIgra.Text = "";
            if (lstVRokah.SelectedIndex < 0)
            {
                MessageBox.Show("Prosim izberi karto");
                return;
            }
            if (igra.IgrajEnKrog(lstVRokah.SelectedIndex))
            {
                txtIgra.Text += "Zmagovalec je... " + igra.ImeZmagovalca();
                txtKompleti.Text = igra.OpišiKomplete();
                buttonAsk.Enabled = false;
            }
            else
                UpdateForm();
        }
    }

}
