using LAB3;

//zadanie1a
Person osoba = new Person("Jan", "Kowalski", 30);
Book ksiazka = new Book("Piekna milosc", osoba, new DateTime(2023,08,12));

/*osoba.View();
ksiazka.View();*/


//zadanie1b

Person[] czytelnicy = new Person[]
{
    new Person("Adam", "Glowacki", 20),
    new Person("Adrianna", "Mucha", 10)
};

Book[] ksiazki = new Book[]
{
    new Book("Krol Artur", osoba, new DateTime(2023,08,12)),
    new Book("Krol Artur II", czytelnicy[0], new DateTime(2023,08,12)),
    new Book("Krol Artur III", czytelnicy[1], new DateTime(2023,08,12))
};

/*Reader czytelnik = new Reader("Krzysztof", "Bac", 20, ksiazki);
czytelnik.ViewBook();
Reader czytelnik2 = new Reader("Joanna", "Bac", 20, ksiazki);
czytelnik2.ViewBook();*/


//zadanie1c

//czytelnik.View();

//zadanie1d

Book[] ksiazka2 = new Book[]
{
    new Book("Bajki", new Person("Ignacy", "Krasicki", 60), new DateTime(1779, 1, 1))
};

Person o = new Reader("Mateusz", "Sondej", 22, ksiazka2);
//o.View();

//zadanie1f

Reviewer recenzent1 = new Reviewer("Lukasz", "Balut", 50, ksiazki);
Reviewer recenzent2 = new Reviewer("Monika", "Agrest", 55, ksiazki);

/*recenzent1.Wypisz();
recenzent2.Wypisz();*/

//zadanie1g

List<Person> listaOsob = new List<Person>();
listaOsob.Add(o);
listaOsob.Add(recenzent1);

/*for (int i = 0; i < listaOsob.Count; i++)
{
    listaOsob[i].View();
}*/

//zadanie1h

DocumentaryBook ob1 = new DocumentaryBook("Zycie koczownikow w Amazonce", czytelnicy[0], new DateTime(1950, 12, 5), 400, "NowySwiat");
AdventureBook ob2 = new AdventureBook("Przygody w Afryce", czytelnicy[1], new DateTime(1930, 5, 3), 250, "NowySwiat");

//ob1.View();
//ob2.View();

//************************************************zadanie2

Samochod o1 = new Samochod("Ford", "Focus mk2", "example", "brazowy", 2008, 150000);
Samochod o2 = new Samochod("Fiat", "Punto", "example", "bialy", 2008, 150000);
SamochodOsobowy o3 = new SamochodOsobowy("Kia", "Picanto", "example", "czerwony", 2008, 150000, 3.0, 1.2, 5);
SamochodOsobowy o4 = new SamochodOsobowy("Opel", "Astra H", "example", "srebrny", 2005, 150000, 3.0, 1.7, 5);

//o1.Wypisz();
//o2.Wypisz();
//o3.Wypisz();
//o4.Wypisz();