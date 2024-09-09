using System.Data.Common;

public class Quest
{
    public int ID;
    public string Name;
    public string Description;

    public Quest(int id, string name, string Description)
    {
        this.ID = id;
        this.Name = name;
        this.Description = Description;
    }
}