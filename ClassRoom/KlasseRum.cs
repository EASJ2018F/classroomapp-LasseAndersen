using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class KlasseRum
    {
        private string _klassenavn;
        private List<Studerende> _klasseliste;
        private DateTime _semesterstart;

        public string KlasseNavn
        {
            get
            {
                return _klassenavn;
            }
            set
            {
                _klassenavn = value;
            }
        }
        public List<Studerende> Klasseliste
        {
            get
            {
                return _klasseliste;
            }
            set
            {
                _klasseliste = value;
            }
        }
        public DateTime SemesterStart
        {
            get
            {
                return _semesterstart;
            }
            set
            {
                _semesterstart = value;
            }
        }

        public KlasseRum(string klassenavn, List<Studerende> klasseliste, DateTime semesterstart)
        {
            KlasseNavn = klassenavn;
            Klasseliste = klasseliste;
            SemesterStart = semesterstart;

        }

      public string Årstid(int fødselsdagsmåned)
        {
            if (fødselsdagsmåned == 12 || fødselsdagsmåned == 1 || fødselsdagsmåned == 2)
            {
                return "Vinter";
            }
            else if (fødselsdagsmåned == 3 || fødselsdagsmåned == 4 || fødselsdagsmåned == 5)
            {
                return "Forår";
            }
            else if (fødselsdagsmåned == 6 || fødselsdagsmåned == 7 || fødselsdagsmåned == 8)
            {
                return "Sommer";
            }
            else if (fødselsdagsmåned == 9 || fødselsdagsmåned == 10 || fødselsdagsmåned == 11)
            {
                return "Efterår";
            }
            return "nixen bixen karen blixen";
        }
    }
}
