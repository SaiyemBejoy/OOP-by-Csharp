using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodShop
{
    class HealthyBurger : Hamburger
    {
        private string _healthyExtra1Name;
        private double _healthyExtra1Price;

        private string _healthyExtra2Name;
        private double _healthyExtra2Price;

        public HealthyBurger(string meat, double price) : base("Healthy", meat, price, "Brown rye")
        {

        }

        public void addHealthAdditon1(string name, double price)
        {
            _healthyExtra1Name = name;
            _healthyExtra1Price = price;
        }

        public void addHealthAdditon2(string name, double price)
        {
            _healthyExtra2Name = name;
            _healthyExtra2Price = price;
        }

        public override double itemizeHamburger()
        {
            double hamburgerPrice = base.itemizeHamburger();

            if (_healthyExtra1Name != null)
            {
                hamburgerPrice += _healthyExtra1Price;
                Console.WriteLine("Added " + _healthyExtra1Name + " for an extra " + _healthyExtra1Price);
            }
            if (_healthyExtra2Name != null)
            {
                hamburgerPrice += _healthyExtra2Price;
                Console.WriteLine("Added " + _healthyExtra2Name + " for an extra " + _healthyExtra2Price);
            }

            return hamburgerPrice;
        }
    }
}
