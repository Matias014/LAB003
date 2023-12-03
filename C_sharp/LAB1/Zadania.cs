using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Zadania
    {
        static void Main(string[] args)
        {
            //f_kwadratowa(1, 2, -4);
            //tablica_wyswietl();
            //f_licz();
            //f_wyswietl();
            //f_pytaj();
            f_sortuj();
        }

        //zadanie1
        static void f_kwadratowa(double a, double b, double c)
        {
            if (a == 0)
            {
                Console.WriteLine("To nie jest funkcja kwadratowa");
            }
            else
            {
                double delta = b * b - 4 * a * c;
                double x1, x2;

                if (delta < 0)
                {
                    Console.WriteLine("Brak rozwiazan w zbiorze liczb rzeczywistych");
                }
                else if (delta == 0)
                {
                    x1 = -b / (2 * a);
                    Console.WriteLine("Jedno miejsce zerowe: " + x1);
                }
                else
                {
                    x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("Dwa miejsca zerowe: " + x1 + " i " + x2);
                }
            }
        }

        //zadanie2


        //zadanie3
        static void tablica_wyswietl()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Podaj " + (i + 1) + " element: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Od pierwszego do ostatniego indeksu: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Od ostatniego do pierwszego indeksu: ");

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Wyswietlanie elementow o nieparzystych indeksach: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Wyswietlanie elementow o parzystych indeksach: ");

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(array[i] + " ");
                }
            }

            Console.WriteLine();
        }

        //zadanie4
        static void f_licz()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Podaj " + (i + 1) + " element: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int suma = 0, iloczyn = 1, min = array[0], maks = array[0];
            double srednia = 0;

            for (int i = 0; i < array.Length; i++)
            {
                suma += array[i];
                iloczyn *= array[i];

                if (array[i] < min)
                {
                    min = array[i];
                }

                if (array[i] > maks)
                {
                    maks = array[i];
                }
            }

            srednia = suma / 10.0;

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Iloczyn: " + iloczyn);
            Console.WriteLine("Srednia: " + srednia);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Maks: " + maks);
        }

        //zadanie5
        static void f_wyswietl()
        {
            for (int i = 20; i >= 0; i--)
            {
                if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }

        //zadanie6
        static void f_pytaj()
        {
            int liczba;

            while (true)
            {
                liczba = Convert.ToInt32(Console.ReadLine());

                if (liczba < 0)
                {
                    break;
                }
            }
        }

        //zadanie7
        static void f_sortuj()
        {
            int n;

            Console.WriteLine("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Podaj " + (i + 1) + " liczbe: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            //sortowanie bąbelkowe

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Po sortowaniu:");

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
