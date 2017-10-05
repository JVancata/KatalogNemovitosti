using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog_nemovitostí
{
    class Rodina
    {
        private string jmeno;
        private List<Osoba> osoby = new List<Osoba>();
        public string Jmeno {
            get
            {
                return this.jmeno;
            }
            set
            {
                this.jmeno = value;
            }
        }
        public void AddOsoba(Osoba osoba)
        {
            this.osoby.Add(osoba);
        }
    }
}
