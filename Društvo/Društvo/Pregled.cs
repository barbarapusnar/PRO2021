using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Društvo
{
    public partial class Pregled : Form
    {
        List<Darovi> spremembe = new List<Darovi>();
        string pot = Resource1.pot;
        int števecSpremeb = 0;
        public Pregled()
        {
            InitializeComponent();
        }

        private void Pregled_Load(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(pot, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Darovi d;
                try
                {
                    while (true)
                    {
                        d = (Darovi)bf.Deserialize(fs);
                        spremembe.Add(d);
                    }
                }
                catch (SerializationException) { } //konec datoteke
                fs.Close();
                dgwPodatki.DataSource = spremembe;
            }
            catch (Exception) { }//vse ostale napake
        }

        private void Pregled_Shown(object sender, EventArgs e)
        {
            PopraviObliko();
        }
        private void PopraviObliko()
        {
            DataGridViewCellStyle dcs = new DataGridViewCellStyle();
            dcs.Format = "##0.00 €";
            dgwPodatki.Columns[3].DefaultCellStyle = dcs;
            dgwPodatki.Columns[4].Width = 175;
            foreach (DataGridViewRow r in dgwPodatki.Rows)
            {
                double tip = double.Parse(r.Cells[3].Value.ToString()); //vrednost zneska
                if (tip < 0)
                {
                    r.DefaultCellStyle.BackColor = Color.LightPink;
                }
                else
                {
                    r.DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
            dgwPodatki.Refresh();

        }
        private void dgwPodatki_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int vrstica = e.RowIndex;
            int stolpec = e.ColumnIndex;
            Darovi d = new Darovi();
            d.ZapŠt = int.Parse(dgwPodatki.Rows[vrstica].Cells["ZapŠt"].Value.ToString());
            d.Datum = DateTime.Parse(dgwPodatki.Rows[vrstica].Cells["Datum"].Value.ToString());
            d.Namen = dgwPodatki.Rows[vrstica].Cells["Namen"].Value.ToString();
            d.Opombe = dgwPodatki.Rows[vrstica].Cells["Opombe"].Value.ToString();
            d.Znesek = decimal.Parse(dgwPodatki.Rows[vrstica].Cells["Znesek"].Value.ToString());
            spremembe[vrstica] = d;
            števecSpremeb++;
            PopraviObliko();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(pot, FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            foreach (Darovi d in spremembe)
                bf.Serialize(fs, d);
            fs.Close();
            števecSpremeb = 0;

        }

        private void Pregled_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (števecSpremeb != 0)
            {
                DialogResult x = MessageBox.Show("Ostajajo neshranjene spremembe.\nShranim sedaj",
                    "Shranjevanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (x == DialogResult.Yes)
                {
                    FileStream fs = new FileStream(pot, FileMode.Create);
                    BinaryFormatter bf = new BinaryFormatter();
                    foreach (Darovi d in spremembe)
                        bf.Serialize(fs, d);
                    fs.Close();
                    števecSpremeb = 0;
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Resnično želiš brisati vrstico", "Brisanje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (a == DialogResult.Yes)
            {
                DataGridViewRow vrstica = dgwPodatki.CurrentRow;
                int index = vrstica.Index;
                spremembe.RemoveAt(index);
                //na novo naloži dgwPodatki
                dgwPodatki.DataSource = null;
                dgwPodatki.Rows.Clear();
                dgwPodatki.DataSource = spremembe;
                PopraviObliko();
                števecSpremeb++;
            }
        }
    }
}
