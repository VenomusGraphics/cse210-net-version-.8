class GameObject
{
    public string Name { get; protected set; }

    public GameObject(string name)
    {
        Name = name;
    }

    public virtual void Interact()
    {
        Console.WriteLine($"You see a {Name}.");
    }
}