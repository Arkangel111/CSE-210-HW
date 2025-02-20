using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2025, 02, 20), 30, 3.0),
            new Cycling(new DateTime(2025, 02, 20), 45, 15),
            new Swimming(new DateTime(2025, 02, 20), 25, 30)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}