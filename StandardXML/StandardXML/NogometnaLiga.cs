using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StandardXML
{
    public class NogometnaLiga
    {
        const int N = 10;
        public Moštvo[] liga = new Moštvo[N];
        int[,] pari = new int[10, 10]; //v tabeli bo številka kola pari[0,1] =2 pomeni
        //ekipa 0 igra proti ekipi 1 v 2 kolu
        int x = 0;//pomožne spremenljivke za round robin
        int y = 1;
        int[] gor = { 2, 3, 4, 5 };
        int[] dol = { 9, 8, 7, 6 };
        public void inicializaicja()
        {
            //for (int i = 0; i < N; i++)
            //{
            //    //Console.Write("Vnesi ime moštva");
            //    //string ime = Console.ReadLine();
            //    //liga[i] = new Moštvo(ime);
            //}
            liga[0] = new Moštvo("Italija");
            liga[1] = new Moštvo("Škotska");
            liga[2] = new Moštvo("Irska  ");
            liga[3] = new Moštvo("Španija");
            liga[4] = new Moštvo("Nemčija");
            liga[5] = new Moštvo("Anglija");
            liga[6] = new Moštvo("Poljska");
            liga[7] = new Moštvo("Češka  ");
            liga[8] = new Moštvo("Finska ");
            liga[9] = new Moštvo("Švedska");
        }
        public void ObdelajRezultat(int a)
            //a bo kolo, vnesemo 3 : 2
        {
            for (int i = 0; i < 10; i++)
            {
                for (int k = i + 1; k < 10; k++)
                {
                    if (pari[i, k] == a) //dobila sem par te lige
                    {
                       Console.Write("Rezultat tekme " + liga[i].Ime + ": " + liga[k].Ime+" > ");
                       string r = Console.ReadLine();
                       string[] dva = r.Split(':');
                       liga[i].DaniGoli    = int.Parse(dva[0]);
                       liga[i].PrejetiGoli = int.Parse(dva[1]);
                       if (liga[i].DaniGoli > liga[i].PrejetiGoli)
                           liga[i].ŠtZmag++;
                       else
                           if (liga[i].DaniGoli == liga[i].PrejetiGoli)
                               liga[i].ŠtNeodločenih++;
                           else
                               liga[i].ŠtPorazov++;
                       liga[i].ŠtTekem++;
                       liga[k].DaniGoli = int.Parse(dva[1]);
                       liga[k].PrejetiGoli = int.Parse(dva[0]);
                       if (liga[k].DaniGoli > liga[k].PrejetiGoli)
                           liga[k].ŠtZmag++;
                       else
                           if (liga[k].DaniGoli == liga[k].PrejetiGoli)
                               liga[k].ŠtNeodločenih++;
                           else
                               liga[k].ŠtPorazov++;
                       liga[k].ŠtTekem++;
                    }
                }
            }
           
            
        }
        public void UrediTabelo()
        {
            for (int k = 0; k < N - 1; k++)
            {
                Moštvo max = liga[k];
                int makIndeks=k;
                for (int j = k; j < N; j++)
                {
                    if (liga[j].BoljšeMoštvo(max))
                    {
                        max = liga[j];
                        makIndeks = j;
                    }
                }
                //v maxIndeks spada na mesto k , k-tega damo v maxIndeks
                Moštvo temp = liga[makIndeks];
                liga[makIndeks] = liga[k];
                liga[k] = temp;
            }
            
        }
        
        public void Izpis()
        {
                Console.WriteLine("Ime\t\tŠt.točk\tZmage\tPorazi\tPrejeti\tDani\t Razlika");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("{0}\t\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", liga[i].Ime,
                    liga[i].ŠteviloTočk(), liga[i].ŠtZmag, liga[i].ŠtPorazov, liga[i].PrejetiGoli, liga[i].DaniGoli,
                    liga[i].GolRazlika());
            }
        }
         public void NapolniPari(int kolo)
        {
            //int x = 1;
            //int y = 2;
            //int[] gor = { 3, 4, 5, 6 };
            //int[] dol = { 10, 9, 8, 7 };
            pari[x, y] = kolo;
            for (int k = 0; k < 4; k++)
                pari[gor[k], dol[k]] = kolo;
            //naredi robin za naslednje kolo
            x = 0;
            int temp1 = y;
            y = dol[0];
            for (int k = 1; k < 4; k++)
                dol[k - 1] = dol[k];
            dol[3] = gor[3];
            for (int k = 3; k >= 1; k--)
                gor[k] = gor[k - 1];
            gor[0] = temp1;

        }
        public void IzdelajTurnir()
        {
            for (int k = 1; k < 10; k++)
            {
                NapolniPari(k);
            }
        }
        public void IzpišiTabeloParov(int kolo)
        {
            for (int k = 0; k < 10; k++)
            {
                for (int i = 0; i < 10; i++)
                {
                    if (pari[k, i] == kolo)
                        Console.WriteLine("Kolo :" + pari[k, i] + " prva ekipa  " + k + " druga ekipa " + i);
                }

            }
        }

    }
}
