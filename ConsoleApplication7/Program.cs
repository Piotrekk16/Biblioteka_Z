using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            //przykładowy program testujacy korzystający w pelni z obiektówki
            Katalog bibliotekaOgolna = new Katalog("Dział ogólny");
            bibliotekaOgolna.DodajPozycje( "Krzyżacy", 23, "Znak", 2010, 220, "Henryk Sienkiewicz");
            bibliotekaOgolna.DodajPozycje("Chłopi", 31, "Greg", 2002, 310, "Władysław Reymont");
            bibliotekaOgolna.DodajPozycje(200, "Gazeta Olsztyńska", 123, "Edytor", 2016);
            bibliotekaOgolna.DodajPozycje("Krzyżacy", 24, "Znak", 2011, 220,"Henryk Sienkiewicz");

            //bibliotekaOgolna.WypiszWszystko();

            Console.WriteLine("Wyszukiwanie po tytule");
            bibliotekaOgolna.WyszukajPoTytule("Krzyżacy");

            Console.WriteLine("Wyszukiwanie po id");
            bibliotekaOgolna.WyszukajPoId(123);

            Console.ReadKey();
        }
    }
}
