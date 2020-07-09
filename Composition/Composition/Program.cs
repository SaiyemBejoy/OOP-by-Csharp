using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Dimensions dimensions = new Dimensions(20, 20, 5);
            Case theCase = new Case("220B", "HP", "220v", dimensions);

            Monitor theMonitor = new Monitor("f22w", "HP", 22, new Resolution(1920, 1080));

            MotherBoard motherBoard = new MotherBoard("Bazuka", "MSI", 4, 6, "v2.44");

            PC thePC = new PC(theCase, theMonitor, motherBoard);

            thePC.Monitor.drawPixelAt(1500, 1200, "red");
            thePC.MotherBoard.loadProgram("Windows 10 Pro");
            thePC.Case.pressPowerButton();
        }
    }
}
