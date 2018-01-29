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
    }
}
