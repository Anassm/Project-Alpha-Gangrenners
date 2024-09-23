public class Item
{
    public int ID;
    public string Name;
    public double Damage_Multiplier = 1;
    public int Healing;
    public Item(int id, string name, double damage_multiplier, int healing)
    {
        this.ID = id;
        this.Name = name;
        this.Damage_Multiplier = damage_multiplier;
        this.Healing = healing;
    }    
}