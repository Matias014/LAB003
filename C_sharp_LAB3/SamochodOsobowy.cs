using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class SamochodOsobowy : Samochod
    {
        int IloscOsob;
        private double waga, pojemnoscsilnika;

        public double Waga //uzytkownik podaje wage w tonach
        {
            get { return waga; }
            set
            {
                if (value >= 2.0 && value <= 4.5)
                {
                    waga = value;
                }
                else
                {
                    waga = 0;
                }
            }
        }

        public double PojemnoscSilnika //uzytkownik podaje pojemnosc silnika w litrach
        {
            get { return pojemnoscsilnika; }
            set
            {
                if (value >= 0.8 && value <= 3.0)
                {
                    pojemnoscsilnika = value;
                }
                else
                {
                    pojemnoscsilnika = 0;
                }
            }
        }

        public SamochodOsobowy(string marka, string model, string nadwozie, string kolor, int rokProdukcji, double przebieg, double waga, double pojemnoscSilnika, int iloscOsob) : base(marka, model, nadwozie, kolor, rokProdukcji, przebieg)
        {
            Waga = waga;
            PojemnoscSilnika = pojemnoscSilnika;
            IloscOsob = iloscOsob;
        }

        public override void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine("Ilosc osob: " + IloscOsob + " Pojemnosc silnika: " + PojemnoscSilnika);
        }
    }
}
