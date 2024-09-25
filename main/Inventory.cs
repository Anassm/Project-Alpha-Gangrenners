using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

public class Inventory
{
    public List<GroupedItem> Inv;

    public Inventory()
    {
        this.Inv = new();
    }

    public string SwitchItem(string name)
    {
        bool item_sure = false;
        GroupedItem? saved_item_loop = null;
        GroupedItem saved_item = this.Inv[0];
        foreach (GroupedItem groupeditem in Inv)
        {
            if (groupeditem.Item.Name == name)
            {
                saved_item_loop = groupeditem;
                item_sure = true;
            }
        }
        if (item_sure == true)
        {
            if (saved_item_loop != null)
            {
                this.Inv[0] = saved_item_loop;
            }
        }
        this.Inv.Add(saved_item);
        return "Main weapon swapped.";
    }

    public void AddItem(Item item, int amount)
    {
        GroupedItem? alreadyAddedItem = this.Inv.Find(thing => thing.Item.ID == item.ID);
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

    public Item? Get_Item(string name)
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
        Text.nl();
        Text.Info($"Inventory:");
        Text.Info($"ITEM : QUANTITY");
        foreach (GroupedItem groupeditem in this.Inv)
        {
            Text.Warning($"{groupeditem.Item.Name} : {groupeditem.Quantity}");
        }
        Text.nl();
    }
}