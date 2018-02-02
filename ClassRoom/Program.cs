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

            Studerende Lasse = new Studerende("Lasse", 21, 2);
            Studerende Peter = new Studerende("Peter", 21, 9);
            Studerende David = new Studerende("David", 15, 6);

            klasseliste.Add(Lasse);
            klasseliste.Add(Peter);
            klasseliste.Add(David);

            DateTime datetime = new DateTime(2017, 08, 28);

            KlasseRum klassen = new KlasseRum("3B", klasseliste, datetime);

            Console.WriteLine(klassen.KlasseNavn);
            Console.WriteLine(klassen.SemesterStart);
            foreach (var item in klasseliste)
            {
                Console.WriteLine(item.Navn);
            }

            
            var VinterUdskrives = (from student in klasseliste
                                  where klassen.Årstid(student.Fødselsmåned)
                                  == "Vinter"
                                  select student.Navn).Count();

            var SommerUdskrives = (from student in klasseliste
                                  where klassen.Årstid(student.Fødselsmåned)
                                  == "Sommer"
                                  select student.Navn).Count();

            var ForårUdskrives = (from student in klasseliste
                                  where klassen.Årstid(student.Fødselsmåned)
                                  == "Forår"
                                  select student.Navn).Count();

            var EfterårUdskrives = (from student in klasseliste
                                  where klassen.Årstid(student.Fødselsmåned)
                                  == "Efterår"
                                  select student.Navn).Count();

            Console.WriteLine("Student født i sommer måned : " + SommerUdskrives);
            Console.WriteLine("Student født i vinter måned : " + VinterUdskrives);
            Console.WriteLine("Student født i forår måned : " + EfterårUdskrives);
            Console.WriteLine("Student født i efterår måned : " + ForårUdskrives);

            Console.ReadLine();
        }
    }
}
