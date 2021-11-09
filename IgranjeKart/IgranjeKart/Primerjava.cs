using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IgranjeKart
{
    class Primerjava : IComparer<Karta>
    {
        public int Compare(Karta x, Karta y)
        {
            if (x.Vrednost < y.Vrednost)
                return -1;
            if (x.Vrednost > y.Vrednost)
                return 1;
            //tukaj pridem če je na karti ista vrednost
            if (x.Barva < y.Barva)
                return -1;
            if (x.Barva > y.Barva)
                return 1;
            return 0;
        }
    }
}
