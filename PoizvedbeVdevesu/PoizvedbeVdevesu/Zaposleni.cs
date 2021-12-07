using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoizvedbeVdevesu
{
    class Zaposleni:IComparable<Zaposleni>
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Oddelek { get; set; }

        public int CompareTo(Zaposleni other)
        {
            //zaposelni 1 je pred zaposlenim 2, če je njegov id manjši
            if (this.Id < other.Id)
                return -1;
            if (this.Id > other.Id)
                return 1;
            return 0;

           // return this.Priimek.CompareTo(other.Priimek);
        }
        public override string ToString()
        {
            return "Id: " + Id + " Ime: " + Ime + " " + Priimek + " Oddelek: " + Oddelek;
        }
    }
}
