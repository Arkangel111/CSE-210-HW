using System;

class Menu
{
    public static bool MainMenu()
    {
        {
            while (true)
            {


                Console.Clear();
                Console.WriteLine("Menu Options:");
                Console.WriteLine("   1. Start breathing activity");
                Console.WriteLine("   2. Start reflecting activity");
                Console.WriteLine("   3. Start listing activity");
                Console.WriteLine("   4. Quit");
                Console.WriteLine("Select a choice from the menu: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Starting breathing activity...");
                        return true;

                    case "2":
                        Console.WriteLine("Starting reflecting activity...");
                        return true;

                    case "3":
                        Console.WriteLine("Starting listing activity...");
                        return true;

                    case "4":
                        Console.WriteLine("Goodbye...");
                        return false;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}

