using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog_nemovitostí
{
    class Osoba
    {
        private string jmeno;
        private string prijmeni;
        private string pohlavi;
        private DateTime narozeni;

        public override string ToString()
        {
            return "Jméno: "+ this.jmeno + " Příjmení: "+ this.prijmeni + " Pohlaví: "+ this.pohlavi +" Narození: "+ this.narozeni.ToString();
        }

        private List<string> muzList = new List<string>()
        {
            "muz", "muž", "můž", "můz", "chlap", "chlapák", "chlapak", "chlapek", "chlápek", "chlapec", "man", "men", "obama", "typek", "guy", "gáj", "borec", "kluk", "mladej", "jinoch", "samec", "sameček", "penis"
        };
        private List<string> zenaList = new List<string>()
        {
            "žena", "zena", "slecna", "slečna" ,"pani", "paní", "madam", "holka", "borka", "mladá", "divka", "dívka", "děvče", "devce", "samice", "samička", "vagína"
        };

        public Osoba(string jmeno, string prijmeni)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
        }
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
        public string Prijmeni {
            get
            {
                return this.prijmeni;
            }
            set
            {
                this.prijmeni = value;
            }
        }
        public string Pohlavi {
            get
            {
                return this.pohlavi;
            }
            set
            {
                string input = value.ToLower();
                if (zenaList.Contains(input))
                {
                    this.pohlavi = "Žena";
                }
                else if (muzList.Contains(input))
                {
                    this.pohlavi = "Muž";
                }
                else
                {
                    this.pohlavi = "Jiné";
                }
            }
        }

        public string Narozeni
        {
            get
            {
                return this.narozeni.ToString();
            }
            set
            {
                this.narozeni = DateTime.Parse(value);
            }
            
        }
        
        /*public void SetPohlavi(string input)
        {
            input = input.ToLower();
            if (zenaList.Contains(input))
            {
                this.pohlavi = "Žena";
            }
            else if (muzList.Contains(input))
            {
                this.pohlavi = "Muž";
            }
            else
            {
                this.pohlavi = "Jiné";
            }
        }*/
        /*public void SetNarozeni(string input)
        {
            this.narozeni = DateTime.Parse(input);
        }
        */

    }
}
