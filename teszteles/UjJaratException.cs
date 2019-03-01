using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teszteles
{
    class UjJaratException: Exception
    {
        public UjJaratException(string jaratSzam)
            : base("A járatszám nem lehet duplikát! Járat: " + jaratSzam)
        {
           
        }
    }
}
