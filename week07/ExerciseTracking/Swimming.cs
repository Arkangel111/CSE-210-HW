using System;

class Swimming : Activity
{
    private int lapCount;

    public Swimming(DateTime activityDate, int durationMinutes, int lapCount)
        : base(activityDate, durationMinutes)
    {
        this.lapCount = lapCount;
    }

    public override double GetDistance()
    {
        return (lapCount * 50 / 1000.0) * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetTime()) * 60;
    }

    public override double GetPace()
    {
        return GetTime() / GetDistance();
    }
}