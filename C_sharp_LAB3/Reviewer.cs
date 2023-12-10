using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Reviewer : Reader
    {
        public Reviewer(string firstName, string lastName, int wiek, Book[] books) : base(firstName, lastName, wiek, books)
        {
            
        }

        public void Wypisz()
        {
            Random rand = new Random();

            for (int i = 0; i < ksiazki.Length; i++)
            {
                Console.WriteLine("Przeczytana ksiazka: " + ksiazki[i].title);
                Console.WriteLine($"Ocena: {rand.Next(10) + 1}/10");
            }
        }
    }
}
