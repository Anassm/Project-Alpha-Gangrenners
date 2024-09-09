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
        int damage = random.Next(0, this.maximumDamage);

        player.CurrentHitPoints -= damage;
        Console.WriteLine($"Monster {this.name} attacked {player.Name} for {damage} damage.");
    }
}