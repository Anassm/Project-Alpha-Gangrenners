public class Location
{
    public int ID;
    public string Name;
    public string Description;
    public Quest QuestAvailableHere;
    public Monster MonsterLivingHere;
    public Location locationToNorth;
    public Location locationToEast;
    public Location locationToSouth;
    public Location locationToWest;


    public Location(int id, string name, string description, Quest questAvailableHere = null, Monster monsterLivingHere = null)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.QuestAvailableHere = questAvailableHere;
        this.MonsterLivingHere = monsterLivingHere;
        this.locationToNorth = null;
        this.locationToEast = null;
        this.locationToSouth = null;
        this.locationToWest = null;

    }

}