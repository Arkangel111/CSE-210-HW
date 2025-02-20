using System;
using System.Data;

abstract class Activity
{
    private DateTime date;
    private int time;

    public Activity(DateTime date, int time)
    {
        this.date = date;
        this.time = time;
    }

    public int GetTime()
    {
        return time;
    }

    public DateTime GetDate()
    {
        return date;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date: dd MMM yyyy} {this.GetType().Name} ({time} min) - " +
               $"Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.00} min per mile";
    }
}