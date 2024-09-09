public class Monster
{
    // fields
    public int currentHitPoints;
    public int ID;
    public int maximumDamage;
    public int maximumHitPoints;
    public string name;

    // constructor
    public Monster(int currentHitPoints, int id, int maximumDamage, int maximumHitPoints, string name)
    {
        this.currentHitPoints = currentHitPoints;
        this.ID = id;
        this.maximumDamage = maximumDamage;
        this.maximumHitPoints = maximumHitPoints;
        this.name = name;

        Console.WriteLine($"Monster initialized: {name}");

        public void Attack()
    {

    }

}
}