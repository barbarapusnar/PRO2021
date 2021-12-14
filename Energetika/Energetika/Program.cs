using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energetika
{
    class Program
    {
        static void Main(string[] args)
        {
            ElektrikaEntities en = new ElektrikaEntities();
            //1. izberi čas meritve in skupno moč
            var x1 = en.Meritve.Select(e => new { Čas = e.ZapisČas, Moč = e.kW1 + e.kW2 + e.kW3 });
            var x11 = from e in en.Meritve
                      select new { Čas = e.ZapisČas, Moč = e.kW1 + e.kW2 + e.kW3 };
            //ista poizvedba z lambda izrazom
            //Console.WriteLine("1.***********************************");
            //Console.WriteLine(x1.Count());
            //2. izberi čas meritve in skupno moč za datum 18.8.2013
            DateTime d = DateTime.Parse("18.8.2013");
            //var x2 = en.Meritve.Where(e => e.ZapisČas.Value.Date == d).Select(e => new { Čas = e.ZapisČas, Moč = e.kW1 + e.kW2 + e.kW3 });
            var x2 = en.Meritve.Where(e => e.ZapisČas.Value.Day== 18 && e.ZapisČas.Value.Month == 8
            && e.ZapisČas.Value.Year == 2013).Select(e => new { Čas = e.ZapisČas, Moč = e.kW1 + e.kW2 + e.kW3 });
            //Console.WriteLine("2.***********************************");
            //foreach (var y in x2)
            //{
            //    Console.WriteLine(y.Čas+" "+y.Moč);
            //}
            //3. izračunaj povprečno moč za datum 18.8.2013

            //4. izračunaj maximalno moč za ta datum

            //5. izračunaj minimalno moč za ta datum

            //6. izračunaj povprečno moč po urah za dan 18.8.2013
            var x6 = from b in en.Meritve
                     where b.ZapisČas.Value.Day == 18 && b.ZapisČas.Value.Month == 8
                           && b.ZapisČas.Value.Year == 2013
                     group b by b.ZapisČas.Value.Hour into z
                     select new { Ura = z.Key, Moč = z.Average(e => e.kW1 + e.kW2 + e.kW3) };
            foreach (var y in x6)
            {
                Console.WriteLine(y.Ura+" "+y.Moč);
            }
            //7. izračunaj 15 minutna povprečja za 18.8.2013
            var x7 = from b in en.Meritve
                     where b.ZapisČas.Value.Day == 18 && b.ZapisČas.Value.Month == 8
                           && b.ZapisČas.Value.Year == 2013
                     let ura=b.ZapisČas.Value.Hour
                     let min=b.ZapisČas.Value.Minute
                     let quater=min/15
                     group b by new { ura, quater } into z
                     select new { Ura = z.Key.ura,Četrt=z.Key.quater, Moč = z.Average(e => e.kW1 + e.kW2 + e.kW3) };
            foreach (var y in x7)
            {
                Console.WriteLine(y.Ura + " " +y.Četrt+" "+ y.Moč);
            }
            Console.ReadLine();
        }
    }
}
