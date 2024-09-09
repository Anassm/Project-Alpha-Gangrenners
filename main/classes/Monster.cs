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
}