class Item : GameObject
{
    public Item(string name) : base(name) { }

    public override void Interact()
    {
        Console.WriteLine($"You found a {Name}!");
    }
}