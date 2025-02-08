using System;

class Program

// added a menu
// added test programs

{
    static void Main(string[] args)
    {
        testBreathing();
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

        Breathing breathing = new Breathing();
        breathing.Run();

        Console.ReadLine();

    }
}