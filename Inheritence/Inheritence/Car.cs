using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class Car : Vehicle
    {
        private int wheels;
        private int doors;
        private int gears;
        private bool isManual;

        private int currentGear;

        public Car(string name, string size, int wheels, int doors, int gears, bool isManual) : base(name, size)
        {
            this.wheels = wheels;
            this.doors = doors;
            this.gears = gears;
            this.isManual = isManual;
            this.currentGear = 1;
        }

        public void changeGear(int currentGear)
        {
            this.currentGear = currentGear;
            Console.WriteLine("Car.setCurrentGear(): Changed to " + this.currentGear + " gear.");
        }

        public void changeVelocity(int speed, int direction)
        {
            Console.WriteLine("Car.changeVelocity(): Velocity " + speed + " direction " + direction);
            move(speed, direction);
        }

        
    }
}
