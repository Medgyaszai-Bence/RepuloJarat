using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teszteles
{
    class JaratKezelo
        {
        Jarat j = new Jarat();


            public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
            {

            List<Jarat> jaratok = new List<Jarat>();
          
           
                j.jarat = jaratSzam;             
                j.honnanRepter = repterHonnan;
                j.hovaRepter = repterHova;
                j.indulas = indulas;
            }

            public void Keses(string jaratSzam, int keses)
            {
                j.jarat = jaratSzam;
                j.keses = keses;
                if (keses < 0)
                {
                    throw new NegativKesesException(jaratSzam,keses);
                }
            }


            public DateTime MikorIndul(string jaratSzam)
            {

                DateTime dt = new DateTime();
                j.jarat = jaratSzam;
                j.indulas = dt;
                return dt;
            }

            public List<string> JaratokRepuloterrol(string repter)
            {

                List<string> jaratok = new List<string>();
                j.honnanRepter = repter;
                jaratok.Add(repter);
                return jaratok;
            }
        }

    class Jarat
    {

        public string jarat { get; set; }
        public string honnanRepter { get; set; }
        public string hovaRepter { get; set; }
        public DateTime indulas { get; set; }
        public int keses { get; set; }
    }
}
