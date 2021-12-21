using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace BranjaDatoteke
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Podatki> vsiPodatki = new List<Podatki>();
        CollectionViewSource podatkiViewSource;
        public MainWindow()
        {
            InitializeComponent();
            podatkiViewSource = (CollectionViewSource)(FindResource("podatkiViewSource"));
            StreamReader sr = new StreamReader(@"d:\Pro2021\vaja.csv");
            string vrstica = sr.ReadLine();//glave
            vrstica = sr.ReadLine();
            while (vrstica != null)
            {
                string[] p = vrstica.Split(';');
                Podatki novi = new Podatki();
                novi.Id = int.Parse(p[0]);
                novi.Datum = DateTime.Parse(p[1]);
                novi.Ime = p[2];
                novi.Znesek = double.Parse(p[3]);
                vsiPodatki.Add(novi);
                vrstica = sr.ReadLine();
            }
            sr.Close();
            DataContext = this;
            podatkiViewSource.Source = vsiPodatki;
        }
    }
}
