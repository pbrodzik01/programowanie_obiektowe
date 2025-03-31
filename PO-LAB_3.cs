using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace Programowanie_Obiektowe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Zadanie 1
            Console.WriteLine("Zadanie 1: \n");

            Base obj1 = new Base();
            Derived obj2 = new Derived();

            obj1.Display();
            obj2.Display();

            Base obj3 = (Base)obj2;
            obj3.Display();
            #endregion

            #region Zadanie 2
            Console.WriteLine("\n\nZadanie 2: \n");

            Animal animal = new Animal("animalia", 12);
            Console.WriteLine("Animal:");
            Console.WriteLine("Name: " + animal.getName());
            Console.WriteLine("Age: " + animal.getAge());
            animal.Eat();
            animal.Sleep();
            Console.WriteLine();

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
            #endregion

            #region Zadanie 3
            Console.WriteLine("\n\nZadanie 3: \n");

            Console.WriteLine("***TRIANGLE*** ");
            Triangle triangle1 = new Triangle(3, 4);
            triangle1.Area();
            triangle1.Circuit();
            Console.WriteLine();

            Console.WriteLine("***CIRCLE*** ");
            Circle circle1 = new Circle(8);
            circle1.Area();
            circle1.Circuit();
            Console.WriteLine();

            Console.WriteLine("***SQUARE*** ");
            Square square1 = new Square(4);
            square1.Area();
            square1.Circuit();
            Console.WriteLine();

            Console.WriteLine("***RECTANGLE*** ");
            Rectangle rectangle1 = new Rectangle(5, 3);
            rectangle1.Area();
            rectangle1.Circuit();
            #endregion

        }
    }

    #region Zadanie 1 - Class

    public class Base
    {
        public virtual void Display() => Console.WriteLine("Metoda Display klasy bazowej.");
    }

    public class Derived : Base
    {
        public override void Display() => Console.WriteLine("Metoda Display klasy pochodnej.");
    }

    #endregion

    #region Zadanie 2 - Class

    public class Animal
    {
        private string name;
        public string getName() { return name; }
        public void setName(string n) { name = n; }

        private int age;
        public int getAge() { return age; }
        public void setAge(int a) { age = a; }

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

    public class Fish : Animal
    {
        public void Swim() => Console.WriteLine("Fish...Swim");
        public override void Eat() => Console.WriteLine("Fish...Eat");
        public new void Sleep() => Console.WriteLine("Fish...Sleep");

        public Fish() => Console.WriteLine("I'm Fish");
        public Fish(string name, int age) : base(name, age) {   }
        public Fish(Fish f) : base(f) {   }
    }

    public class Bird : Animal
    {
        private string breed;
        public string getBreed() { return breed; }
        public void setBreed(string br) { breed = br; }

        public void Fly() => Console.WriteLine("Bird...Fly");
        public void Sing() => Console.WriteLine("Bird...Sing");
        public override void Eat() => Console.WriteLine("Bird...Eat");
        public new void Sleep() => Console.WriteLine("Bird...Sleep");

        public Bird() => Console.WriteLine("I'm Bird");
        public Bird(string name, int age, string breed) : base(name, age) => this.breed = breed;
        public Bird(Bird b) : base(b) => breed = b.breed;
    }

    public class Mammal : Animal
    {
        private string color;
        public string getColor() { return color; }
        public void setColor(string c) { color = c; }

        private double weight;
        public double getWeight() { return weight; }
        public void setWeight(double w) { weight = w; }

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
    }

    public class Cat : Mammal
    {
        private void Cleaning() => Console.WriteLine("Cat...Cleaning");
        public void Mew() => Console.WriteLine("Cat...Mew");
        public override void Eat() => Console.WriteLine("Cat...Eat");

        public Cat() => Console.WriteLine("I'm Cat");
        public Cat(string name, int age, string color, double weight) : base(name, age, color, weight) {   }
        public Cat(Cat c) : base(c) {   }
    }

    public class Dog : Mammal
    {
        public void Bark() => Console.WriteLine("Dog...Bark");
        public void Retrieve() => Console.WriteLine("Dog...Retrieve");
        public override void Eat() => Console.WriteLine("Dog...Eat");

        public Dog() => Console.WriteLine("I'm Dog");
        public Dog(string name, int age, string color, double weight) : base(name, age, color, weight) {   }
        public Dog(Dog d) : base(d) {   }
    }

    #endregion

    #region Zadanie 3 - Class

    public class Shape
    {
        protected string color;
        public string GetColor() { return color; }
        public void SetColor(string color) { this.color = color; }
        public virtual void Area() => Console.Write("Pole figur:   ");
        public virtual void Circuit() => Console.Write("Obwód figury:   ");
    }

    public class Triangle : Shape
    {
        private int a;
        private int h;
        private double c;
        public Triangle(int a, int h)
        {
            this.a = a;
            this.h = h;
        }
        public override void Area()
        {
            base.Area();
            Console.WriteLine((a * h) / 2);
        }
        public override void Circuit()
        {
            base.Circuit();
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(h, 2));
            Console.WriteLine(a + c + h);
        }
    }

    public class Circle : Shape
    {
        private int radius;
        public Circle(int radius) => this.radius = radius;
        public override void Area()
        {
            base.Area();
            Console.WriteLine(Math.Round(Math.PI * Math.Pow(radius, 2), 2));
        }
        public override void Circuit()
        {
            base.Circuit();
            Console.WriteLine(Math.Round((2 * Math.PI * radius), 2));
        }
    }

    public class Quadrangle : Shape
    {
        protected int a;
        public Quadrangle(int a) => this.a = a;        
        public override void Area() => Console.WriteLine("Pole czworoboku:   ");
        public override void Circuit() => Console.WriteLine("Obwód czworoboku:   ");
    }

    public class Square : Quadrangle
    {
        public Square(int a) : base (a) {   }
        public override void Area()
        {
            base.Area();
            Console.WriteLine(Math.Pow(a, 2));
        }
        public override void Circuit()
        {
            base.Circuit();
            Console.WriteLine(4 * a);
        }
    }

    public class Rectangle : Quadrangle
    {
        private int b;
        public Rectangle(int a, int b) : base(a) => this.b = b;
        public override void Area()
        {
            base.Area();
            Console.WriteLine(a * b);
        }
        public override void Circuit()
        {
            base.Circuit();
            Console.WriteLine(2 * (a + b));
        }
    }

    #endregion
}
