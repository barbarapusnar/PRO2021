using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace JimmyjeviStripi
{
    class PoizvedbaManager
    {
        //v razredu opišem poizvedbe, ki so na razpolago
        public string Naslov { get; set; }
        public ObservableCollection<PoizvedbaStripov> DostopnePoizvedbe 
        { get; set; }
        public PoizvedbaManager()
        {
            Posodobi();
            Naslov = "Dostopne poizvedbe";
        }

        private void Posodobi()
        {
            DostopnePoizvedbe = new ObservableCollection<PoizvedbaStripov>();
            DostopnePoizvedbe.Add(
                new PoizvedbaStripov("Z LINQ so poizvedbe lahke",
                "Vzorčna poizvedba", "Pokažimo Jimmyju kako je lahko",
                UstvariSliko("bluegray_250x250.jpg"))
                );
            DostopnePoizvedbe.Add(
               new PoizvedbaStripov("Najdražji stripi",
               "Stripi nad 500$", "Kateri so najdrajžji stripi nad 500$",
               UstvariSliko("captain_amazing_250x250.jpg"))
               );
            DostopnePoizvedbe.Add(
              new PoizvedbaStripov("Ostale poizvedbe",
              "Nekaj zanimivosti", "Bla bla bla bla bla",
              UstvariSliko("bluegray_250x250.jpg"))
              );
        }

        private BitmapImage UstvariSliko(string v)
        {
            return new BitmapImage(new Uri("ms-appx:///Assets/" + v));
        }
    }
}
