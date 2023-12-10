using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class DocumentaryBook : Book
    {
        public int IleStron;
        public string wydawnictwo;

        public DocumentaryBook(string title, Person author, DateTime dataWydania, int IleStron, string wydawnictwo) : base(title, author, dataWydania)
        {
            this.IleStron = IleStron;
            this.wydawnictwo = wydawnictwo;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Ile stron: {this.IleStron}");
            Console.WriteLine($"Wydawnictwo: {this.wydawnictwo}");
            Console.WriteLine("Gatunek: dokument/reportaz");
        }
    }
}
