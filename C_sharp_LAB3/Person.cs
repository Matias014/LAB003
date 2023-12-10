using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    public class Person
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private int Wiek { get; set; }

        public Person(string firstName, string lastName, int wiek)
        {
            FirstName = firstName;
            LastName = lastName;
            Wiek = wiek;
        }

        public virtual void View()
        {
            Console.WriteLine($"Imie: {FirstName}, nazwisko: {LastName}, wiek: {Wiek}");
        }
    }
}
