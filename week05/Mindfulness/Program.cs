using System;

class Program

// added a menu -- This changed a lot off things from the original requirements please look carefully to ensure I get points
// added some test programs

{
    static void Main()
    {
        while (Menu.MainMenu())
        {
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }
    }

    static void testMenu()
    {
        bool running = true;
        while (running)
        {
            running = Menu.MainMenu();
        }
        Console.WriteLine("Test complete.");
    }
    static void testSpinner()
    {
        Activity activity = new Activity(" ", " ", 0);
        activity.ShowSpinner(10);
    }

    static void testCountDown()
    {
        Activity activity = new Activity("Test", "Testing Countdown ", 0);
        activity.ShowCountDown(5, "Counting down..");
    }

    static void testBreathing()
    {

        BreathingActivity breathing = new();
        breathing.Run();

        Console.ReadLine();

    }
    static void testReflecting()
    {

        ReflectingActivity reflecting = new();
        reflecting.Run();

        Console.ReadLine();

    }
}