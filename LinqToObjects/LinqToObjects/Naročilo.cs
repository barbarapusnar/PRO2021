using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToObjects
{
    class Naročilo
    {
        public int NaročiloID { get; set; }
        public DateTime Datum { get; set; }
        public string ImeKupca { get; set; }
        public Naslov NaslovDobave { get; set; }
        public Naslov NaslovRačuna { get; set; }
        public decimal Znesek { get; set; }
        public List<PodrobnostiNaročila> Elementi { get; set; }
        public Naročilo()
        {
            Elementi = new List<PodrobnostiNaročila>();
        }
    }
}
