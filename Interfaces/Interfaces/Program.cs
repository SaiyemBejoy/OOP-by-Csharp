using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Player saiyem = new Player("Saiyem", 10, 15);
            Console.WriteLine(saiyem.ToString());
            saveObject(saiyem);

            saiyem.Hitpoint = 8;
            Console.WriteLine(saiyem);
            saiyem.Weapon = "AK47";
            saveObject(saiyem);
            //loadObject(saiyem);
            Console.WriteLine(saiyem);

            ISaveable werewolf = new Monster("Werewolf", 20, 40);
            Console.WriteLine(werewolf);
            saveObject(werewolf);
        }

        public static List<string> readValues()
        {
            List<string> values = new List<string>();

            bool quit = false;
            int index = 0;
            Console.WriteLine("Choose:\n" + 
                "1 to enter a string\n" +
                "0 to quit");

            while (!quit)
            {
                Console.Write("Choose and option: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        quit = true;
                        break;
                    case 1:
                        Console.Write("Enter a string: ");
                        string stringInput = Console.ReadLine();
                        values.Insert(index, stringInput);
                        index++;
                        break;
                }
            }
            return values;
        }

        public static void saveObject(ISaveable objectToSave)
        {
            for(int i=0; i<objectToSave.write().Count; i++)
            {
                Console.WriteLine("Saving " + objectToSave.write().ElementAt(i) + " to storage device");
            }
        }

        public static void loadObject(ISaveable objectToLoad)
        {
            List<string> values = readValues();
            objectToLoad.read(values);
        }




    }
}
