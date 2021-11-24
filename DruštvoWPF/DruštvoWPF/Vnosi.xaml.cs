using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DruštvoWPF
{
    /// <summary>
    /// Interaction logic for Vnosi.xaml
    /// </summary>
    public partial class Vnosi : Window
    {
        string pot = Resource1.pot;
        public Vnosi()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Darovi d = new Darovi();
                d.ZapŠt = int.Parse(txtZapŠt.Text);

                d.Datum = dtpDatum.SelectedDate.Value;
                d.Namen = txtNamen.Text;

                d.Znesek = decimal.Parse(txtZnesek.Text);

                //d.Opombe = txtOpombe.Text;
                //piši v binarno datoteko
                //odpri datoteko in dodaj na konec
                FileStream fs = new FileStream(pot, FileMode.Append);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, d);
                fs.Close();
               // sbStatus.Text = "Zapisano";
                txtZapŠt.Clear(); txtZnesek.Clear(); txtNamen.Clear();
               // txtOpombe.Clear();
                txtZapŠt.Focus();
            }
            catch (FormatException)
            {
                //sbStatus.Text = "Napaka";
            }
        }
    }
}
