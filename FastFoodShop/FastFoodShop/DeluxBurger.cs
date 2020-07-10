using System;
using System.Collections.Generic;
using System.Text;

namespace FastFoodShop
{
    class DeluxBurger : Hamburger
    {
        public DeluxBurger() : base("Delux", "Sausage & Bacon", 14.54, "Black")
        {
            base.addHamburgerAddition1("Chips", 2.75);
            base.addHamburgerAddition2("Drink", 3.45);
        }

        public override void addHamburgerAddition1(string name, double price)
        {
            Console.WriteLine("Can not add additional items to a delux burger");
        }

        public override void addHamburgerAddition2(string name, double price)
        {
            Console.WriteLine("Can not add additional items to a delux burger");
        }

        public override void addHamburgerAddition3(string name, double price)
        {
            Console.WriteLine("Can not add additional items to a delux burger");
        }

        public override void addHamburgerAddition4(string name, double price)
        {
            Console.WriteLine("Can not add additional items to a delux burger");
        }
    }
}
