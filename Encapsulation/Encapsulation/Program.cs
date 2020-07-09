using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var printer = new Printer(50, true);

            Console.WriteLine("Initial page count = " + printer.PagesPrinted);

            int pagesPrinted = printer.printPages(4);
            Console.WriteLine("pages printed was " + pagesPrinted + " new total print count for printer = " + printer.PagesPrinted);
            pagesPrinted = printer.printPages(2);
            Console.WriteLine("pages printed was " + pagesPrinted + " new total print count for printer = " + printer.PagesPrinted);
        }
    }
}
