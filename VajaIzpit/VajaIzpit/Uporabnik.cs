using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VajaIzpit
{
    class Uporabnik
    {
        public string Ime { get; set; }
        public string Email { get; set; }
        public DateTime DatumRojstva { get; set; }
        public override string ToString()
        {
            return "Uporabnik " + Ime + " Email " + Email + " Rojen " + DatumRojstva.ToShortDateString();
        }
        public static bool operator ==(Uporabnik a, Uporabnik b)
        {
            return a.Email == b.Email;
        }
        public static bool operator !=(Uporabnik a, Uporabnik b)
        {
            return !(a == b);
        }
    }
}
