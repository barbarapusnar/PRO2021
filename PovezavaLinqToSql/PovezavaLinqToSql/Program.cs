using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PovezavaLinqToSql
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthDataContext dc = new NorthDataContext();
            //izberi imena podjetij
            var x1 = from a in dc.Customers
                     select a;
            //Console.WriteLine("Imena podjetij");
            //foreach (var y in x1)
            //{
            //    Console.WriteLine(y.CompanyName);
            //}
            var x2 = from a in dc.Customers
                     select a.CompanyName;
            //Console.WriteLine("Samoo imena podjetij");
            //foreach (var y in x2)
            //{
            //    Console.WriteLine(y);
            //}
            var x3 = from a in dc.Customers
                     select new {Ime=a.CompanyName,Kontakt=a.ContactName };
            //Console.WriteLine("Kontakti");
            //foreach (var y in x3)
            //{
            //    Console.WriteLine(y.Kontakt);
            //}
            var x4 = from a in dc.Orders
                     select a;
            //Console.WriteLine("ID-ji naročil");
            //foreach(var y in x4)
            //    Console.WriteLine(y.OrderID);
            var x5 = from a in dc.Orders
                     from b in dc.Order_Details
                     where a.OrderID == 11076 && b.OrderID==11076
                     select b;
            Console.WriteLine("Podorobnosti 11076");
            foreach (var y in x5)
            {
                Console.WriteLine(y.ProductID+" "+y.Quantity);
            }
            Order_Detail od = new Order_Detail();
            od.OrderID = 11076;
            od.ProductID = 7;
            od.UnitPrice = 0.2m;
            od.Quantity = 88;
            od.Discount = 0;
            Vstavi(od);
            Console.WriteLine("Podorobnosti 11076 po vstavljanju");
            foreach (var y in x5)
            {
                Console.WriteLine(y.ProductID + " " + y.Quantity);
            }
            Briši(11076, 7);
            Console.WriteLine("Podorobnosti 11076 po brisanju");
            foreach (var y in x5)
            {
                Console.WriteLine(y.ProductID + " " + y.Quantity);
            }
            Order_Detail p = new Order_Detail();
            p.OrderID = 11076;
            p.ProductID = 6;
            p.Quantity = 88;
            Posodobi(p, dc);
            Console.WriteLine("Podorobnosti 11076 po posodabljanju");
            foreach (var y in x5)
            {
                Console.WriteLine(y.ProductID + " " + y.Quantity);
            }
            Console.ReadLine();
        }
        private static void Posodobi(Order_Detail od, NorthDataContext dc)
        {
            try 
            {
                var x = (from a in dc.Order_Details
                         where a.OrderID == od.OrderID && a.ProductID == od.ProductID
                         select a).FirstOrDefault();
                if (x != null)
                {
                    x.Quantity = od.Quantity;
                    dc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Vstavi(Order_Detail od)
        {
            NorthDataContext dc = new NorthDataContext();
            try 
            {
                Order_Detail p = new Order_Detail();
                p.OrderID = od.OrderID;
                p.ProductID = od.ProductID;
                p.UnitPrice = od.UnitPrice;
                p.Quantity = od.Quantity;
                p.Discount = od.Discount;
                dc.Order_Details.InsertOnSubmit(p);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void Briši(int idN, int id)
        {
            NorthDataContext dc = new NorthDataContext();
            try 
            {
                var x = (from a in dc.Order_Details
                        where a.OrderID == idN && a.ProductID == id
                        select a).FirstOrDefault();
                dc.Order_Details.DeleteOnSubmit(x);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
