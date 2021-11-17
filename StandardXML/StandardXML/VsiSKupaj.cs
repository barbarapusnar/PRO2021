using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardXML
{
    public class VsiSKupaj
    {
        public Moštvo[] liga = new Moštvo[10];
        public VsiSKupaj()
        {
            liga[0] = new Moštvo("Italija");
            liga[1] = new Moštvo("Škotska");
            liga[2] = new Moštvo("Irska  ");
            liga[3] = new Moštvo("Španija");
            liga[4] = new Moštvo("Nemčija");
            liga[5] = new Moštvo("Anglija");
            liga[6] = new Moštvo("Poljska");
            liga[7] = new Moštvo("Češka  ");
            liga[8] = new Moštvo("Finska ");
            liga[9] = new Moštvo("Švedska");
        }
    }
}
