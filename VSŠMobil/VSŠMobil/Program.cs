using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSŠMobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Kupec janez = new Kupec();
            janez.Ime = "Janez Novak";
            janez.BeležiKlic(10, 1);
            Console.WriteLine(janez.ToString());

            Kupec60 alenka = new Kupec60();
            alenka.Ime = "Alenka Prinčič";
            alenka.BeležiKlic(70, 2);
            
            Console.WriteLine(alenka.ToString());
            Console.WriteLine("Metoda GetType "+alenka.GetType());
            Console.WriteLine("Metoda ToString() "+alenka.ToString());

            Kupec[] vsi = new Kupec[3]; //tabela treh elementov tipa kupec
            vsi[0] = new Kupec();
            vsi[1] = new Kupec60();
            vsi[1].Ime = "Maja Novak";
            vsi[1].BeležiKlic(70, 2);
            Console.WriteLine(vsi[1].ToString());
            Console.ReadLine();
        }
    }
}
