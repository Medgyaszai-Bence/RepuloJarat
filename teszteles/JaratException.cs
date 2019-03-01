using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teszteles
{
    class NegativKesesException : Exception
    {
        public NegativKesesException(string jaratSzam,int keses)
            : base("A késés nem lehet negatív! Járat: " + jaratSzam + " Késés: " +keses )
        {
           
        }
    }
}
