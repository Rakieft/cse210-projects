public class Running : Activity
{
    private double distance; // Distance in kilometers

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / Minutes) * 60; // Speed in km/h
    }

    public override double GetPace()
    {
        return (Minutes / distance); // Pace in minutes per kilometer
    }
}