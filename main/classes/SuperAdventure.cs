public class SuperAdventure
{
    // Fields
    public Monster CurrentMonster;F
    public Player ThePlayer;

    // Constructor
    public SuperAdventure(string currentMonster, string thePlayer)
    {
        this.CurrentMonster = currentMonster;
        this.ThePlayer = thePlayer;

        Console.WriteLine("SuperAdventure initialized");
    }
}