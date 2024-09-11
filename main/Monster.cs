using System.Security.Cryptography;

public class Monster
{
    // fields
    public int currentHitPoints;
    public int ID;
    public int maximumDamage;
    public int maximumHitPoints;
    public string name;

    // constructor
    public Monster(int id, string name, int maximumHitPoints, int currentHitPoints, int maximumDamage)
    {
        this.currentHitPoints = currentHitPoints;
        this.ID = id;
        this.maximumDamage = maximumDamage;
        this.maximumHitPoints = maximumHitPoints;
        this.name = name;

        Console.WriteLine($"Monster initialized: {this.name}");
    }

    // methods
    public void Attack(Player player)
    {
        Random random = new Random();

        // 10% chance to critical hit
        int critical = random.Next(0, 100);
        int damage = random.Next(0, this.maximumDamage);

        if (critical < 10)
        {
            damage *= 2;
        }

        Console.WriteLine($"{(critical < 10 ? "Critical!" : String.Empty)} Monster {this.name} attacked {player.Name} for {damage} damage.");

        player.CurrentHitPoints -= damage;
    }

    public void TakeDamage(int damage)
    {
        this.currentHitPoints -= damage;
    }
}