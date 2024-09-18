using System.Text.RegularExpressions;

public class Inventory
{
    public List<GroupedItem> Inv;

    public Inventory()
    {
        this.Inv = new();
    }

    public void AddItem(Item item, int amount)
    {
        GroupedItem alreadyAddedItem = this.Inv.Find(thing => thing.Item.ID == item.ID);
        if (alreadyAddedItem != null)
        {
            for (int i = 0; i < amount; i++)
            {
                alreadyAddedItem.Quantity++;
            }
        }
        else
        {
            GroupedItem groupedItem = new(item, amount);
            Inv.Add(groupedItem);
        }
    }

    public Item Get_Item(string name)
    {
        foreach (GroupedItem groupeditem in Inv)
        {
            if(groupeditem.Item.Name == name)
            {
                return groupeditem.Item;
            }
        }
        return null;
    }

    public void OpenInventory()
    {
        System.Console.WriteLine($"Inventory:");
        System.Console.WriteLine($"ITEM : QUANTITY");
        foreach (GroupedItem groupeditem in this.Inv)
        {
            System.Console.WriteLine($"{groupeditem.Item.Name} : {groupeditem.Quantity}");
        }
    }
}
