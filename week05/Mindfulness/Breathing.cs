using System;
using System.ComponentModel.DataAnnotations;

public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {

    }
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        ShowSpinner(8);

        Console.Clear();
        Console.WriteLine("Begin...");

        int roundedDuration = (int)Math.Round(GetDuration() / 5.0) * 5;
        for (int i = 0; i < roundedDuration; i += 10)
        {
            ShowCountDown(5, "Breathe in...");
            ShowCountDown(5, "Breathe out...");
        }

        DisplayEndingMessage();
    }
}

