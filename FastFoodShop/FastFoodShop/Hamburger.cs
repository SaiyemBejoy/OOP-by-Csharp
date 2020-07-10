using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodShop
{
    class Hamburger
    {
        private string _name;
        private string _meat;
        private double _price;
        private string _breadRollType;

        private string _addition1Name;
        private double _addition1Price;

        private string _addition2Name;
        private double _addition2Price;

        private string _addition3Name;
        private double _addition3Price;

        private string _addition4Name;
        private double _addition4Price;

        public Hamburger(string name, string meat, double price, string breadRollType)
        {
            _name = name;
            _meat = meat;
            _price = price;
            _breadRollType = breadRollType;
        }

        public virtual void addHamburgerAddition1(string name, double price)
        {
            _addition1Name = name;
            _addition1Price = price;
        }

        public virtual void addHamburgerAddition2(string name, double price)
        {
            _addition2Name = name;
            _addition2Price = price;
        }

        public virtual void addHamburgerAddition3(string name, double price)
        {
            _addition3Name = name;
            _addition3Price = price;
        }

        public virtual void addHamburgerAddition4(string name, double price)
        {
            _addition4Name = name;
            _addition4Price = price;
        }

        public virtual double itemizeHamburger()
        {
            double hamburgerPrice = _price;
            Console.WriteLine(_name + " hamburger on a " + _breadRollType + " roll with " + _meat + ", price is " + _price);

            if(_addition1Name != null)
            {
                hamburgerPrice += _addition1Price;
                Console.WriteLine("Added " + _addition1Name + " for an extra " + _addition1Price);
            }
            if (_addition2Name != null)
            {
                hamburgerPrice += _addition2Price;
                Console.WriteLine("Added " + _addition2Name + " for an extra " + _addition2Price);
            }
            if (_addition3Name != null)
            {
                hamburgerPrice += _addition3Price;
                Console.WriteLine("Added " + _addition3Name + " for an extra " + _addition3Price);
            }
            if (_addition4Name != null)
            {
                hamburgerPrice += _addition4Price;
                Console.WriteLine("Added " + _addition4Name + " for an extra " + _addition4Price);
            }

            return hamburgerPrice;
        }


    }
}
