public class Inventory
{
    public Dictionary<string, int> inventory = new();

    public Inventory()
    {
        inventory = new Dictionary<string, int>
        {
            { "Rusty Sword", 1 },
            { "Club", 0 },
            { "Small Potion", 0 },
            { "Medium Potion", 0 },
            { "Big Potion", 0 }
        };
    }

    public void AddItem(string item, int amount)
    {
        if (inventory.ContainsKey(item))
        {
            inventory[item] += amount;
            System.Console.WriteLine("You now have: " + inventory[item] + " " + item);
        }
        else
        {
            System.Console.WriteLine(item + " is not in the inventory.");
        }
    }

    public void OpenInventory(bool InCombat)
    {
        System.Console.WriteLine("Welcome to the inventory!");
        System.Console.WriteLine("You have: ");
        
        if (!InCombat)
        {
            System.Console.WriteLine("Rusty Sword: " + inventory["Rusty Sword"]);
            System.Console.WriteLine("Club: " + inventory["Club"]);
        }

        System.Console.WriteLine("Small Potion: " + inventory["Small Potion"]);
        System.Console.WriteLine("Medium Potion: " + inventory["Medium Potion"]);
        System.Console.WriteLine("Big Potion: " + inventory["Big Potion"]);
    }
}
