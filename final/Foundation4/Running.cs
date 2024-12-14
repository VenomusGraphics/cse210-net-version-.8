public class Running : Activity
{
    private double distanceInKm;

    public Running(DateTime date, int lengthInMinutes, double distanceInKm)
        : base(date, lengthInMinutes)
    {
        this.distanceInKm = distanceInKm;
    }

    public override double GetDistance()
    {
        return distanceInKm;
    }

    public override double GetSpeed()
    {
        return (distanceInKm / GetLengthInMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetLengthInMinutes() / distanceInKm;
    }
}
