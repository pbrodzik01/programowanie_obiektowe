//Patrycja Brodzik

using Kolokwium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace Kolokwium
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vehicle vehicle = new Vehicle();      Nie można stworzyć obiektu klasy typu abstrakcyjnego 

            Carriage carriage = new Carriage();
            Console.WriteLine("***   CARRIAGE   ***");
            carriage.harnessing();
            carriage.drive();

            // MotorVehicle motorVehicle = new MotorVehicle();      Nie można stworzyć obiektu klasy typu abstrakcyjnego

            Bicycle bicycle = new Bicycle();
            Console.WriteLine("\n***   BICYCLE   ***");
            // bicycle.sightseeing();       prywatna funkcja klasy
            bicycle.drive();

            Truck truck = new Truck();
            Console.WriteLine("\n\n***   TRUCK   ***");
            truck.truckUnloading();
            truck.drive();

            Car car_test = new Car("BMW", 4, 250, "coupes");
            Console.WriteLine("\n\n***   CAR   ***");
            Console.WriteLine($"Manufacturer: {car_test.get_manufacturer()},   Num wheels: {car_test.get_numWheels()},   Horsepower: {car_test.get_horsepower()},   Body type: {car_test.get_bodyType()}");
            car_test.startEngine();
            car_test.refueling();
            car_test.drifting();
            car_test.drive();

            Console.WriteLine("\n\nZadanie 4: ");
            Car Celica = new Car("Celica", 4, 250, "coupes");
            Car Kompot = new Car("Kompot", 4, 250, "coupes");
            Car Golf = new Car("Golf", 4, 250, "coupes");
            Car BMW = new Car("BMW", 4, 250, "coupes");
            Car Miota = new Car("Miota", 4, 250, "coupes");
            Car Giulietta = new Car("Giulietta", 4, 250, "coupes");
            Car Mustang = new Car("Mustang", 4, 250, "coupes");
            Car Audi_TT = new Car("Audi_TT", 4, 250, "coupes");
            Car Laguna = new Car("Laguna", 4, 250, "coupes");
            Car Volvo = new Car("Volvo", 4, 250, "coupes");

            Car[] collCar = new Car[10];
            collCar[0] = Celica;
            collCar[1] = Kompot;
            collCar[2] = Golf;
            collCar[3] = BMW;
            collCar[4] = Miota;
            collCar[5] = Giulietta;
            collCar[6] = Mustang;
            collCar[7] = Audi_TT;
            collCar[8] = Laguna;
            collCar[9] = Volvo;

            IEnumerable<Car> query = from car in collCar orderby car.get_manufacturer() select car;

            foreach (Car emp in collCar) { Console.WriteLine(emp.get_manufacturer()); }

            Console.WriteLine("\nElement tablicy po posortowaniu: ");
            foreach (Car sortcar in query) { Console.WriteLine(sortcar.get_manufacturer()); }
        }
    }    

    #region Kolokwium - class
    abstract class Vehicle
    {
        protected string manufacturer;
        protected int numWheels;

        public string get_manufacturer() { return manufacturer; }
        public void set_color(string manufacturer) { this.manufacturer = manufacturer; }

        public int get_numWheels() { return numWheels; }
        public void set_numWheels(int numWheels) { this.numWheels = numWheels; }

        public virtual void drive() => Console.WriteLine("Wruuum...");
    }

    class Carriage : Vehicle, IComparable
    {
        public void harnessing() => Console.WriteLine("Harnessing...");
        public override void drive()
        {
            base.drive();
            Console.WriteLine("Carriage drive...");
        }
    }

    abstract class MotorVehicle : Vehicle
    {
        protected int horsepower;

        public int get_horsepower() { return horsepower; }
        public void set_horsepower(int horsepower) { this.horsepower = horsepower; }

        public virtual void startEngine() => Console.WriteLine("Start engine...");
        public virtual void refueling() => Console.WriteLine("Refueling...");
        public override void drive()
        {
            base.drive();
            Console.WriteLine("Motor vehicle drive...");
        }
    }

    class Bicycle : Vehicle, IComparable
    {
        private void sightseeing() => Console.WriteLine("sightseeing...");
        public override void drive()
        {
            base.drive();
            Console.WriteLine("Bicycle drive...");
        }
    }

    class Truck : MotorVehicle, IComparable
    {
        private int numAxels;

        public int get_numAxels() { return numAxels; }
        public void set_numAxels(int numAxels) { this.numAxels = numAxels; }

        public void truckUnloading() => Console.WriteLine("Truck unloading...");
        public override void drive()
        {
            base.drive();
            Console.WriteLine("Truck drive...");
        }
    }

    class Car : MotorVehicle, IComparable
    {
        private string bodyType;

        public string get_bodyType() { return bodyType; }
        public void set_bodyType(string bodyType) { this.bodyType = bodyType; }

        public void drifting() => Console.WriteLine("Wzium... drifting!");
        public override void drive()
        {
            base.drive();
            Console.WriteLine("Car drive");
        }

        public Car()
        {
        }

        public Car(string manufacturer, int numWheels, int horsepower, string bodyType)
        {
            this.manufacturer = manufacturer;
            this.numWheels = numWheels;
            this.horsepower = horsepower;
            this.bodyType = bodyType;
        }

        public Car(Car c)
        {
            manufacturer = c.manufacturer;
            numWheels = c.numWheels;
            horsepower = c.horsepower;
            bodyType = c.bodyType;
        }

        ~Car() => Console.WriteLine("Destruktor klasy Car został uruchomiony!");
    }

    interface IComparable
    {
        void compareTo(object obj)
        {

        }
    }
    #endregion
}