using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace JimmyjeviStripi
{
    class PoizvedbaStripov
    {
        public string Naslov { get; set; }
        public string Podnaslov { get; set; }
        public string Opis { get; set; }
        public BitmapImage Slika { get; set; }
        public PoizvedbaStripov(string n,string p,string o,BitmapImage i)
        {
            Naslov = n;
            Podnaslov = p;
            Opis = o;
            Slika = i;
        }
    }
}
