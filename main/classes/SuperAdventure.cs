public class SuperAdventure
{
    // Fields
    public Monster CurrentMonster;
    public Player ThePlayer;

    // Constructor
    public SuperAdventure(Monster currentMonster, Player thePlayer)
    {
        this.CurrentMonster = currentMonster;
        this.ThePlayer = thePlayer;

        Console.WriteLine("SuperAdventure initialized");
    }
}