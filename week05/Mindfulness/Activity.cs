using System;

class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine($"\n{_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"");
    }

    public void DisplayDuration()
    {
        Console.WriteLine($"How long in seconds would you like for your session? ");
        int _duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine($"Get ready...");

        // |/-\
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        foreach (string s in animationString)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(8);
    }
}