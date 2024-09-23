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
*/

public class Quest
{
    public int ID;
    public string Name;
    public string Description;
    public Location questLocation;
    public bool IsDone;
    public Item Reward;
    public int quantity_reward;

    public Quest(int id, string name, string Description, Location location, Item reward, int quantity)//add reward to parameters
    {
        this.ID = id;
        this.Name = name;
        this.Description = Description;
        this.questLocation = location;
        this.IsDone = false;
        this.Reward = reward;
        this.quantity_reward = quantity;
        
    }

    public void start_menu()
    {
        //Check if IsDone == false is

        if (IsDone == false)
        {

            
            //check if enough monsters have been killed
            if (this.questLocation.MonsterLivingHere.CurrentHitPoints <= 0)
            {
                System.Console.WriteLine($"you have completed the quest.");
                System.Console.WriteLine($"take your reward.");
                System.Console.WriteLine($"Reward: {this.Reward.Name}");
                this.IsDone = true;
                
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
    public static void completed_quests()
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