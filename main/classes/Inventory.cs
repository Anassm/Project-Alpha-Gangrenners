public class Inventory
{
    static void Main(string[] args)
    {
        Dictionary<string, int> inventory = new();

        inventory.Add("WEAPON_ID_RUSTY_SWORD", 1);
        inventory.Add("WEAPON_ID_CLUB", 0);
        inventory.Add("HEALTH_ID_SMALL", 0);
        inventory.Add("HEALTH_ID_MID", 0);
        inventory.Add("HEALTH_ID_BIG", 0);
    }
}