using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Liczba
    {
        int[] cyfry;

        public Liczba(string liczba)
        {
            int temp = Convert.ToInt32(liczba);
            cyfry = new int[liczba.Length];

            for (int i = 0; i < liczba.Length; i++)
            {
                cyfry[i] = Convert.ToInt32(liczba[i].ToString());
            }
        }

        public void Wypisz()
        {
            foreach (int i in this.cyfry)
            {
                Console.WriteLine(i);
            }
        }

        public void Mnoz(int mnoznik)
        {
            int przesuniecie = 0;
            int[] wynik = new int[cyfry.Length + mnoznik.ToString().Length];
            for (int i = cyfry.Length - 1; i >= 0; i--)
            {
                int iloczyn = cyfry[i] * mnoznik + przesuniecie;
                przesuniecie = iloczyn / 10;
                wynik[i + wynik.Length - cyfry.Length] = iloczyn % 10;
            }
            if (przesuniecie > 0)
            {
                wynik[wynik.Length - cyfry.Length - 1] = przesuniecie;
            }
            cyfry = wynik;
        }

        public int Silnia(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Silnia(n - 1);
        }
    }
}
