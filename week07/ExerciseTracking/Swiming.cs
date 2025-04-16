public class Swimming : Activity
{
    private int laps; // Number of laps swum

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50 / 1000.0; // Distance in kilometers
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60; // Speed in km/h
    }

    public override double GetPace()
    {
        return Minutes / GetDistance(); // Pace in minutes per kilometer
    }
}