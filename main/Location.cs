public class Location
{
    public int ID;
    public string Name;
    public string Description;
    public int killCount = 0;
    public Quest? QuestAvailableHere;
    public Monster? MonsterLivingHere;
    public Location? LocationToNorth;
    public Location? LocationToEast;
    public Location? LocationToSouth;
    public Location? LocationToWest;

    public static string playerIcon = "\U0001680B";


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
        this.killCount = 0;

    }

    public void GetMap()
    {
        Console.Clear();
        Console.WriteLine("You are now at: " + this.Name + ". From here you can go to these directions:");
        Console.WriteLine("Enter the letter of the direction");
        bool canGoNorth = (this.LocationToNorth != null);
        bool canGoEast = (this.LocationToEast != null);
        bool canGoSouth = (this.LocationToSouth != null);
        bool canGoWest = (this.LocationToWest != null);
        Console.WriteLine(canGoNorth ? "    N" : "    ");
        Console.WriteLine(canGoNorth ? "    |" : "    ");
        Console.Write(canGoWest ? "W---" : "    ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(playerIcon);
        Console.ResetColor();
        Console.WriteLine(canGoEast ? "---E " : "   ");
        Console.WriteLine(canGoSouth ? "    |" : "    ");
        Console.WriteLine(canGoSouth ? "    S" : "    ");
        Console.WriteLine(" ");
        
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

    public void Events(Player player)
    {
        if (this.MonsterLivingHere != null && this.MonsterLivingHere.CurrentHitPoints > 0)
        {
            Console.WriteLine("You have encountered a monster!");
            Combat combat = new Combat(player, this.MonsterLivingHere);
            combat.Start();

        }
        else if (this.QuestAvailableHere != null)
        {
            if (this.QuestAvailableHere.questLocation.MonsterLivingHere.CurrentHitPoints <= 0)
            {
                if (this.QuestAvailableHere.IsDone == false)
                {
                    player.Inv.AddItem(this.QuestAvailableHere.Reward, this.QuestAvailableHere.quantity_reward);
                }
            }
            else 
            {
                System.Console.WriteLine("You have a quest available here!");
                System.Console.WriteLine("Do you want to start the quest?");
                System.Console.WriteLine("1. Yes");
                System.Console.WriteLine("2. No");
                string choice = Console.ReadLine();
                //repeat until valid choice
                do
                {
                    if (choice == "1" || choice.ToLower() == "y")
                    {
                        this.QuestAvailableHere.start_menu();
                    }
                    else if (choice == "2" || choice.ToLower() == "n")
                    {
                        System.Console.WriteLine("You have chosen not to start the quest.");
                    }
                    else
                    {
                        System.Console.WriteLine("Invalid choice");
                    }
                } while (choice != "1" && choice != "2" && choice.ToLower() != "y" && choice.ToLower() != "n");
            
            }
        }
        else if (this.ID == 3)
        {
            int count = 0;
            foreach (Quest quest in World.Quests)
            {
                if (quest.IsDone)
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                this.LocationToEast = World.LocationByID(8);
            }
            else
            {
                this.LocationToEast = null;
            }
        }
    }



}