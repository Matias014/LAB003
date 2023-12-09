using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Licz
    {
        private int value;

        public void Dodaj(int val)
        {
            this.value += val;
        }

        public void Odejmij(int val)
        {
            this.value -= val;
        }

        public Licz(int value)
        {
            this.value = value;
        }

        public override string? ToString()
        {
            return $"Wartosc value: {value}";
        }
    }
}
