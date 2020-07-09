using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class Vehicle
    {
        private string name;
        private string size;

        private int currentValocity;
        private int currentDirection;

        public Vehicle(string name, string size)
        {
            this.name = name;
            this.size = size;

            this.currentDirection = 0;
            this.currentValocity = 0;
        }

        public void steer(int direction)
        {
            this.currentDirection += direction;
            Console.WriteLine("Vehicle.steer(): Steering at " + currentDirection + " degrees.");
        }

        public void move(int velocity, int direction)
        {
            currentDirection = direction;
            currentValocity = velocity;
            Console.WriteLine("Vehicle.move():Moving at " + currentValocity + " in direction " + currentDirection);
        }

        public void stop()
        {
            this.currentValocity = 0;
        }

        public string getName()
        {
            return name;
        }

        public string getSize()
        {
            return size;
        }

        public int getCurrentValocity()
        {
            return currentValocity;
        }

        public int getCurrentDirection()
        {
            return currentDirection;
        }
    }
}
