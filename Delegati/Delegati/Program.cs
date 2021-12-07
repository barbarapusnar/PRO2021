using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati
{
    class Program
    {
        //1. definiramo delegatea
        public delegate bool FunkcijaZaNize(string s);
        //2. metoda, ki sprejme delegata kot parameter
        public static List<string> DelajOperacijeNadNizi(string[] nizi,FunkcijaZaNize mojFunkcija)
        {
            List<string> a = new List<string>();
            foreach (string x in nizi)
            {
                if (mojFunkcija(x))
                    a.Add(x);
            }
            return a;
        }
        //3. dodaj metode, ki ustrezajo delegatu
        public static bool ZačneZA(string s)
        {
            return s.StartsWith("A");
        }
        public static bool KončaZn(string s)
        {
            return s.EndsWith("n");
        }
        static void Main(string[] args)
        {
            string[] mojiNizi = { "Adam","Alan","Bob","Steve","Jim","Aiden",
                                  "Rob","Bill","Jacob","James"};
            List<string> aji = DelajOperacijeNadNizi(mojiNizi, ZačneZA);
            List<string> nji = DelajOperacijeNadNizi(mojiNizi, KončaZn);
            Console.WriteLine("Začne z A");
            foreach(string s in aji)
                Console.WriteLine(s);
            Console.WriteLine("Konča z n");
            foreach(string s in nji)
                Console.WriteLine(s);
            //Console.WriteLine("Želiš iskati \n1- po začetku  ali \n2- koncu niza");
            //string izbira = Console.ReadLine();
            //Console.WriteLine("Katero črko iščeš? ");
            //string črka = Console.ReadLine();
            ////poišči vsa imena, ki se začnejo na A
 
            //List<string> imena = new List<string>();
            //if (izbira == "1")
            //  imena =  DobiNizeZačetek(črka,mojiNizi);
            //else
            //  imena = DobiNizeKonec(črka,mojiNizi);
            //foreach (var s in imena)
            //{
            //    Console.WriteLine(s);
            //}
            Console.ReadLine();
        }

        //private static List<string> DobiNizeZačetek(string črka, string[] mojiNizi)
        //{
        //    List<string> r = new List<string>();
        //    foreach (var s in mojiNizi)
        //        if (s.StartsWith(črka))
        //            r.Add(s);
        //    return r;
        //}

        //private static List<string> DobiNizeKonec(string črka, string[] mojiNizi)
        //{
        //    List<string> r = new List<string>();
        //    foreach (var s in mojiNizi)
        //        if (s.EndsWith(črka))
        //            r.Add(s);
        //    return r;
        //}
    }
}
