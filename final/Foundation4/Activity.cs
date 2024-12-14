using System;

public abstract class Activity
{
    private DateTime date;
    private int lengthInMinutes;

    public Activity(DateTime date, int lengthInMinutes)
    {
        this.date = date;
        this.lengthInMinutes = lengthInMinutes;
    }

    public DateTime GetDate()
    {
        return date;
    }

    public int GetLengthInMinutes()
    {
        return lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date.ToString("dd MMM yyyy")} {GetType().Name} ({lengthInMinutes} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} kph, Pace {GetPace():0.0} min per km";
    }
}
