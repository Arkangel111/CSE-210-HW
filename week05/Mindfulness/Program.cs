using System;

class Program

// added a menu
// added test programs

{
    static void Main(string[] args)
    {
        // Console.Clear();
        // DisplayStartingMessage();
        // ShowSpinner(8);

        // Console.Clear();
        // Console.WriteLine("Get ready...");

        testReflecting();

        // DisplayEndingMessage();
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