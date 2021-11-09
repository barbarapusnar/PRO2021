using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Računanje1
{
    class Matrika
    {
       int[,] m = new int[3, 3];
       public int this[int k, int j]
        {
            get { return m[k, j]; }
            set { m[k, j] = value; }
        }
        //izpis
        public override string ToString()
        {
            string s = "";
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    s += m[k, j] + ",\t";
                }
                s += Environment.NewLine;
            }
            return s;
        }
        public static Matrika operator *(Matrika a, Matrika b)
        {
            Matrika r = new Matrika();
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    r[k, j] = a[k, 0] * b[0, j] + a[k, 1] * b[1, j] + a[k, 2] * b[2, j];
                }
            }
            return r;
        }
    }
}
