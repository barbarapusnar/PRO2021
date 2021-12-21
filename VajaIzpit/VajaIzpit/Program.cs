using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaIzpit
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("3 na 4 je "+potenca(4));
            //List<Uporabnik> up = new List<Uporabnik>()
            //{
            //    new Uporabnik() { Ime = "Janez", Email = "janez@tsc.si", DatumRojstva =
            //    DateTime.Parse("1.2.1980") },
            //    new Uporabnik() { Ime = "Meri", Email = "janez@tsc.si", DatumRojstva =
            //    DateTime.Parse("1.3.1982") },
            //    new Uporabnik() { Ime = "Alenka", Email = "alenka@tsc.si", DatumRojstva =
            //    DateTime.Parse("2.2.1985") },
            //    new Uporabnik() { Ime = "Urška", Email = "urska@tsc.si", DatumRojstva =
            //    DateTime.Parse("24.11.1991") },
            //    new Uporabnik() { Ime = "Mojca", Email = "mojca@tsc.si", DatumRojstva =
            //    DateTime.Parse("14.3.1993") }
            //};
            //foreach(var x in up)
            //    Console.WriteLine(x.ToString());
            ////pari enakih uporabnikov
            //Console.WriteLine("Enaki uporabniki");
            //for (int k = 0; k < up.Count(); k++)
            //{
            //    for (int j = k + 1; j < up.Count(); j++)
            //    {
            //        if (up[k] == up[j])
            //        {
            //            Console.WriteLine(up[k].ToString());
            //            Console.WriteLine(up[j].ToString());
            //        }
            //    }
            //            }

            // izpiši vsa imena in priimke iz tabele Kupec
            IzpitEntities db = new IzpitEntities();
            var x1 = from a in db.KUPEC
                     select new { a.KUP_IME, a.KUP_PRIIMEK };
            Console.WriteLine("***********************************");
            foreach(var y in x1)
                Console.WriteLine(y.KUP_IME+" "+y.KUP_PRIIMEK);
            // izpiši imena vseh produktov, katerih cena je več od 100 iz tabele Produkt
            var x2 = from a in db.PRODUKT
                     where a.P_CENA > 100
                     select new {Ime= a.P_OPIS };
            Console.WriteLine("***********************************");
            foreach (var y in x2)
                Console.WriteLine(y.Ime);
            // izpiši vsoto vseh zalog produktov iz tabele Produkt
            //var x3 = (from a in db.PRODUKT
            //         select a.P_ZALOGA).ToList();
            var x3 = (from a in db.PRODUKT
                      select a).ToList();
            Console.WriteLine("***********************************");
            Console.WriteLine("Zaloge so "+x3.Sum(e=>e.P_ZALOGA));
            // izpiši število vseh dobaviteljev iz tabele Dobavitelj
            var x4 = db.DOBAVITELJ.Count();
            Console.WriteLine("***********************************");
            Console.WriteLine("Število dobaviteljev " + x4);
            // izpiši imena in priimke kupcev, ki smo jim že izdali račun(koda kupca je v tabeli
            //Račun, ime in priimek je v tabeli Kupec)
            var x5 = (from a in db.RAČUN
                     from b in db.KUPEC
                     where a.KUP_KODA == b.KUP_KODA
                     select new { b.KUP_IME, b.KUP_PRIIMEK }).Distinct();
            Console.WriteLine("***********************************");
            foreach (var y in x5)
                Console.WriteLine(y.KUP_IME + " " + y.KUP_PRIIMEK);
            var x6 = (from a in db.RAČUN
                     select new { Ime = a.KUPEC.KUP_IME, Priimek = a.KUPEC.KUP_PRIIMEK }).Distinct();
            Console.WriteLine("***********************************");
            foreach (var y in x6)
                Console.WriteLine(y.Ime + " " + y.Priimek);
            // izpiši opis vseh produktov iz tabele Produkt razvrščene padajoče po ceni
            var x7 = from a in db.PRODUKT
                     orderby a.P_CENA descending
                     select a.P_OPIS;
            Console.WriteLine("***********************************");
            foreach (var y in x7)
                Console.WriteLine(y);
            // iz tabele Vrstica izpiši skupno vrednost računa po posameznem računu(številka
            //računa, znesek)
            var x8 = from a in db.VRSTICA
                     group a by a.RAČ_ID;
            Console.WriteLine("***********************************");
            foreach (var y in x8)
            {
                Console.Write("Račun št "+y.Key);
                var x9 = y.Sum(e => (decimal)e.VRS_KOS * e.VRS_CENA);
                Console.WriteLine("\t"+ x9);
            }
            // iz tabele Vrstica izpiši povprečno ceno po produktu(koda produkta, povprečna cena)
            var x10 = from a in db.VRSTICA
                      group a by a.P_KODA;
            Console.WriteLine("***********************************");
            foreach (var y in x10)
            {
                Console.Write("Koda produkta" + y.Key);
                var x11 = y.Average(e => e.VRS_CENA);
                Console.WriteLine("\t" + x11);
            }
            // iz tabele Produkt izpiši imena produktov razvrščena po imenih dobaviteljev(ime
            //dobavitelja, vsi produkti dobavitelja)
            var x12 = from a in db.PRODUKT
                      orderby a.DOBAVITELJ.D_IME
                      select new { ImeDobavitelja = a.DOBAVITELJ.D_IME, ImeProdukta = a.P_OPIS };
            Console.WriteLine("***********************************");
            foreach (var y in x12)
            {
                Console.WriteLine(y.ImeDobavitelja+" "+y.ImeProdukta);
            }
            Console.ReadLine();
        }
        static int potenca(int n)
        {
            if (n == 0)
                return 1;
            return 3 * potenca(n - 1);
        }
    }
}
