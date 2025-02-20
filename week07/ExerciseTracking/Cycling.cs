using System;

class Cycling : Activity
{
    private double speedMph;

    public Cycling(DateTime activityDate, int durationMinutes, double speedMph)
        : base(activityDate, durationMinutes)
    {
        this.speedMph = speedMph;
    }

    public override double GetDistance()
    {
        return (speedMph * GetTime()) / 60;
    }

    public override double GetSpeed()
    {
        return speedMph;
    }

    public override double GetPace()
    {
        return 60 / speedMph;
    }
}