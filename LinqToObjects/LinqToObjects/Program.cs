using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    class Program
    {

        static void Main(string[] args)
        {
            var kupci = new[]{
        new {KupecID=1,Ime="Janez",Priimek="Kranjski",Podjetje="Kolo"},
        new {KupecID=2,Ime="Miha",Priimek="Polanc",Podjetje="Djak"},
        new {KupecID=3,Ime="Gašper",Priimek="Rupnik",Podjetje="Fitnes"},
        new {KupecID=4,Ime="Martin",Priimek="Bolčina",Podjetje="Kolo"},
        new {KupecID=5,Ime="Alenka",Priimek="Puncer",Podjetje="Kolo"},
        new {KupecID=6,Ime="Mojca",Priimek="Širok",Podjetje="Djak"},
        new {KupecID=7,Ime="Peter",Priimek="Gulin",Podjetje="Djak"},
        new {KupecID=8,Ime="Pavel",Priimek="Gantar",Podjetje="Inn"},
        new {KupecID=9,Ime="David",Priimek="Niven",Podjetje="Inn"},
        new {KupecID=10,Ime="Erik",Priimek="Kompara",Podjetje="Fitnes"}
        };
            var podjetja = new[] {
            new {ImePodjetja="Kolo",Mesto="Nova Gorica",Država="Slovenija"},
            new {ImePodjetja="Djak",Mesto="Nova Gorica",Država="Slovenija"},
            new {ImePodjetja="Fitnes",Mesto="Ljubljana",Država="Slovenija"},
            new {ImePodjetja="Inn",Mesto="Trst",Država="Italija"} };
            //grupiraj kupce po podjetjih
            var x = from a in kupci
                    group a by a.Podjetje into p
                    select p;
            foreach (var y1 in x)
            {
                Console.WriteLine("Podjetje "+y1.Key);
                foreach (var y2 in y1)
                {
                    Console.WriteLine("\t"+y2.Ime+" "+y2.Priimek);
                }
            }
            Console.ReadLine();
        }

        private static List<Naročilo> setupNaročila()
        {
            List<Naročilo> NaročiloList = new List<Naročilo>();

            Naročilo o1 = new Naročilo();
            o1.Datum = DateTime.Parse("12.7.2010");
            o1.NaročiloID = 9009;
            PodrobnostiNaročila oi1 = new PodrobnostiNaročila();
            oi1.ElementID = 123; oi1.ImeIzdelka = "Mars"; oi1.Količina = 2;
            o1.Elementi.Add(oi1);
            PodrobnostiNaročila oi2 = new PodrobnostiNaročila();
            oi2.ElementID = 124; oi2.ImeIzdelka = "Kraš"; oi2.Količina = 3;
            o1.Elementi.Add(oi2);
            Naročilo o2 = new Naročilo();
            o2.Datum = DateTime.Parse("12.1.2011");
            o2.NaročiloID = 9010;
            PodrobnostiNaročila oi3 = new PodrobnostiNaročila();
            oi3.ElementID = 125; oi3.ImeIzdelka = "Mars"; oi3.Količina = 1;
            o2.Elementi.Add(oi3);
            PodrobnostiNaročila oi4 = new PodrobnostiNaročila();
            oi4.ElementID = 126; oi4.ImeIzdelka = "Extreme"; oi4.Količina = 5;
            o2.Elementi.Add(oi4);
            PodrobnostiNaročila oi5 = new PodrobnostiNaročila();
            oi5.ElementID = 127; oi5.ImeIzdelka = "Bazooka"; oi5.Količina = 1;
            o2.Elementi.Add(oi5);
            PodrobnostiNaročila oi6 = new PodrobnostiNaročila();
            oi6.ElementID = 128; oi6.ImeIzdelka = "Sadje"; oi6.Količina = 6;
            o2.Elementi.Add(oi6);
            NaročiloList.Add(o1);
            NaročiloList.Add(o2);
            return NaročiloList;
        }
    }
}
