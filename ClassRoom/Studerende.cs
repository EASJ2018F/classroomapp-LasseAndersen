using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {
        public string Navn { get; }
        public int Fødselsdag { get; }
        public int Fødselsmåned { get; }

        public Studerende(string navn, int fødselsdag, int fødselsmåned)
        {
            Navn = navn;
            Fødselsdag = fødselsdag;
            Fødselsmåned = fødselsmåned;
        }


        string måned;

        public string Årstid()
        {
            if (Fødselsmåned == 12)
            {
                måned = "Vinter";
            }
            else if (Fødselsmåned == 01)
            {
                måned = ("Vinter");
            }
            else if (Fødselsmåned == 02)
            {
                måned = ("Vinter");
            }
            else if (Fødselsmåned == 03)
            {
                måned = ("Forår");
            }
            else if (Fødselsmåned == 04)
            {
                måned = ("Forår");
            }
            else if (Fødselsmåned == 05)
            {
                måned = ("Forår");
            }
            else if (Fødselsmåned == 06)
            {
                måned = ("Sommer");
            }
            else if (Fødselsmåned == 07)
            {
                måned = ("Sommer");
            }
            else if (Fødselsmåned == 08)
            {
                måned = ("Sommer");
            }
            else if (Fødselsmåned == 09)
            {
                måned = ("Efterår");
            }
            else if (Fødselsmåned == 10)
            {
                måned = ("Efterår");
            }
            else if (Fødselsmåned == 11)
            {
                måned = ("Efterår");
            }
            return måned;

        }


    }
}
