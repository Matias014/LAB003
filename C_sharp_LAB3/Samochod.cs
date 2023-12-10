using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Samochod
    {
        public string Marka, Model, Nadwozie, Kolor;
        public int RokProdukcji;
        private double przebieg;

        public double Przebieg
        {
            get { return przebieg; }
            set 
            { 
                if (value < 0)
                {
                    przebieg = 0;
                }
                else
                {
                    przebieg = value;
                }
            }
        }


        public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, double przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rokProdukcji;
            Przebieg = przebieg;
        }

        public virtual void Wypisz()
        {
            Console.WriteLine("Samochod: " + Marka + " " + Model + " " + Nadwozie + " " + Kolor + " " + RokProdukcji + " " + Przebieg);
        }
    }
}
