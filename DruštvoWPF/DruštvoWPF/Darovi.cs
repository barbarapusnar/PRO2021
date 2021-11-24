using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DruštvoWPF
{
    [Serializable]
    class Darovi
    {
        public int ZapŠt { get; set; }
        public DateTime Datum { get; set; }
        public string Namen { get; set; }
        public decimal Znesek { get; set; }
        public string Opombe { get; set; }
        //zaradi serializacije mora biti ctor brez parametrov
        public Darovi()
        {

        }
    }
}
