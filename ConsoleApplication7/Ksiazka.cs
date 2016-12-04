using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Ksiazka:Pozycja
    {
        private int iloscStron;
        private string autor;

        //konstruktor domyslny
        public Ksiazka() { }

        //konstruktor parametryczny
        public Ksiazka(string tytul, int id, string wyd,int rok,int strony,string autor)
            :base(tytul,id,wyd,rok)
        {
            this.iloscStron = strony;
            this.autor = autor;
        }

        //metoda na wypisanie
        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: {0}",tytul);
            Console.WriteLine("Autor {0}",autor);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok wydania: {0}", rokWydania);
            Console.WriteLine("Numer id: {0}", id);
            Console.WriteLine("Ilość stron: {0}", iloscStron);
        }

    }
}
