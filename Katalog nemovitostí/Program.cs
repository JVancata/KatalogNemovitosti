using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katalog_nemovitostí
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba("Jakub", "Opelka");
            osoba.Pohlavi = "chlapák";
            osoba.Narozeni = "2000-6-20";

            Console.WriteLine(osoba);
        }
    }
}
