public class Cycling : Activity
{
    private double speedInKph;

    public Cycling(DateTime date, int lengthInMinutes, double speedInKph)
        : base(date, lengthInMinutes)
    {
        this.speedInKph = speedInKph;
    }

    public override double GetDistance()
    {
        return (speedInKph * GetLengthInMinutes()) / 60;
    }

    public override double GetSpeed()
    {
        return speedInKph;
    }

    public override double GetPace()
    {
        return 60 / speedInKph;
    }
}
