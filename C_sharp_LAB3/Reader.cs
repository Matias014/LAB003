using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Reader : Person
    {
        public Book[] ksiazki;

        public Reader(string firstName, string lastName, int wiek, Book[] books) : base(firstName, lastName, wiek)
        {
            this.ksiazki = books;
        }

        public void ViewBook()
        {
            for (int i = 0; i < ksiazki.Length; i++)
            {
                Console.WriteLine("Przeczytana ksiazka: " + ksiazki[i].title);
            }
        }

        public override void View()
        {
            base.View();

            ViewBook();
        }
    }
}
