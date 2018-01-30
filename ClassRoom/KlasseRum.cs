using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class KlasseRum
    {

        public string KlasseNavn { get; set; }
        List<Studerende> Klasseliste;
        DateTime SemesterStart;

        public KlasseRum(string klassenavn, List<Studerende> klasseliste, DateTime semesterstart)
        {
            KlasseNavn = klassenavn;
            Klasseliste = klasseliste;
            SemesterStart = semesterstart;

        }

        //public KlasseRum(string klasseNavn, List<Studerende> klasseliste, DateTime semesterStart)
        //{
        //    KlasseNavn = klasseNavn;
        //    Klasseliste = klasseliste;
        //    SemesterStart = semesterStart;
        //}
    }
}
