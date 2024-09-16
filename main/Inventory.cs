public class Inventory
{
    public Dictionary<string, int> inventory = new();

    public Inventory()
    {
        inventory = new Dictionary<string, int>
        {
            { "Rusty Sword", 1 },
            { "Club", 0 },
            { "Small Potion", 1 },
            { "Medium Potion", 0 },
            { "Big Potion", 0 },
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
        System.Console.WriteLine("Small Potion: " + inventory["Small Potion"]);
        System.Console.WriteLine("Medium Potion: " + inventory["Medium Potion"]);
        System.Console.WriteLine("Big Potion: " + inventory["Big Potion"]);

        if (!InCombat)
        {
            System.Console.WriteLine("Rusty Sword: " + inventory["Rusty Sword"]);
            System.Console.WriteLine("Club: " + inventory["Club"]);
        }

        System.Console.WriteLine(" ");
        System.Console.WriteLine("What would you like to do?");
        System.Console.WriteLine("1. Use item (U)");
        System.Console.WriteLine("2. Equip weapon (E)");
        System.Console.WriteLine("3. Quit (Q)");
        string choice = Console.ReadLine();
        if (choice == "1" || choice == "u" || choice == "U")
        {
            System.Console.WriteLine("What item would you like to use?");
            System.Console.WriteLine("1. Small Potion");
            System.Console.WriteLine("2. Medium Potion");
            System.Console.WriteLine("3. Big Potion");
        }
    }
}
