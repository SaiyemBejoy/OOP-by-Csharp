using System;

namespace FastFoodShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Hamburger hamburger = new Hamburger("Basic", "Sausage", 3.56, "White");
            double price = hamburger.itemizeHamburger();
            hamburger.addHamburgerAddition1("Tomato", 0.27);
            hamburger.addHamburgerAddition2("Lettuce", 0.75);
            hamburger.addHamburgerAddition3("Chese", 1.13);
            hamburger.addHamburgerAddition4("Mayonise", 0.18);
            Console.WriteLine("Total price of the hamburger is " + hamburger.itemizeHamburger());

            HealthyBurger healthyBurger = new HealthyBurger("Bacon", 5.67);
            healthyBurger.addHamburgerAddition1("Egg", 4.43);
            healthyBurger.addHealthAdditon1("Lentils", 3.41);
            Console.WriteLine("Total price of the healty hamburger is " + healthyBurger.itemizeHamburger());

            DeluxBurger deluxBurger = new DeluxBurger();
            deluxBurger.itemizeHamburger();
            deluxBurger.addHamburgerAddition1("Fries", 4.69);
        }
    }
}
