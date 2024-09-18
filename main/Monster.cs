public class Monster
{
    // fields
    public int CurrentHitPoints;
    public int ID;
    public int MaximumDamage;
    public int MaximumHitPoints;
    public string Name;
    public int Experience;

    // constructor
    public Monster(int id, string name, int maximumHitPoints, int currentHitPoints, int maximumDamage, int experience)
    {
        this.CurrentHitPoints = currentHitPoints;
        this.ID = id;
        this.MaximumDamage = maximumDamage;
        this.MaximumHitPoints = maximumHitPoints;
        this.Name = name;
        this.Experience = experience;
    }

    // methods
    public int Attack(Player player)
    {
        Random random = new Random();

        int critical = random.Next(0, 100);
        int damage = random.Next(0, this.MaximumDamage);

        // 10% chance to critical hit
        if (critical < 10)
        {
            damage *= 2;
        }

        Console.WriteLine($"{(critical < 10 ? "Critical!" : string.Empty)} Monster {this.Name} attacked {player.Name} for {damage} damage.");

        return damage;
    }

    public void TakeDamage(int damage)
    {
        this.CurrentHitPoints -= damage;
    }
}