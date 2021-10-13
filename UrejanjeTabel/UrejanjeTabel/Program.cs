using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrejanjeTabel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1000000;
            double[] a = new double[n];
            Random r = new Random();
            for (int k = 0; k < n; k++)
                a[k] = r.Next(n);
            DateTime d = DateTime.Now;
            QuickSort(0, a.Length - 1, a);
            DateTime d1 = DateTime.Now;
            TimeSpan ts = d1 - d;
            Console.WriteLine("Čas za Quicksort je " + ts.TotalMilliseconds + " ms");
            Console.ReadLine();
        }
        static void Izbiranje(int[] a)
        {
            for (int k = 0; k < a.Length-1; k++)
            {
                //poišči minimum
                int min = a[k];
                int minIndeks = k;
                for (int j = k; j < a.Length; j++)
                {
                    if (a[j] < min)
                    {
                        min = a[j];
                        minIndeks = j;
                    }
                }
                //zamenjaj k-ti in najmanjši element
                int temp = a[k];
                a[k] = a[minIndeks];
                a[minIndeks] = temp;
               // Izpis(a);
            }
        }
        static void Vstavljanje(int[] a)
        {
            for (int k = 1; k < a.Length; k++)
            {
                int j = k;
                int temp = a[k];
                while (j > 0 && a[j - 1] > temp) //pogrezannje
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = temp;
               // Izpis(a);
            }
        }
        static void Izpis(int[] a)
        {
            for (int k = 0; k < a.Length; k++)
            {
                Console.Write(a[k]+"\t");
            }
            Console.WriteLine();
        }
        static int Pivot(int zač, int konec, double[] tab)
        {
            int p = tab[zač];
            int m = zač;
            int n = konec + 1;
            //poišči z m prvega, ki je večji od p
            do
            { m = m + 1; } while (tab[m] <= p & m < konec);
            do
            { n = n - 1; } while (tab[n] > p);
            //tab[m] je večji od p
            //tab[n] je manjši od p
            //zamenjaj jih
            while (m < n)
            {
                int temp = tab[m];
                tab[m] = tab[n];
                tab[n] = temp;
                do
                { m = m + 1; } while (tab[m] <= p);
                do
                { n = n - 1; } while (tab[n] > p);
            }
            //zamenjaj pivotni element, z elementom tab[n]
            int temp2 = tab[n];
            tab[n] = tab[zač];
            tab[zač] = temp2;
          
            return n;
        }
        static void QuickSort(int zač, int konec, double[] tab)
        {
            if (zač >= konec)
                return;
            int a = Pivot(zač, konec, tab);
            QuickSort(zač, a - 1, tab);//levi del
            QuickSort(a + 1, konec, tab); //desni del

        }
    }
}
