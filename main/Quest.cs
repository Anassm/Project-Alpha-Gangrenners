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
    public Location? questLocation;
    public bool IsDone;
    public Item Reward;
    public int quantity_reward;

    public Quest(int id, string name, string Description, Location? location, Item reward, int quantity)//add reward to parameters
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
            if (questLocation != null && questLocation.MonsterLivingHere != null && questLocation.MonsterLivingHere.CurrentHitPoints <= 0)
            {
                Text.GoodNews($"You have completed the quest.");
                Text.GoodNews($"Take your reward.");
                Text.GoodNews($"Reward: {this.Reward.Name}");
                Text.nl();
                this.IsDone = true;
                
            }
            else 
            {

                Text.Info($"You started the Quest {this.Name}.");
                Text.Warning($"Description:");
                Text.Warning($"{this.Description}");
                if (this.questLocation != null)
                {
                    Text.Warning($"Go to: \n{this.questLocation.Name}");
                }
                else
                {
                    Text.Alert("This quest has no location.");
                }
                Text.nl();
            }
        }
        else
        {
            Text.GoodNews("You have already completed the quest for this location.");
        }



        
    }
    //quest rewards
    public static void completed_quests()
    {
        Text.Info($"Completed quests:");
        int count = 0;
        foreach (Quest quest in World.Quests)
        {
            if (quest.IsDone==true)
            {
                Text.Warning($"- {quest.Name}");
            }
            else
            {
                count++;
            }
        }
        if (count == World.Quests.Count)
        {
            Text.Warning("No quests completed yet");
            Text.nl();
        }
        
        Text.Info($"Not completed quests:");
        foreach (Quest quest in World.Quests)
        {
            if (quest.IsDone==false)
            {
                Text.Warning($"- {quest.Name}");
            }
        }
        Text.nl();
    }
}