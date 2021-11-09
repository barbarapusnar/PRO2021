using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaja
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            int[] y = new int[10];
            for (int k = 0; k < 10; k++)
                x[k] = k;
            Izpis(x);
            y = x;
            for (int k = 0; k < 10; k++)
                y[k] = x[k];
            Izpis(y);
            y[0] = 500;
            Izpis(x);
            Izpis(y);
            Console.ReadLine();
        }
        static void Izpis(int[] x)
        {
            for (int k = 0; k < 10; k++)
                Console.Write(x[k]+"\t");
            Console.WriteLine();
        }
    }
}
