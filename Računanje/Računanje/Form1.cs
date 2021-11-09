using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Računanje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            Kompleksno prvo = new Kompleksno();
            prvo.Re =double.Parse(txtRe1.Text);
            prvo.Im = double.Parse(txtIm1.Text);
            Kompleksno drugo = new Kompleksno();
            drugo.Re = double.Parse(txtRe2.Text);
            drugo.Im = double.Parse(txtIm2.Text);
            label7.Text = prvo.ToString();
            label8.Text = drugo.ToString();
        }
    }
}
