using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukture
{
    class Program
    {
        struct Vektor //vrednostni tip
        {
            public double x;
            public double y;
            public double z;
            public double this[int i]
            {
                get {
                    switch (i)
                    {
                        case 0:
                            return x;
                        case 1:
                            return y;
                        case 2:
                            return z;
                        default:
                            throw new IndexOutOfRangeException("Napačen indeks");
                    }
                }
                set {
                    switch (i)
                    {
                        case 0:
                            x = value; break;
                        case 1:
                            y = value;break;
                        case 2:
                            z = value;break;
                        default:
                            throw new IndexOutOfRangeException("Napačen indeks");

                    }
                }
            }
            public override string ToString() //deduje od razreda object
            {
                return "(" + x + ", " + y + ", " + z + ")";
            }
            public Vektor(double x1,double y1,double z1) //konstruktor  brez parametrov ni dovoljen
            {
                x = x1;y = y1;z = z1;
            }
            public Vektor(Vektor v)
            {
                x = v.x;y = v.y;z = v.z;
            }
            //preobteževanje operatorja +
            public static Vektor operator +(Vektor levi, Vektor desni)
            {
                Vektor r;
                r.x = levi.x + desni.x;
                r.y = levi.y + desni.y;
                r.z = levi.z + desni.z;
                return r;
            }
            public static Vektor operator *(double levi, Vektor desni)
            {
                Vektor r;
                r.x = levi* desni.x;
                r.y = levi* desni.y;
                r.z = levi* desni.z;
                return r;
            }
            public static Vektor operator *(Vektor levi, double desni)
            {
                return desni * levi;
            }
            public static double operator *(Vektor v, Vektor w) //skalarni produkt
            {
                return v.x * w.x + v.y * w.y + v.z * w.z;
            }
            public static bool operator ==(Vektor v, Vektor w)
            {
                return v.x == w.x && v.y == w.y && v.z == w.z;
            }
            public static bool operator !=(Vektor v, Vektor w)
            {
                return !(v == w);
            }
        }
        static void Main(string[] args)
        {
            Vektor v1; //deklaracija
            v1.x = 1;
            v1.y = 1;
            v1.z = 1;
            Console.WriteLine(v1.ToString());
            Vektor v2 = new Vektor(2,-1,2);        
            Console.WriteLine(v2.ToString());
            Vektor v3 = v1 + v2;
            Console.WriteLine(v3.ToString());
            Console.WriteLine((v1*7).ToString());
            Console.WriteLine((v1*v2).ToString());
            Console.WriteLine("V1==V2? "+(v1==v2));
            //z indekserjem
            for (int k = 0; k < 3; k++)
                v1[k] = 2 * k;
            Console.WriteLine(v1.ToString());
            Console.ReadLine();
        }
    }
}
