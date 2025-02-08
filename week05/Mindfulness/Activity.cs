using System;
using System.Security.Cryptography.X509Certificates;

public class Activity
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

        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");

        ShowSpinner(8);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done.");
        Console.WriteLine($"You completed another {_duration} seconds of the {_name} Activity.");
    }


    // Console.WriteLine($"How long in seconds would you like for your session? ");
    // int _seconds = int.Parse(Console.ReadLine());
    // Console.Clear();

    // Console.WriteLine($"Get ready...");
    public void ShowSpinner(int seconds)
    {


        // |/-\
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        // foreach (string s in animationString)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(500);
        //     Console.Write("\b \b");
        // }

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(4);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationString[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds, string message)
    {
        Console.Write(message + " ");
        for (int i = seconds; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    }
    public int GetDuration()
    {
        return _duration;
    }

}