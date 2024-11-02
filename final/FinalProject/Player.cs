class Player
{
    public int Health { get; private set; }

    public Player()
    {
        Health = 100;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}