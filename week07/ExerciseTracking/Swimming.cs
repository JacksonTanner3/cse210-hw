public class Swimming : Activity
{
    private int _laps;
    private const double LapLengthMeters = 50.0;
    private const double MetersToMiles = 0.000621371;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        // Distance (miles) = laps * 50 / 1000 * 0.62
        return _laps * LapLengthMeters * MetersToMiles;
    }

    public override double GetSpeed()
    {
        // Speed (mph) = (distance / minutes) * 60
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        // Pace (min per mile) = minutes / distance
        return Minutes / GetDistance();
    }
}
