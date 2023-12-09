using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Sumator
    {
        public int[] Liczby;

        public int Suma()
        {
            int suma = 0;

            foreach (int i in Liczby)
            {
                suma += i;
            }

            return suma;
        }

        public int SumaPodziel2()
        {
            int suma = 0;

            foreach (int i in Liczby)
            {
                if (i % 2 == 0)
                {
                    suma += i;
                }
            }

            return suma;
        }

        public void Wypisz()
        {
            foreach (int i in Liczby)
            {
                Console.Write(i + " ");
            }
        }

        public void Wypisz2(int lowIndex, int highIndex)
        {
            for (int i = 0; i < Liczby.Length; i++)
            {
                if (i >= lowIndex && i <= highIndex)
                {
                    Console.WriteLine(this.Liczby[i]);
                } else
                {
                    continue;
                }
            }
        }
    }
}
