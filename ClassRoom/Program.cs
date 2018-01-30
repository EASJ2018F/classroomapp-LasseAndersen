using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Studerende> klasseliste = new List<Studerende>();

            Studerende Lasse = new Studerende("Lasse", 21, 02);
            Studerende Peter = new Studerende("Peter", 21, 09);
            Studerende David = new Studerende("David", 15, 06);

            klasseliste.Add(Lasse);
            klasseliste.Add(Peter);
            klasseliste.Add(David);

            DateTime datetime = new DateTime(2017, 08, 28);

            KlasseRum klassen = new KlasseRum("3B", klasseliste, datetime);

            Console.WriteLine(klassen.ToString());
            Console.ReadLine();
        }
    }
}
