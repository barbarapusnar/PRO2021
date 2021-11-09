using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Računanje
{
    class Kompleksno
    {
        public double Re { get; set; }
        public double Im { get; set; }
        public override string ToString()
        {
            return Re + "+ i*" + Im;
        }
        //+,-,*
    }
}
