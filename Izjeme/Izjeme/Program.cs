using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Izjeme
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            while (true)
            {
                try
                {
                    Console.Write("Vnesi število med 0 in 5 " +
                    "(ali pritisni return za konec) > ");
                    userInput = Console.ReadLine();
                    if (userInput == "")
                        break;
                    int index = Convert.ToInt32(userInput);
                    if (index < 0 || index > 5)
                        throw new MojaIzjema(
                        "Vnesel si " + userInput);
                    Console.WriteLine("Tvoje število je " + index);
                }
                catch (MojaIzjema e)
                {
                    Console.WriteLine("Izjema: " + "Število mora biti med 1 in 5. " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(
                    "Pognana je bila izjema. Sporočilo : " +
                   e.Message);
                }
                
               
                finally
                {
                    Console.WriteLine("Hvala");
                }
            }

        }
    }
}
