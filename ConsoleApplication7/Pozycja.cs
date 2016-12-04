using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    abstract class Pozycja //klasa abstrakcyjna
    {
        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;

        //konstruktor domyslny
        public Pozycja() { }

        //konstruktor parametryczny
        public Pozycja(string tytul,int id,string wyd,int rok)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wyd;
            this.rokWydania = rok;
        }

        abstract public void WypiszInfo(); //deklaracja metody abstrakcyjnej

        //metoda pomocnicza do wyszukania po tytule
        public string PobierzTytul()
        {
            return tytul;
        }

        //metoda pomocnicza do wyszukania po id
        public int PobierzId()
        {
            return id;
        }
    }
}
