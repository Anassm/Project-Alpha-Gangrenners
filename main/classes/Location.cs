public class Location
{
    public int ID;
    public string Name;
    public string Description;
    public int? killCount;
    public Quest? QuestAvailableHere;
    public Monster? MonsterLivingHere;
    public Location? LocationToNorth;
    public Location? LocationToEast;
    public Location? LocationToSouth;
    public Location? LocationToWest;


    public Location(int id, string name, string description, Quest? questAvailableHere = null, Monster? monsterLivingHere = null)
    {
        this.ID = id;
        this.Name = name;
        this.Description = description;
        this.QuestAvailableHere = questAvailableHere;
        this.MonsterLivingHere = monsterLivingHere;
        this.LocationToNorth = null;
        this.LocationToEast = null;
        this.LocationToSouth = null;
        this.LocationToWest = null;
        if (this.MonsterLivingHere != null)
        {
            this.killCount = 0;
        }
        else 
        {
            this.killCount = null;
        }

    }

    public void GetMap()
    {
        Console.WriteLine("You are now at: " + this.Name + ". From here you can go to:");
        bool canGoNorth = (this.LocationToNorth != null);
        bool canGoEast = (this.LocationToEast != null);
        bool canGoSouth = (this.LocationToSouth != null);
        bool canGoWest = (this.LocationToWest != null);
        Console.WriteLine(canGoNorth ? "    N" : "    ");
        Console.WriteLine(canGoNorth ? "    |": "    ");
        Console.Write(canGoWest ? "W---" : "    ");
        Console.Write("|");
        Console.WriteLine(canGoEast ? "---E " : "   ");
        Console.WriteLine(canGoSouth? "    |" : "    ");
        Console.WriteLine(canGoSouth ? "    S" : "    ");
    }

    public bool CheckDirection(string NewDirection)
    {
        if (NewDirection == "N")
        {
            if (this.LocationToNorth != null)
            {
                Console.WriteLine("You are now moving to the North");
                return true;
            }
            else
            {
                Console.WriteLine("You cannot go to the North");
                return false;
            }
        }
        else if (NewDirection == "E")
        {
            if (this.LocationToEast != null)
            {
                Console.WriteLine("You are now moving to the East");
                return true;
            }
            else
            {
                Console.WriteLine("You cannot go to the East");
                return false;
            }
        }
        else if (NewDirection == "S")
        {
            if (this.LocationToSouth != null)
            {
                Console.WriteLine("You are now moving to the South");
                return true;
            }
            else
            {
                Console.WriteLine("You cannot go to the South");
                return false;
            }
        }
        else if (NewDirection == "W")
        {
            if (this.LocationToWest != null)
            {
                Console.WriteLine("You are now moving to the West");
                return true;
            }
            else
            {
                Console.WriteLine("You cannot go to the West");
                return false;
            }
        }
        else
        {
            Console.WriteLine("Invalid direction");
            return false;
        }

    }

    public Location? GetNewLocation(string direction)
    {
        if (direction == "N")
        {
            return this.LocationToNorth;
        }
        else if (direction == "E")
        {
            return this.LocationToEast;
        }
        else if (direction == "S")
        {
            return this.LocationToSouth;
        }
        else if (direction == "W")
        {
            return this.LocationToWest;
        }
        else
        {
            return null;
        }
    }

    public void Events()
    {
        if (this.MonsterLivingHere != null)
        {   
            Console.WriteLine("You have encountered a monster!");
            //Start combat
        }
        else if (this.QuestAvailableHere != null)
        {
            System.Console.WriteLine("You have a quest available here!");
            //this.QuestAvailableHere.start_menu();
        }
        else if (this.ID == 3)
        {

        }
    }



}