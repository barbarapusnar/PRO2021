using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace JimmyjeviStripi
{
    class PodrobnostiPoizvedbe
    {
        public string Naslov { get; set; }
        public ObservableCollection<PoizvedbaStripov> TrenutnePoizvedbe { get; set; }

        public PodrobnostiPoizvedbe()
        {
            TrenutnePoizvedbe = new ObservableCollection<PoizvedbaStripov>();
        }

        public void UpdateQueryResult(PoizvedbaStripov p)
        {
            Naslov = p.Naslov;
            switch (p.Naslov)
            {
                case "Z LINQ so poizvedbe lahke":
                    PrvaPoizvedba(); //metoda, ki napolni spremenljivko trenutne poizvedbe
                    break;
                case "Najdražji stripi":
                    DrugaPoizvedba();
                    break;
                case "Ostale poizvedbe":
                    TretjaPoizvedba();
                    break;
            }
        }
        private BitmapImage UstvariSliko(string v)
        {
            return new BitmapImage(new Uri("ms-appx:///Assets/" + v));
        }
        private void TretjaPoizvedba()
        {
            
        }

        private void DrugaPoizvedba()
        {
            
        }

        private void PrvaPoizvedba()
        {
            int[] vrednosti = { 0, 12, 44, 36, 92, 54, 13, 8 };
            var r = from x in vrednosti
                    where x < 37
                    orderby x
                    select x;
            foreach (var i in r)
            {
                TrenutnePoizvedbe.Add(
                    new PoizvedbaStripov(i.ToString(),"","",
                    UstvariSliko("bluegray_250x250.jpg"))
                    ) ;
            }
        }
    }
}
