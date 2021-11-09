using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgranjeKart
{
    class Kup
    {
        List<Karta> karte;
        Random r = new Random();
        //konstruktor, v katerem napolniš kup vseh 52 kart
        public Kup()
        {
            karte = new List<Karta>();
            for (int b = 1; b <= 4; b++)
            {
                for (int v = 1; v <= 13; v++)
                {
                    karte.Add(new Karta((Vrednosti)v,(Barve)b));
                }
            }
        }
        //kup v katerem naploniš samo določene
        public Kup(IEnumerable<Karta> začetek) //IEnumerable omogoča uporabo foreach
        {
            karte = new List<Karta>(začetek);
        }
        public void Add(Karta nova)
        {
            karte.Add(nova);
        }
        public int Count
        {
            get { return karte.Count; }
        }
        public void Sort()
        {
            karte.Sort(new Primerjava());
        }
        public void Mešaj()
        {
            List<Karta> noveKarte = new List<Karta>();
            while (karte.Count > 0)
            {
                int zaPremik = r.Next(karte.Count);
                noveKarte.Add(karte[zaPremik]);
                karte.RemoveAt(zaPremik);
            }
            karte = noveKarte;
        }
        public Karta Deli(int indeks)
        {
            Karta zaDelitev = karte[indeks];
            karte.RemoveAt(indeks); //vzemi karto ven iz kupa
            return zaDelitev;
        }
        //tabela vseh imen kart
        public IEnumerable<string> ImenaKart()
        {
            string[] imena = new string[karte.Count];
            for (int k = 0; k < karte.Count; k++)
                imena[k] = karte[k].Ime;
            return imena;
        }
    }
}
