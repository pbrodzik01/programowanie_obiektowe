//Patrycja Brodzik
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;

namespace Programowanie_Obiektowe_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Zadanie 1
            Console.WriteLine("Zadanie 1: Proszę skompilować i uruchomić przykładowy program dla klasy Cat.");

            Cat bengal = new Cat();
            Cat persian = new Cat("Bieluch", 5, "biały");
            Cat klon = new Cat(persian);

            bengal.name = "Miauczek";
            klon.SetAge(4);
            klon.SetName("Bieluch II");

            Console.WriteLine();
            persian.Mew();
            Console.WriteLine();

            Console.WriteLine("Kot bengalski ma na imie {0}, ma {1} lat i {2} kolor", bengal.GetName(), bengal.GetAge(), bengal.GetColor());
            Console.WriteLine("Kot perski ma na imie {0}, ma {1} lat i {2} kolor", persian.GetName(), persian.GetAge(), persian.GetColor());
            Console.WriteLine("Klon kota perskiego ma na imie {0}, ma {1} lat i {2} kolor", klon.GetName(), klon.GetAge(), klon.GetColor());
            #endregion

            #region Zadanie 2
            Console.WriteLine("\n\nZadanie 2: Stwórz klasę Dog i jej trzy obiekty spaniel, bulldog i jamnik. Utwórz pola name, age, weight, oraz metody dostępu do tych pól typu Set oraz Get. Utwórz metodę szczekaj (Bark). Stwórz konstruktory bezparametrowy, trójparametrowy oraz kopiujący obiekt typu pieg (Dog). W metodzie Main wyświetl dane psów.");
            
            Dog spaniel = new Dog();
            Dog bulldog = new Dog("Azor", 3, 12.5);
            Dog jamnik = new Dog(spaniel);

            jamnik.SetName("Mili");
            jamnik.SetWeight(16);

            Console.WriteLine();
            jamnik.Bark();
            Console.WriteLine();

            Console.WriteLine($"Spaniel nazywa się {spaniel.GetName()}, ma {spaniel.GetAge()} lat i waży {spaniel.GetWeight()} kg.");
            Console.WriteLine($"Bulldog nazywa się {bulldog.GetName()}, ma {bulldog.GetAge()} lat i waży {bulldog.GetWeight()} kg.");
            Console.WriteLine($"Jamnik nazywa się {jamnik.GetName()}, ma {jamnik.GetAge()} lat i waży {jamnik.GetWeight()} kg.");
            #endregion

            #region Zadanie 3
            Console.WriteLine("\n\nZadanie 3: Stwórz klasę Student z polami o nazwie id, imie, nazwisko i grupa. Przygotuj metodę Display, która wyświetli wszystkie dane studenta.");
            
            Student s1 = new Student();
            s1.SetId(50708);
            s1.SetImie("Patrycja");
            s1.SetNazwisko("Brodzik");
            s1.SetGrupa(10);

            Student s2 = new Student();
            s2.SetId(10051);
            s2.SetImie("Student");
            s2.SetNazwisko("Debil");
            s2.SetGrupa(10);

            Console.WriteLine();
            s1.Display();
            s2.Display();
            #endregion

            #region Zadanie 4
            Console.WriteLine("\nZadanie 4: Utwórz klasę o nazwie Moneybox (Skarbonka). Klasa powinna zawierać funkcje składowe do wrzucania pieniędzy insertMoney oraz do rozbicia skarbonki breakMoneybox. Metoda insertMoney powiększa zawartość skarbonki o wrzuconą kwotę. Metoda breakMoneybox powinna zwracać sumę zgromadzonych środków i wyzerować stan skarbonki. Stworzyć konstruktor ustawiający wartość początkową skarbonki na 0.");
            char decyzja;

            Monebox skarbuś = new Monebox();
            Console.WriteLine();

            while (true)
            {                
                Console.WriteLine("Jaką akcję chcesz wykonać: ");
                Console.WriteLine("+ - Wrzuć monety");
                Console.WriteLine("= - Opróżnij skarbonkę");
                Console.WriteLine("! - Zakończ ");

                decyzja = char.Parse(Console.ReadLine());
                
                if (decyzja == '+') skarbuś.insertMoney();
                else if (decyzja == '=') skarbuś.breakMoneybox();
                else if (decyzja == '!') break;
                else Console.WriteLine("Coś poszło nie tak, proszę spróbować ponownie...");                
            }
            #endregion

            #region Zadanie 5
            Console.WriteLine("\n\nZadanie 5: Napisz klasę o nazwie Circle (okrąt), która zawiera parametr promien oraz metody do obliczenia obwodu parimeter() oraz powierzchni area()");
            
            Circle koło = new Circle();
            Console.Write("\nPodaj promień koła: ");
            koło.SetPromień(double.Parse(Console.ReadLine()));
            koło.paramiter();
            koło.area();
            #endregion

            #region Zadanie 6
            Console.WriteLine("\nZadanie 6: Napisz zgodnie z zasadami programowania obiektowego program, który oblicza pole i powierzchnię prostopadłościanu. Klasa Cuboid (prostopadłościan) powinna zawierać długości boków a, b oraz c, zmienne area (pole) i volume (objętość).");

            Cuboid prostopadłościan = new Cuboid();
            Console.WriteLine();
            prostopadłościan.readData();
            Console.WriteLine();
            prostopadłościan.calcArea();
            prostopadłościan.calcVolume();
            #endregion

            #region Zadanie 7
            Console.WriteLine("\n\nZadanie 7: Zdefiniować klasę DVD. Utworzyć 10-elementową tablicę obiektów klasy do przechowywania informacji o płytach DVD (director, title, year, genre). Klasa musi zawierać metody set i get dla wszystkich pól danych oraz funkcje wczytującą i wyświetlającą dane. Program powinien w pętli wpisywać dane do tablicy obiektów i w kolejnej pętli wypisać informacje dla wszystkich pozycji na ekranie. ");
            DVD[] półka = new DVD[10];
            Console.WriteLine();

            for (int i = 0; i < półka.Length; i++)
            {
                półka[i] = new DVD();
                półka[i].Read();
                Console.WriteLine();
            }

            Console.WriteLine("Trrrt... Trwa wypiswanie płyt...");
            for (int i = 0; i < półka.Length; i++)
            {
                półka[i].Display();
                Console.WriteLine();
            }
            #endregion

            #region Zadanie 8
            Console.WriteLine("\nZadanie 8: Napisz klasę, która znajdzie w zadanym zestawie trzy liczby, które sumują się do zera.Przykładowe dane: [-25, -10, -7, -3, 2, 4, 8, 10] Wynik: [[-10, 2, 8], [-7, -3, 10]]\n");
            Zestaw zestaw = new Zestaw();
            zestaw.Read_Display();
            #endregion

            #region Zadanie 9
            Console.WriteLine("Zadanie 9: Utwórz klasę o nazwie Counter (licznik), której zadaniem jest sprawdzanie na bramce liczby osób w budynku. Klasa powinna zawierać metody do pojedynczego zwiększania i zmniejszania liczby osób incNr oraz cecNr jak również funkcję wewnętrzną checkNr sprawdzającą bieżącą liczbę osób. Proszę stworzyć konstruktor ustawiający wartość początkową licznika na 0.");

            Counter licz1 = new Counter();
            bool stop = true;

            while (stop == true)
            {
                char osoba = char.Parse(Console.ReadLine());

                switch (osoba)
                {
                    case '+':
                        Console.WriteLine("Osoba weszła");
                        licz1.IncNr();
                        break;
                    case '-':
                        Console.WriteLine("Osoba wyszła");
                        licz1.DecNr();
                        break;
                    case '=':
                        Console.WriteLine("Stan osób w budynku: {0}", licz1.ChecNr());
                        break;
                    default:
                        stop = false;
                        break;
                }
            }
            #endregion
        }
    }

    public class Cat
    {
        public string name;
        public string GetName() { return name; }
        public void SetName(string n) { name = n; }

        private int age;
        public int GetAge() { return age; }
        public void SetAge(int a) { age = a; }

        protected string color;
        public string GetColor() { return color; }
        public void SetColor(string c) { color = c; }

        public void Mew() { Console.WriteLine("Miaaauuuuu"); }
        void Sleep() { Console.WriteLine("Zzz..."); }

        public Cat()
        {
            Console.WriteLine("Konstruktor bez parametrów uruchomiony!");
            name = "Miauczek";
            age = 7;
            color = "szary";
        }
        public Cat(string n, int a, string c)
        {
            name = n;
            age = a;
            color = c;
        }
        public Cat(Cat c)
        {
            name = c.name;
            age = c.age;
            color = c.color;
        }
    }

    public class Dog
    {
        protected string name;
        public string GetName() { return name; }
        public void SetName(string n) { name = n; }

        protected int age;
        public int GetAge() { return age; }
        public void SetAge(int a) { age = a; }

        protected double weight;
        public double GetWeight() { return weight; }
        public void SetWeight(double w) { weight = w; }

        public void Bark() { Console.WriteLine("Woof Woof Woof..."); }

        public Dog()
        {
            Console.WriteLine("Konstruktor bez parametrów uruchomiony!");
            name = "Doggy";
            age = 8;
            weight = 24;
        }
        public Dog(string n, int a, double w)
        {
            name = n;
            age = a;
            weight = w;
        }
        public Dog(Dog d)
        {
            name = d.name;
            age = d.age;
            weight = d.weight;
        }
    }

    public class Student
    {
        protected int id;
        public void SetId(int id) { this.id = id; }

        protected string imie;
        public void SetImie(string imie) { this.imie = imie; }

        protected string nazwisko;
        public void SetNazwisko(string nazwisko) { this.nazwisko = nazwisko; }

        protected int grupa;
        public void SetGrupa(int grupa) { this.grupa = grupa; }

        public void Display()
        {
            Console.WriteLine($"ID studenta: {id}");
            Console.WriteLine($"Imię: {imie}");
            Console.WriteLine($"Nazwisko: {nazwisko}");
            Console.WriteLine($"Grupa: {grupa}");
            Console.WriteLine();
        }
    }

    public class Monebox
    {
        protected double Money;

        public Monebox()
        {
            Money = 0;
        }

        public void insertMoney()
        {
            Console.WriteLine($"Aktualny stan skarbonki: {Money}");
            Console.Write("Ile pieniędzy chcesz wrzucić: ");
            Money += double.Parse(Console.ReadLine());
            Console.Write("Brzdęk...");
        }

        public void breakMoneybox()
        {
            Console.WriteLine($"Aktualny stan skarbonki: {Money}");
            Console.WriteLine($"!BOOM!");
            Money = 0;
            Console.WriteLine($"Skarbonka opróżniona, aktualny stan: {Money}");
        }

    }

    public class Circle
    {
        protected double promień;
        public double GetPromień() { return promień; }
        public void SetPromień(double promień) { this.promień = promień; }

        public void paramiter()
        {
            double obwód = Math.Round(2 * Math.PI * promień, 2);
            Console.WriteLine($"Obwód koła o promieniu {promień} wynosi: {obwód}\n");
        }

        public void area()
        {
            double pole = Math.Round(Math.PI * Math.Pow(promień, 2), 2);
            Console.WriteLine($"Pole koła o promieniu {promień} wynosi: {pole}\n");
        }
    }

    public class Cuboid
    {
        protected double a;
        protected double b;
        protected double c;

        protected double area;
        protected double volume;

        public void readData()
        {
            Console.Write("Podaj długość boku a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj długość boku b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Podaj długość boku c: ");
            c = int.Parse(Console.ReadLine());
        }

        public void calcVolume()
        {
            volume = a * b * c;
            Console.WriteLine("Objętość prostopadłościanu wynosi: " + volume);
        }

        public void calcArea()
        {
            area = 2*a*b + 2*a*c + 2*b*c;
            Console.WriteLine("Pole prostopadłościanu wynosi: " + area);
        }
    }

    public class DVD
    {
        protected string director;
        public string GetDirector() { return director; }
        public void SetDirector(string director) { this.director = director; }

        protected string title;
        public string GetTitle() { return title; }
        public void SetTitle(string title) { this.title = title; }

        protected int year;
        public int GetYear() { return year; }
        public void SetYear(int year) { this.year = year; }

        protected string genre;
        public string GetGenre() { return genre; }
        public void SetGenre(string genre) { this.genre = genre; }

        public void Read()
        {
            Console.Write("Director: ");
            director = Console.ReadLine();
            Console.Write("Title: ");
            title = Console.ReadLine();
            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Genre: ");
            genre = Console.ReadLine();
        }

        public void Display()
        {
            Console.Write($"Director: {director}\n");
            Console.Write($"Title: {title}\n");
            Console.Write($"Year: {year}\n");
            Console.Write($"Genre: {genre}\n");
        }
    }

    public class Zestaw
    {
        public void Read_Display()
        {
            Console.Write("Podaj wielkość zestawu: ");
            int wielkość = int.Parse(Console.ReadLine());

            int[] zbiór = new int[wielkość];

            for (int i = 0; i < wielkość; i++)
            {
                Console.Write("Podaj liczbę: ");
                zbiór[i]= int.Parse(Console.ReadLine());
            }
        
            Console.Write("Zawartość zestawu: ");
            for (int i = 0; i < zbiór.Length; i++)
            {
                Console.Write(zbiór[i] + " ");
            }
            Console.WriteLine();

            int suma = 0;
            Console.WriteLine("Liczby które sumują się do zera: ");
            for (int i = 0; i < zbiór.Length - 2; i++)
            {
                suma += zbiór[i];
                for (int j = 1; j < zbiór.Length - 1; j++)
                {
                    suma += zbiór[j];
                    for (int k = 2; k < zbiór.Length; k++)
                    {
                        suma += zbiór[k];
                        if (suma == 0) { Console.WriteLine($" [{zbiór[i]}, {zbiór[j]}, {zbiór[k]}] "); suma -= zbiór[k]; }
                        else suma -= zbiór[k];
                    }
                    suma -= zbiór[j];
                }
                suma -= zbiór[i];
            }
        }
    }

    public class Counter
    {
        public int licznik;

        public Counter()
        {
            Console.WriteLine("Stan osób w budynku: 0");
            licznik = 0;
        }

        public void IncNr() { licznik++; }
        public void DecNr() { licznik--; }
        public int ChecNr() { return licznik; }
    }
}
