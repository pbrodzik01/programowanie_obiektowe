//PATRYCJA BRODZIK
using System;
using System.Collections;
using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Collections.Generic;

namespace Programowanie_Obiektowe_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Zadanie 2
            Console.WriteLine("Zadanie 2: \n");

            #endregion

            #region Zadanie 3
            Student student = new Student("paszteciaż", 20);
            student.Display();
            student.read();
            Console.WriteLine();

            Driver driver = new Driver("kierowca", 34, "B");
            driver.Display();
            driver.drive();
            driver.Parking();
            Console.WriteLine();

            Employee employee = new Employee("pracownik", 27, "2.500");
            employee.Display();
            employee.getSalary();
            Console.WriteLine();

            Accountant accountant = new Accountant("księgowa", 29, "4.500");
            accountant.Display();
            //accountant.booking();
            Console.WriteLine();

            Manager manager = new Manager("menager", 32, "3.500");
            manager.Display();
            manager.setSalary("6.500");
            Console.WriteLine("Zmiana pensji na..." + manager.getSalary());
            manager.checkReport();
            Console.WriteLine();

            List<Employee> tabEmp = new();
            tabEmp.Add(employee);
            tabEmp.Add(accountant);
            tabEmp.Add(manager);

            foreach ( Employee emp in tabEmp)
            {
                Console.WriteLine(emp.getName());
            }
            tabEmp.Sort();

            Console.WriteLine("Element tablicy po posortowaniu: ");
            foreach (Employee sortemp in tabEmp)
            {
                Console.WriteLine(sortemp.getName());
            }
            #endregion

        }
    }

    #region Zadanie 2 - Class
    abstract public class Shape
    {
        private string color;
        public string getColor() { return color; }
        public void setColor(string color) { this.color = color; }

        public virtual void CalcArea() { }
        public virtual void CalcParamiter() { }
    }

    public class Triangle : Shape, InterfaceDraw, InterfaceSound
    {
        private int a;
        public int getA() { return a; }
        public void setA(int a) { this.a = a; }

        private int h;
        public int getH() { return h; }
        public void setH(int h) { this.h = h; }

        private double c;
        public double getC() { return c; }
        public void setC(double c) { this.c = c; }

        public override void CalcArea() => Console.WriteLine("Pole trójkąta: " + (getA() * getH()) / 2);
        public override void CalcParamiter()
        {
            c = Math.Sqrt(Math.Pow(getA(), 2) + Math.Pow(getH(), 2));
            Console.WriteLine("Obwód trójkąta: " + (getA() + getC() + getH()));
        }
        public void Draw() => Console.WriteLine("");
        public void play() => throw new NotImplementedException();
    }

    public class Circle : Shape, InterfaceDraw
    {
        private int radius;
        public int getRadius() { return radius; }
        public void setRadius(int radius) { this.radius = radius; }

        public override void CalcArea() => Console.WriteLine("Pole koła: " + Math.Round(Math.PI * Math.Pow(getRadius(), 2)), 2);
        public override void CalcParamiter() => Console.WriteLine("Obwód koła: " + Math.Round((2 * Math.PI * getRadius()), 2));
        public void Draw() => throw new NotImplementedException();
    }

    public class Quadrangle : Shape
    {
        private int a;
        public int getA() { return a; }
        public void setA(int a) { this.a = a; }

        public override void CalcArea() => Console.WriteLine("Pole czworoboku");
        public override void CalcParamiter() => Console.WriteLine("Obwód czworoboku");
    }

    public class Square : Quadrangle, InterfaceDraw
    {
        public override void CalcArea() => Console.WriteLine("Pole kwadratu: " + Math.Pow(getA(), 2));
        public override void CalcParamiter() => Console.WriteLine("Pole kwadratu: " + 4 * getA());
        public void Draw()
        {
            Console.Write('┌');
            for (int i = 0; i < getA() - 2; i++)
            {
                Console.Write('─');
            }
            Console.WriteLine('┐');

            for (int i = 0; i < getA() - 2; i++)
            {
                Console.Write('│');
                for (int j = 0; j < getA() - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine('│');
            }

            Console.Write('└');
            for (int i = 0; i < getA() - 2; i++)
            {
                Console.Write('─');
            }
            Console.WriteLine('┘');
        }
    }

    public class Rectangle : Quadrangle, InterfaceDraw
    {
        private int b;
        public int getB() { return b; }
        public void setB(int b) { this.b = b; }

        public override void CalcArea() => Console.WriteLine("Pole prostokąta: " + getA() * b);
        public override void CalcParamiter() => Console.WriteLine("Obwód prostokąta: " + 2 * (getA() + b));
        public void Draw()
        {
            Console.Write('┌');
            for (int i = 0; i < getA() - 2; i++)
            {
                Console.Write('─');
            }
            Console.WriteLine('┐');

            for (int i = 0; i < getB() - 2; i++)
            {
                Console.Write('│');
                for (int j = 0; j < getA() - 2; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine('│');
            }

            Console.Write('└');
            for (int i = 0; i < getA() - 2; i++)
            {
                Console.Write('─');
            }
            Console.WriteLine('┘');
        }
    }
    #endregion
    #region Zadanie 2 - Inferface
    interface InterfaceDraw
    {

        void Draw();
    }

    interface InterfaceSound
    {
        void play();
    }
    #endregion

    #region Zadanie 3 - Class
    abstract public class Person
    {
        private string name;
        public string getName() { return name; }
        public void setName(string name) { this.name = name; }

        private int age;
        public int getAge() { return age; }
        public void getAge(int age) { this.age = age; }

        public abstract void Display();

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        ~Person() { Console.WriteLine("Jestem destruktorem klasy Person"); }
    }

    public class Student : Person, IComparable
    {
        public void read()
        {
            Console.WriteLine("Read...");
        }
        public override void Display()
        {
            Console.WriteLine("STUDENT:");
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Age: " + getAge());
        }

        public Student(string name, int age) : base(name, age) { }

        ~Student() { Console.WriteLine("Jestem destruktorem klasy Student"); }
    }

    public class Driver : Person, IComparable
    {
        private string breed;
        public string getBreed() { return breed; }
        public void setBreed(string breed) { this.breed = breed; }

        public void drive()
        {
            Console.WriteLine("Drive...");
        }
        public void Parking()
        {
            Console.WriteLine("Parking...");
        }
        public override void Display()
        {
            Console.WriteLine("DRIVER:");
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Age: " + getAge());
            Console.WriteLine("Breed: " + getBreed());
        }

        public Driver(string name, int age, string breed) : base(name, age)
        {
            this.breed = breed;
        }

        ~Driver() { Console.WriteLine("Jestem destruktorem klasy Driver"); }
    }

    public class Employee : Person, IComparable
    {
        protected string salary;
        public string getSalary() { return salary; }

        public override void Display()
        {
            Console.WriteLine("EMPLOYEE:");
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Age: " + getAge());
            Console.WriteLine("Salary: " + getSalary());
        }

        public Employee(string name, int age, string salary) : base(name, age)
        {
            this.salary = salary;
        }

        ~Employee() { Console.WriteLine("Jestem destruktorem klasy Employee"); }
    }

    public class Accountant : Employee
    {
        private void booking()
        {
            Console.WriteLine("Booking...");
        }
        public override void Display()
        {
            Console.WriteLine("ACCOUNTANT:");
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Age: " + getAge());
            Console.WriteLine("Salary: " + getSalary());
        }

        public Accountant(string name, int age, string salary) : base(name, age, salary) { }

        ~Accountant() { Console.WriteLine("Jestem destruktorem klasy Accountant"); }
    }

    public class Manager : Employee
    {
        public void setSalary(string salary) { this.salary = salary; }

        public void checkReport()
        {
            Console.WriteLine("Check Report...");
        }
        public override void Display()
        {
            Console.WriteLine("MENAGER:");
            Console.WriteLine("Name: " + getName());
            Console.WriteLine("Age: " + getAge());
            Console.WriteLine("Salary: " + getSalary());
        }

        public Manager(string name, int age, string salary) : base(name, age, salary) { }

        ~Manager() { Console.WriteLine("Jestem destruktorem klasy Manager"); }
    }
    #endregion

    #region Zadanie 3 - Interface
    interface IComparable
    {
        void compareTo(object obj)
        {

        }
    }
    #endregion

}
