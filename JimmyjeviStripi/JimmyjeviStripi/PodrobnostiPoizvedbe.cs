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
            List<Strip> Stripi = IzdelajKatalog();
            Dictionary<int, decimal> vrednosti = DobiCenik();
            var dragi = from c in Stripi
                        where vrednosti[c.Številka] > 500
                        orderby vrednosti[c.Številka] descending
                        select c;
            foreach (var x in dragi)
            {
                TrenutnePoizvedbe.Add(new PoizvedbaStripov
                 ( x.Ime + " " + vrednosti[x.Številka],
                 "","",
                 UstvariSliko("captain_amazing_250x250.jpg"))) ;
            }
        }
        List<Strip> IzdelajKatalog()
        {
            return new List<Strip>
            {
                new Strip {Ime="Johnny America vs. the Pinko",Številka=6},
                new Strip {Ime="Rock and Roll",Številka=19},
                new Strip {Ime="Woman's Work" ,Številka=36},
                new Strip {Ime="Hippie Madness",Številka=57},
                new Strip {Ime="Reveange of the New Vawe Freak",Številka=68},
                new Strip {Ime="Black Monday",Številka=74},
                new Strip {Ime="Tribal Tatto madness",Številka=83},
                new Strip {Ime="The death of an object",Številka=97}
            };
        }
        static Dictionary<int, decimal> DobiCenik()
        {
            return new Dictionary<int, decimal>
                   {
                        {6,3600m},
                        {19,500m},
                        {36,650m},
                        {57,13525m},
                        {68,250m},
                        {74,75m},
                        {83,25.75m},
                        {97,35.25m}
                    };
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
