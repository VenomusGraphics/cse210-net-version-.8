class Enemy : GameObject
{
    public int Damage { get; private set; }

    public Enemy(string name, int damage) : base(name)
    {
        Damage = damage;
    }

    public override void Interact()
    {
        Console.WriteLine($"You encountered an aggressive {Name}!");
    }
}