using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajnovejšiDostop
{
    class Program
    {
        static void Main(string[] args)
        {
            northwndEntities nw = new northwndEntities();
            nw.Database.Log = Console.Write;
            //var pijače = from p in nw.Products
            //             where p.Categories.CategoryName == "Beverages"
            //             orderby p.ProductName
            //             select p;
            var pijače = nw.Products.Where(p => p.Categories.CategoryName == "Beverages").OrderBy(p => p.ProductName);
            
            //Console.WriteLine("Imamo "+pijače.Count()+" pijač");
            foreach (var x in pijače)
            {
                Console.WriteLine(x.ProductName + " " + x.UnitPrice);
            }
            //posodabljanje
            Products pi = pijače.FirstOrDefault();
            if (pi != null)
            {
                decimal novacena = (decimal)pi.UnitPrice + 10;
                pi.UnitPrice = novacena;
                nw.SaveChanges();
            }
            Console.WriteLine("Po zvišanju cene");
            foreach (var x in pijače)
            {
                Console.WriteLine(x.ProductName+" "+x.UnitPrice);
            }
            //vstavljanje
            Products a = new Products {ProductName="testni produkt" ,CategoryID=1};
            nw.Products.Add(a);
            nw.SaveChanges();
            Console.WriteLine("Po dodajanju");
            foreach (var x in pijače)
            {
                Console.WriteLine(x.ProductName + " " + x.UnitPrice);
            }
            //brisanje
            var zaBrisat = from p in nw.Products
                           where p.ProductName == "testni produkt"
                           select p;
            if (zaBrisat.Count() > 1)
            {
                foreach (var x in zaBrisat)
                {
                    nw.Products.Remove(x);
                    Console.WriteLine("Brisan");
                }
                nw.SaveChanges();
            }
            Console.WriteLine("Po brisanju");
            foreach (var x in pijače)
            {
                Console.WriteLine(x.ProductName + " " + x.UnitPrice);
            }
            Console.ReadLine();
        }
    }
}
