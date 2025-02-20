using System;

class Running : Activity
{
    private double distanceMiles;

    public Running(DateTime date, int duration, double distanceMiles) : base(date, duration)
    {
        this.distanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return distanceMiles;
    }

    public override double GetSpeed()
    {
        return (distanceMiles / GetTime()) * 60;
    }

    public override double GetPace()
    {
        return GetTime() / distanceMiles;
    }

}