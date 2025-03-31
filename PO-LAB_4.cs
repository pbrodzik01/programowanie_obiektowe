using System;

namespace Programowanie_Obiektowe_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Zadanie 1
            Console.WriteLine("Zadanie 1: \n");

            Kitty bengal = new Kitty();
            Kitty persian = new Kitty("Bieluch", 5, "biały");
            Kitty klon = new Kitty(persian);

            bengal.name = "Miauczek";

            klon.SetAge(4);
            klon.SetName("Bieluch II");

            persian.Mew();

            Console.WriteLine("Kot bengalski ma na imie {0}, ma {1} lat, i {2} kolor.", bengal.GetName(), bengal.GetAge(), bengal.GetColor());
            Console.WriteLine("Kot perski ma na imie {0}, ma {1} lat, i {2} kolor.", persian.GetName(), persian.GetAge(), persian.GetColor());
            Console.WriteLine("Klon kota perskiego ma na imie {0}, ma {1} lat, i {2} kolor.", klon.GetName(), klon.GetAge(), klon.GetColor());
            Console.WriteLine("\n");
            #endregion

            #region Zadanie 2
            Console.WriteLine("Zadanie 2: \n");

            /*
            Animal animal = new Animal("animalia", 12);
            Console.WriteLine("Animal:");
            Console.WriteLine("Name: " + animal.getName());
            Console.WriteLine("Age: " + animal.getAge());
            animal.Eat();
            animal.Sleep();
            Console.WriteLine();
            */

            Fish fish = new Fish("piscis", 2);
            Console.WriteLine("Fish:");
            Console.WriteLine("Name: " + fish.getName());
            Console.WriteLine("Age: " + fish.getAge());
            fish.Eat();
            fish.Sleep();
            fish.Swim();
            Console.WriteLine();

            Bird bird = new Bird("avis", 3, "hummingbird");
            Console.WriteLine("Bird:");
            Console.WriteLine("Name: " + bird.getName());
            Console.WriteLine("Age: " + bird.getAge());
            Console.WriteLine("Breed: " + bird.getBreed());
            bird.Eat();
            bird.Sleep();
            bird.Fly();
            bird.Sing();
            Console.WriteLine();

            Mammal mammal = new Mammal("mammalian", 24, "white", 45.6);
            Console.WriteLine("Mammal:");
            Console.WriteLine("Name: " + mammal.getName());
            Console.WriteLine("Age: " + mammal.getAge());
            Console.WriteLine("Color: " + mammal.getColor());
            Console.WriteLine("Weight: " + mammal.getWeight());
            mammal.Eat();
            mammal.Sleep();
            mammal.Run();
            Console.WriteLine();

            Cat cat = new Cat("cattus", 8, "blue", 3.6);
            Console.WriteLine("Cat:");
            Console.WriteLine("Name: " + cat.getName());
            Console.WriteLine("Age: " + cat.getAge());
            Console.WriteLine("Color: " + cat.getColor());
            Console.WriteLine("Weight: " + cat.getWeight());
            cat.Eat();
            cat.Sleep();
            cat.Run();
            //cat.Cleaning(); 
            cat.Mew();
            Console.WriteLine();

            Dog dog = new Dog("canis", 4, "black", 34.5);
            Console.WriteLine("Dog:");
            Console.WriteLine("Name: " + dog.getName());
            Console.WriteLine("Age:" + dog.getAge());
            Console.WriteLine("Color: " + dog.getColor());
            Console.WriteLine("Weight: " + dog.getWeight());
            dog.Eat();
            dog.Sleep();
            dog.Run();
            dog.Bark();
            dog.Retrieve();
            Console.WriteLine("\n");
            #endregion

            #region Zadanie 3
            Console.WriteLine("Zadanie 3: \n");

            MojaMat.Read();
            MojaMat.myPow();
            MojaMat.mySqrt();
            Console.WriteLine("\n");
            #endregion

            #region Zadanie 4
            Console.WriteLine("Zadanie 4: \n");

            SecretClass secret = new SecretClass();
            secret.secretCode = "2137";
            secret.displayCode();
            #endregion
        }
    }

    #region Zadanie 1 - Class

    class Kitty
    {
        public string name;
        public string GetName() { return name; }
        public void SetName(string n) { name = n; }

        private int age;
        public int GetAge() { return age; }
        public void SetAge(int a) { age = a; }

        protected string color;
        public string GetColor() { return color; }
        public void SetColor(string a) { color = a; }

        public void Mew() => Console.WriteLine("Miaaauuuuu...");
        void Sleep() => Console.WriteLine("Zzz...");

        public Kitty() //kontruktor bez paramwtrów
        {
            Console.WriteLine("Konstruktor bez parametrów uruchomiony!");
            name = "Miauczek";
            age = 7;
            color = "szary";
        }
        public Kitty(string name, int age, string color) //konstruktor z 3 parametrami
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }
        public Kitty(Kitty k) //konstruktor kopiujący, który pobiera jako argument obiekt klasy Cat
        {
            name = k.name;
            age = k.age;
            color = k.color;
        }

        ~Kitty() => Console.WriteLine("Destruktor klasy Cat został uruchomiony!"); //To jest definicja destruktora
    }

    #endregion

    #region Zadanie 2 - Class

    abstract class Animal
    {
        protected string name;
        public string getName() { return name; }
        public void setName(string name) { this.name = name; }

        protected int age;
        public int getAge() { return age; }
        public void setAge(int age) { this.age = age; }

        public virtual void Eat() => Console.WriteLine("Animal...Eat");
        public void Sleep() => Console.WriteLine("Animal...Sleep");

        public Animal() => Console.WriteLine("I'm Animal");
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Animal(Animal a)
        {
            name = a.name;
            age = a.age;
        }
    }

    class Fish : Animal
    {
        public void Swim() => Console.WriteLine("Fish...Swim");
        public override void Eat() => Console.WriteLine("Fish...Eat");
        public new void Sleep() => Console.WriteLine("Fish...Sleep");

        public Fish() => Console.WriteLine("I'm Fish");
        public Fish(string name, int age) : base(name, age) {   }
        public Fish(Fish f) : base (f) {   }

        ~Fish() => Console.WriteLine("Jestem destruktorem klasy Fish");
    }

    class Bird : Animal
    {
        private string breed;
        public string getBreed() { return breed; }
        public void setBreed(string breed) { this.breed = breed; }

        public void Fly() => Console.WriteLine("Bird...Fly");
        public void Sing() => Console.WriteLine("Bird...Sing");
        public override void Eat() => Console.WriteLine("Bird...Eat");
        public new void Sleep() => Console.WriteLine("Bird...Sleep");

        public Bird() => Console.WriteLine("I'm bird");
        public Bird(string name, int age, string breed) : base(name, age) => this.breed = breed;
        public Bird(Bird b) : base(b) => breed = b.breed;

        ~Bird() { Console.WriteLine("Jestem destruktorem klasy Bird"); }
    }

    class Mammal : Animal
    {
        protected string color;
        public string getColor() { return color; }
        public void setColor(string color) { this.color = color; }

        protected double weight;
        public double getWeight() { return weight; }
        public void setWeight(double weight) { this.weight = weight; }

        public void Run() => Console.WriteLine("Mammal...Run");
        public override void Eat() => Console.WriteLine("Mammal...Eat");
        public new void Sleep() => Console.WriteLine("Zzz...");

        public Mammal() => Console.WriteLine("I'm Mammal");
        public Mammal(string name, int age, string color, double weight) : base(name, age)
        {
            this.color = color;
            this.weight = weight;
        }
        public Mammal(Mammal m) : base(m)
        {
            color = m.color;
            weight = m.weight;
        }

        ~Mammal() { Console.WriteLine("Jestem destruktorem klasy Mammal"); }
    }

    class Cat : Mammal
    {
        private void Cleaning() => Console.WriteLine("Cat...Cleaning");
        public void Mew() => Console.WriteLine("Cat...Mew");
        public override void Eat() => Console.WriteLine("Cat...Eat");

        public Cat() => Console.WriteLine("I'm Cat");
        public Cat(string name, int age, string color, double weight) : base(name, age, color, weight) {   }
        public Cat(Cat c) : base(c) {   }

        ~Cat() { Console.WriteLine("Jestem destruktorem klasy Cat"); }
    }

    class Dog : Mammal
    {
        public void Bark() => Console.WriteLine("Dog...Bark");
        public void Retrieve() => Console.WriteLine("Dog...Retrieve");
        public override void Eat() => Console.WriteLine("Dog...Eat");

        public Dog() => Console.WriteLine("I'm Dog");
        public Dog(string name, int age, string color, double weight) : base(name, age, color, weight) {   }
        public Dog(Dog d) : base(d) {   }

        ~Dog() { Console.WriteLine("Jestem destruktorem klasy Dog"); }
    }

    #endregion

    #region Zadanie 3 - Class

    class MojaMat
    {
        public static double x;

        public static void Read()
        {
            Console.Write("Podaj x: ");
            x = int.Parse(Console.ReadLine());
        }
        public static void myPow() => Console.WriteLine(x + " podniesione do kwadratu wynosi: " + Math.Pow(x, 2));
        public static void mySqrt() => Console.WriteLine($"pierwiastek kwadratowy z liczby {x} wynosi: " + Math.Sqrt(x));
    }

    #endregion

    #region Zadnaie 4 - Class
    sealed class SecretClass
    {
        public string secretCode;

        public void displayCode() => Console.WriteLine("Sekretny kod to: " + secretCode);
    }

    /*class Zdradz_kod : SecretClass
    {
        
    }
    */
    #endregion
}
