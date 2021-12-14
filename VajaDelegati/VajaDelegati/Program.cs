using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaDelegati
{
    class Program
    {
        //delegate string Spremeni(string vhodniNiz);
        static void Main(string[] args)
        {
           // Func<string,string> metoda = delegate(string s) { return s.ToUpper(); };
            Func<string, string> metoda = s=> s.ToUpper();
            string ime = "Dakota";
            Console.WriteLine(metoda(ime));

            int[] numbers = { 5, 10, 8, 3, 6, 12 };
            var deljivaZDva = from x in numbers
                              where x % 2 == 0
                              orderby x
                              select x;
            //metodna sintaksa
            var zDva = numbers.Where(s => s % 2 == 0).OrderBy(n => n);
            foreach(var a in deljivaZDva)
                Console.Write(a+"\t");
            Console.WriteLine();
            foreach (var a in zDva)
                Console.Write(a + "\t");
            Console.ReadLine();
        }
        //static string VVelike(string a) //je tipa spremeni
        //{
        //    return a.ToUpper();
        //}
    }
}
