using System.Data.Common;
using System.Xml.Schema;
/*
add the reward of the quest to inv when done
    -add reward in world.cs to the quest objects
        -think of rewards
            -potion
            -food
                -make a consumable object
    -make function to add item to inv?

add a function to show a list of quests that are done
    -status field per quest
    -if true -> place in list

add a function to collect gold
    -add a balance field to player
    -think of ways to obtain gold
    -give standard amount of gold on quest completion?
*/

public class Quest
{
    public int ID;
    public string Name;
    public string Description;
    public Location questLocation;
    public bool IsDone;
    //public {type} Reward;

    public Quest(int id, string name, string Description, Location location, )//add reward to parameters
    {
        this.ID = id;
        this.Name = name;
        this.Description = Description;
        this.questLocation = location;
        this.IsDone = false;
        this.Reward = reward;
        //this.Reward = reward;
        
    }

    public void start_menu()
    {
        //Check if IsDone == false is

        if (IsDone == false)
        {

            
            //check if enough monsters have been killed
            if (this.questLocation.MonsterLivingHere.currentHitPoints <= 0)
            {
                System.Console.WriteLine($"you have completed the quest.");
                System.Console.WriteLine($"take your reward.");
                System.Console.WriteLine($"Reward: {this.Reward}");
                this.IsDone = true;
                //add item to inventory
            }
            else 
            {
                System.Console.WriteLine($"you started the Quest {this.Name}.");
                System.Console.WriteLine($"description:");
                System.Console.WriteLine($"{this.Description}");
                System.Console.WriteLine($"go to: {this.questLocation.Name}");
            }
        }
        else
        {
            System.Console.WriteLine("You have already completed the quest for this location.");
        }



        
    }
    //quest rewards
    public void completed_quests()
    {
        System.Console.WriteLine($"Completed quests:");
        foreach (Quest quest in World.Quests)
        {
            if (quest.IsDone==true)
            {
                System.Console.WriteLine($"{quest.Name}");
            }
        }
    }
}