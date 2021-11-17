using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StandardXML
{
    public class Moštvo
    {
        string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }

        }
        int štTekem, štZmag, štNeodločenih, štPorazov, daniGoli, prejetiGoli;

        public int PrejetiGoli
        {
            get { return prejetiGoli; }
            set { prejetiGoli = value; }
          
        }

        public int DaniGoli
        {
            get { return daniGoli; }
            set { daniGoli = value; }
        }

        public int ŠtPorazov
        {
            get { return štPorazov; }
            set { štPorazov = value; }
        }

        public int ŠtNeodločenih
        {
            get { return štNeodločenih; }
            set { štNeodločenih = value; }
           
        }

        public int ŠtZmag
        {
            get { return štZmag; }
            set { štZmag = value; } 
        }

        public int ŠtTekem
        {
            get { return štTekem; }
            set { štTekem = value; }
           
        }
        public Moštvo()
        { }
        public Moštvo(string i)
        {
        ime=i;
        štTekem = 0;
        štZmag = 0; štNeodločenih = 0; štPorazov = 0; daniGoli = 0; prejetiGoli = 0;

        }
        public int ŠteviloTočk()
        {
            return štZmag * 3 + štNeodločenih;
        }
        public int GolRazlika()
        {
            return daniGoli - prejetiGoli;
        }
        public bool BoljšeMoštvo(Moštvo m)
        {
            if (ŠteviloTočk() > m.ŠteviloTočk())
                return true;
            if (ŠteviloTočk() == m.ŠteviloTočk())
            {
                if (GolRazlika() > m.GolRazlika())
                    return true;
                else
                    if (GolRazlika() == m.GolRazlika() & daniGoli > m.daniGoli)
                        return true;
            }
            return false;
                
        }
    }
}
