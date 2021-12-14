using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vrednosti = { 0,12,44,36,92,54,13,8};
            var r = from x in vrednosti
                    where x < 37
                    orderby x
                    select x;
            foreach (var y in r)
            {
                Console.WriteLine(y);
            }
            IEnumerable<Strip> stripi = IzdelajKatalog();
            Dictionary<int, decimal> vrednost = DobiCenik();
            var dragi = from x in stripi
                        where vrednost[x.Številka] > 500
                        orderby vrednost[x.Številka] descending
                        select x;
            foreach (var y in dragi)
            {
                Console.WriteLine(y.Številka+" "+y.Ime+" "+vrednost[y.Številka]);
            }
            Console.ReadLine();
        }
        static IEnumerable<Strip> IzdelajKatalog()
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

    }
}
