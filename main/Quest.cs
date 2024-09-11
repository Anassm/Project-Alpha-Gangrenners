using System.Data.Common;
using System.Xml.Schema;
/*
start menu method
reward method
*/

public class Quest
{
    public int ID;
    public string Name;
    public string Description;
    public Location questLocation;
    public bool IsDone;
    //public {type} Reward;

    public Quest(int id, string name, string Description, Location location)//add reward to parameters
    {
        this.ID = id;
        this.Name = name;
        this.Description = Description;
        this.questLocation = location;
        this.IsDone = false;
        //this.Reward = reward;
        
    }

    public void start_menu()
    {
        //Check if IsDone == false is

        if (IsDone == false)
        {
            System.Console.WriteLine($"you started the Quest {this.Name}.");
            System.Console.WriteLine($"description:");
            System.Console.WriteLine($"{this.Description}");
            System.Console.WriteLine($"go to: {this.questLocation.Name}");
            //check if enough monsters have been killed
            if (this.questLocation.killCount >= 3)
            {
                System.Console.WriteLine($"you have completed the quest.");
                System.Console.WriteLine($"take your reward.");
                //System.Console.WriteLine($"Reward: {this.Reward}");
                this.IsDone = true;
                //add item to inventory
            }
        }
        else
        {
            System.Console.WriteLine("You have already completed the quest for this location.");
        }



        
    }
    //quest rewards
}