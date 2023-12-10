using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class AdventureBook : Book
    {
        public int IleStron;
        public string wydawnictwo;

        public AdventureBook(string title, Person author, DateTime dataWydania, int ileStron, string wydawnictwo) : base(title, author, dataWydania)
        {
            IleStron = ileStron;
            this.wydawnictwo = wydawnictwo;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Ile stron: {this.IleStron}");
            Console.WriteLine($"Wydawnictwo: {this.wydawnictwo}");
            Console.WriteLine("Gatunek: fantasy");
        }
    }
}
