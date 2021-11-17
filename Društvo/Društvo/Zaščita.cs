using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Društvo
{
    public partial class Zaščita : Form
    {
        string pot = Resource1.pot;
        List<Darovi> spremembe = new List<Darovi>();
        public Zaščita()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            }
            catch (Exception) { }//vse ostale napake
            //zapiš vse podatke v xml datoteko
            string ime = "Darovi" + DateTime.Now.ToShortDateString() + ".xml";
            FileStream fs1 = new FileStream(ime, FileMode.Create);
            XmlSerializer s = new XmlSerializer(typeof(List<Darovi>));
            s.Serialize(fs1, spremembe);
            fs1.Close();
            MessageBox.Show("Zaščiteno");
        }
    }
}
