using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Czasopismo:Pozycja
    {
        private int numer;

        public Czasopismo()
        {
        }

        //konstruktor parametryczny 
        public Czasopismo(int numer, string tytuł, int id, string wydawnictwo, int rokWydania)
            : base(tytuł, id, wydawnictwo, rokWydania)
        {
            this.numer = numer;
        }

        //metoda na wyposanie info
        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: {0}", tytul);
            Console.WriteLine("Numer: {0}", numer);
            Console.WriteLine("Nr katalogowy: {0}", id);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok wydaniwa: {0}", rokWydania);
        }
    }
}
