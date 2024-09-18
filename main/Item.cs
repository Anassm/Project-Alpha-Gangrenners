public class Item
{
    public int ID;
    public string Name;
    public int Amount;
    public int Value;
    public char Type;

    public Item(int id, string name, int amount, int value, char type)
    {
        this.ID = id;
        this.Name = name;
        this.Amount = amount;
        this.Value = value;
        this.Type = type;
    }
}