using System.Data.Common;

public class Quest
{
    public string ID;
    public string Name;
    public string Description;

    public Quest(string id, string name, string Description)
    {
        this.ID = id;
        this.Name = name;
        this.Description = Description;
    }
}