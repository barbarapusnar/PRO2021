using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace PoizvedbeVdevesu
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Delaj();
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
               // Console.WriteLine("Exception: "+ ex.Message);
            }

        }

        private static void Delaj()
        {
            //Zaposleni a = new Zaposleni();
            //a.Id = 1;a.Ime = "Miha";a.Priimek = "Polanc";a.Oddelek = "IT";
            //Tree<Zaposleni> x = new Tree<Zaposleni>(a);

            Tree<Zaposleni> z = new Tree<Zaposleni>(
              new Zaposleni { Id = 1, Ime = "Miha", Priimek = "Polanc", Oddelek = "IT" });

            z.Insert(new Zaposleni { Id = 2, Ime = "Andrej", Priimek = "Bratina", Oddelek = "Marketing" });
            z.Insert(new Zaposleni { Id = 4, Ime = "Lucija", Priimek = "Krkoč", Oddelek = "Prodaja" });
            z.Insert(new Zaposleni { Id = 6, Ime = "Peter", Priimek = "Gulin", Oddelek = "IT" });
            z.Insert(new Zaposleni { Id = 3, Ime = "Franc", Priimek = "Milčinski", Oddelek = "Marketing" });
            z.Insert(new Zaposleni { Id = 5, Ime = "Pavel", Priimek = "Matko", Oddelek = "Prodaja" });
            //1. napiši kodo, ki izpiše vse oddelke
            //2. napiši kodo, ki izpiše vse različne oddelke
            //var x = from a in z
            //        select a.Oddelek;
            //x = x.Distinct();

            var x = z.Select(a => a.Oddelek).Distinct();

            Console.WriteLine("Oddelki----");
            foreach(var y in x)
                Console.WriteLine(y);

            //3. napiši kodo, ki izpiše vse zaposlene v oddelku IT
            //var x1 = from a in z
            //         where a.Oddelek == "IT"
            //         select a;

            var x1 = z.Where(a => a.Oddelek == "IT");
            Console.WriteLine("Zaposleni v IT-----");
            foreach (var y in x1)
                Console.WriteLine(y.ToString());
            //4. napiši kodo, ki izpiše zaposlene po oddelkih
            //var x2 = (from a in z
            //         group a by a.Oddelek);

            var x2 = z.GroupBy(a => a.Oddelek);

            Console.WriteLine("Zaposleni po oddelkih---");
            foreach (var y in x2)
            {
                Console.WriteLine(y.Key);
                foreach(var y1 in y)
                    Console.WriteLine("\t"+y1.ToString());
            }

            //dodaj zaposlenega
            z.Insert(new Zaposleni {Id=7,Ime="Monika",Priimek="Seleš",Oddelek="Kozmetika" });
            //ni na novo izračunan x2
            Console.WriteLine("Zaposleni po oddelkih po vstavljanju");
            foreach (var y in x2)
            {
                Console.WriteLine(y.Key);
                foreach (var y1 in y)
                    Console.WriteLine("\t" + y1.ToString());
            }

        }
    }
}
