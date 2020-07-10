using System;

namespace Polymorphism
{
    class Car
    {
        private bool _engine;
        private int _cylinders;
        private string _name;
        private int _wheels;

        public Car(int cylinders, string name)
        {
            _engine = true;
            _cylinders = cylinders;
            _name = name;
            _wheels = 4;
        }

        public int Cylinders { get => _cylinders; }
        public string Name { get => _name; }

        public virtual string startEngine()
        {
            return "Car -> startEngine()";
        }

        public virtual string accelerate()
        {
            return "Car -> accelerate()";
        }

        public virtual string brake()
        {
            return "Car -> brake()";
        }
    }

    class Mitsubishi : Car
    {
        public Mitsubishi(int cylinders, string name) : base(cylinders, name)
        {

        }

        public override string accelerate()
        {
            return "Mitsubishi -> accelerate()";
        }

        public override string brake()
        {
            //return base.brake();
            return "Mitsubishi -> brake()";
        }

        public override string startEngine()
        {
            return "Mitsubishi -> startEngine()";
        }
    }

    class Ford : Car
    {
        public Ford(int cylinders, string name) : base(cylinders, name)
        {

        }

        public override string accelerate()
        {
            return "Ford -> accelerate()";
        }

        public override string brake()
        {
            //return base.brake();
            return "Ford -> brake()";
        }

        public override string startEngine()
        {
            return "Ford -> startEngine()";
        }
    }

    class Holden : Car
    {
        public Holden(int cylinders, string name) : base(cylinders, name)
        {

        }

        public override string accelerate()
        {
            return "Holden -> accelerate()";
        }

        public override string brake()
        {
            //return base.brake();
            return "Holden -> brake()";
        }

        public override string startEngine()
        {
            return "Holden -> startEngine()";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(8, "Base Car");
            Console.WriteLine(car.startEngine());
            Console.WriteLine(car.accelerate());
            Console.WriteLine(car.brake());

            Mitsubishi mitsubishi = new Mitsubishi(6, "Outlander VRW");
            Console.WriteLine(mitsubishi.startEngine());
            Console.WriteLine(mitsubishi.accelerate());
            Console.WriteLine(mitsubishi.brake());

            Ford ford = new Ford(7, "Extreme VX");
            Console.WriteLine(ford.startEngine());
            Console.WriteLine(ford.accelerate());
            Console.WriteLine(ford.brake());

            Holden holden = new Holden(5, "Universe LN");
            Console.WriteLine(holden.startEngine());
            Console.WriteLine(holden.accelerate());
            Console.WriteLine(holden.brake());
        }
    }
}
