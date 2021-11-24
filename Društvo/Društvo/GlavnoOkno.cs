using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Društvo
{
    public partial class GlavnoOkno : Form
    {
        public GlavnoOkno()
        {
            InitializeComponent();
        }

        private void vnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.MdiParent = this;
            a.Show();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pregled a = new Pregled();
            a.MdiParent = this;
            a.Show();
        }

        private void zapišiPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zaščita a = new Zaščita();
            a.MdiParent = this;
            a.Show();
        }

        private void obnoviPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Obnova a = new Obnova();
            a.MdiParent = this;
            a.Show();
        }

        private void tiskanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tiskanje a = new Tiskanje();
            a.MdiParent = this;
            a.Show();
        }
    }
}
