using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
   public class Studerende
    {
        private string _navn;
        private int _fødselsdag;
        private int _fødselsmåned;


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
