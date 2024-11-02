class Location
{
    public string Description { get; private set; }

    public Location(string description)
    {
        Description = description;
    }

    public void Explore()
    {
        Console.WriteLine(Description);
    }
}