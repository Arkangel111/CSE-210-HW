using System;
using System.ComponentModel.DataAnnotations;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {

    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        ShowSpinner(8);

        int roundedDuration = (int)Math.Round(GetDuration() / 5.0) * 5;
        for (int i = 0; i < roundedDuration; i += 10)
        {
            ShowCountDown(5, "Breathe in...");
            ShowCountDown(5, "Now breathe out...");
            Console.WriteLine();
        }

        DisplayEndingMessage();
        ShowSpinner(8);
    }
}

