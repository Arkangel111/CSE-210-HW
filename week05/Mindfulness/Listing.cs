using System;
using System.Dynamic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;


    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
    }

    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        ShowSpinner(8);

        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        string prompt = GetRandomPrompt();
        Console.WriteLine($"=== {prompt} ===");
        ShowCountDown(5, "You may begin in: ");

        GetListFromUser();
        Console.WriteLine($"\nYou listed {_count} items!");

        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(8);

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public void GetListFromUser()
    {
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration() + 10);

        _count = 0;

        List<string> userList = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            string userInput = Console.ReadLine();
            userList.Add(userInput);
            _count++;
        }
    }
}