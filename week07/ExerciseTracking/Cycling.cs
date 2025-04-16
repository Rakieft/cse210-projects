public class Cycling : Activity
{
    private double speed; // Speed in km/h

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * Minutes) / 60; // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return speed; // Speed in km/h
    }

    public override double GetPace()
    {
        return 60 / speed; // Pace in minutes per kilometer
    }
}