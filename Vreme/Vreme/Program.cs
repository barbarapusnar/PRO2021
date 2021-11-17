using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Vreme
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"D:\PRO2021\Vreme\Vreme\Drugi.xml", FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(IzdaniRacunEnostavni));
            //AGROMET a = (AGROMET)xml.Deserialize(fs);
            //foreach (AGROMETDATA x in a.DATA)
            //{
            //    Console.WriteLine(x.Temp2_Max+" "+x.Date);
            //}
            IzdaniRacunEnostavni a = (IzdaniRacunEnostavni)xml.Deserialize(fs);
            foreach (var x in a.Racun.PostavkeRacuna)
            {
                Console.WriteLine(x.OpisiArtiklov.OpisArtikla.OpisArtikla1+" "
                    +x.ZneskiPostavke.ZnesekPostavke);
            }
            Console.ReadLine();
        }
    }
}
