using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaBaza
{
    class Program
    {
        static void Main(string[] args)
        {
            BazaZaVajeEntities db = new BazaZaVajeEntities();
            //poizvedbe
            //            a.izberi P_OPIS, P_ZALOGA, P_MIN, P_CENA iz tabele PRODUKT, kjer je P_DATUM manjši od
            //20.jan. 2004
            DateTime datum = DateTime.Parse("20.1.2004");
            var x1 = from a in db.PRODUKTs
                     where a.P_DATUM < datum
                     select new { a.P_OPIS, a.P_ZALOGA, a.P_MIN, a.P_CENA,a.P_DATUM };
            Console.WriteLine("______________________________");
            foreach (var x in x1)
            {
                Console.WriteLine("Opis "+x.P_OPIS+" "+x.P_DATUM.ToString());
            }

            //b.izberi P_OPIS, P_ZALOGA, P_DATUM in današnjidatum + 365 naj se imenuje ZAPADLOST iz
            //  tabele PRODUKT
            TimeSpan ts = new TimeSpan(365, 0, 0, 0);
            DateTime zapadlost = DateTime.Now.Add(ts);
            var x2 = db.PRODUKTs.Select(e => new {
                e.P_OPIS,
                e.P_ZALOGA,
                e.P_MIN,
                e.P_DATUM,
                zapadlost 
            });
            Console.WriteLine("______________________________");
            foreach (var y in x2)
            {
                Console.WriteLine(y.zapadlost);
            }

            //c.izberi P_OPIS, P_ZALOGA, P_MIN, P_CENA iz tabele PRODUKT, kjer je P_CENA manjša od 50 in 
            //je P_DATUM večji kot 15.jan. 2004
            datum = DateTime.Parse("15.1.2004");
            var x3 = db.PRODUKTs.Where(e => e.P_DATUM.Value >datum && e.P_CENA < 50).
                Select(e => new { e.P_OPIS, e.P_ZALOGA, e.P_MIN, e.P_CENA });
            Console.WriteLine("______________________________");
            foreach (var y in x3)
            {
                Console.WriteLine(y.P_OPIS);
            }
            //d.izberi vse atribute iz tabele DOBAVITELJ katerih ime se začne s Smith
            var x4 = db.DOBAVITELJs.Where(e => e.D_KONTAKT.StartsWith("Smith"));
            Console.WriteLine("______________________________");
            foreach (var y in x4)
            {
                Console.WriteLine(y.D_KONTAKT);
            }
            //e.izberi vse dobavitelje, kjer je zaloga v produktu manjša od dvakratnika minimalne zaloge
            var x5 = db.PRODUKTs.Where(e => e.P_ZALOGA < 2 * e.P_MIN).Select(e =>new { e.DOBAVITELJ.D_IME });
            var x51 = (from e in db.PRODUKTs
                      where e.P_ZALOGA < e.P_MIN * 2
                      select new { e.DOBAVITELJ.D_IME }).Distinct();
            Console.WriteLine("x51______________________________");
            foreach (var y in x51)
            {
                    Console.WriteLine(y.D_IME);
            }
            //f.izberi D_KODA od dobaviteljev, ki so nam že dobavili katerega izmed produktov.Vsak
            //dobavitelj naj bo v rešitvi samo enkrat
            var x7 = (from a in db.PRODUKTs
                      from b in db.DOBAVITELJs
                      where a.D_KODA == b.D_KODA
                      select b).Distinct();
            var x71 = (
                from a in db.PRODUKTs
                select new {a.DOBAVITELJ.D_IME,a.DOBAVITELJ.D_KONTAKT}
                ).Distinct().ToList();
            Console.WriteLine("71______________________________");
            foreach (var y in x71)
            {
                if (y.D_IME!=null )
                Console.WriteLine(y.D_IME );
            }
            Console.WriteLine("Število dobaviteljev " + x71
                .Count());
            //g.izberi kodo in ime dobavitelja, ki nam še niso ničesar dobavili(njihova koda se ne pojavlja v
            //tabeli PRODUKT)
            var x8 = db.DOBAVITELJs.Where(e => !x7.Any(p => p.D_KODA == e.D_KODA));
            foreach (var y in x8)
            {
                Console.WriteLine(y.D_IME + " " + y.D_KONTAKT);
            }
            Console.WriteLine("Število dobaviteljev " + x8.Count());
            //h.izpiši vsoto vseh stanj pri kupcih(KUP_STANJE) (2089, 28)
            var x9 = db.KUPECs.Sum(e => e.KUP_STANJE);
            Console.WriteLine("Vsa stanja " + x9);

            //i.izračunaj celotno vrednost blaga na zalogi(15.084,52€) 
            var x10 = db.PRODUKTs.Sum(e => e.P_CENA * e.P_ZALOGA);
            Console.WriteLine("Vrednost zaloge je " + x10);
            //j.izpiši število različnih produktov posameznega dobavitelja po posameznem dobavitelju iz
            //tabele produkt(rešitev ima 6 vrstic, če izključimo dobavitelja null)
            Console.WriteLine("Grupiranje");
            var x11 =
            from b in db.PRODUKTs
            group b by b.D_KODA into z
            select new { Dobavitelj = z.Key, Število = z.Count() };
            foreach (var y in x11)
            {
                if (y.Dobavitelj != null)
                    Console.WriteLine(y.Dobavitelj + " " + y.Število);
            }
                   
                               Console.ReadLine();
        }
    }
}
