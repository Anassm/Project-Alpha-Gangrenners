public class Weapon
{
    public int ID;
    public int MaximumDamage;
    public string Name;

    public Weapon(int id, string name, int maximum_damage)
    {
        this.ID = id;
        this.MaximumDamage = maximum_damage;
        this.Name = name;
    }
}