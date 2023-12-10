using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Book
    {
        public string title;
        public Person author;
        public DateTime dataWydania;

        public Book(string title, Person author, DateTime dataWydania)
        {
            this.title = title;
            this.author = author;
            this.dataWydania = dataWydania;
        }

        public virtual void View()
        {
            Console.WriteLine($"Tytul: {title}, autor: ");
            author.View();
            Console.WriteLine($", dataWydania: {dataWydania.ToShortDateString()}");
        }
    }
}
