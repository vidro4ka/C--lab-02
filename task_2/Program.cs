using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{   
    class Vehicle
    {
        private double price;
        private int speed;
        private int year;

        public Vehicle(double _price, int _speed, int _year)
        {
            price = _price;
            speed = _speed;
            year = _year;
        }
        public virtual void printer()
        {
            Console.WriteLine($"Speed: {this.speed} \nPrice: {this.price} \nYear: {this.year}");
        }
    }
    class Car : Vehicle
    {
        public Car(double _price, int _speed, int _year) : base(_price, _speed, _year) { }
        public override void printer()
        {
            Console.WriteLine("CAR:");
            base.printer();
        }
    }
    class Plane : Vehicle
    {
        private double hight;
        private int passengers;
        public Plane(double _price, int _speed, int _year, double _hight, int _passengers) : base(_price, _speed, _year)
        {
            hight = _hight;
            passengers = _passengers;
        }
        public override void printer()
        {
            Console.WriteLine("PLANE:");
            base.printer();
            Console.WriteLine($"Hight: {this.hight} \nPassengers: {this.passengers}");
        }
    }
    class Ship : Vehicle
    {
        private int port;
        private int passengers;

        public Ship(double _price, int _speed, int _year, int _port, int _passengers) : base(_price, _speed, _year)
        {
            port = _port;
            passengers = _passengers;
        }
        public override void printer()
        {
            Console.WriteLine("Ship:");
            base.printer();
            Console.WriteLine($"Port: {this.port} \nPassengers: {this.passengers}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car ob1 = new Car(20000, 220, 2020);
            Plane ob2 = new Plane(3400000, 500, 2010, 3500, 4);
            Ship ob3 = new Ship(89000, 160, 2005, 5, 5);
            ob1.printer();
            Console.WriteLine("\n\n");
            ob2.printer();
            Console.WriteLine("\n\n");
            ob3.printer();
            Console.ReadLine();
        }
    }
}
