using System.Text.RegularExpressions;

public class GroupedItem
{
    public Item Item;
    public int Quantity;

    public GroupedItem(Item item, int quantity)
    {
        this.Item = item;
        this.Quantity = quantity;
    }
}