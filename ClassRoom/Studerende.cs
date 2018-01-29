using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Studerende
    {

        private string _navn;
        private int _fødselsdag;
        private int _fødselsmåned;


        public string navn { get; }
        public int fødselsdag { get; }
        public int fødselsmåned { get; }


        public Studerende(string navn, int fødselsdag, int fødselsmåned)
        {
            _navn = navn;
            _fødselsdag = fødselsdag;
            _fødselsmåned = fødselsmåned;
        }
    }
}
