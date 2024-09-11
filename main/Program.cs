public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Project Alpha Gangrenners");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Made by: ");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("The goal of this game is to complete the 3 different quests");
        Console.WriteLine("You can move around the map and fight monsters");
        Console.WriteLine("Good luck!");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Press any key to start the game");
        Console.ReadKey();
        Console.Clear();
        StartGame();
    }


    // give player options to choose from and fire events based on the choice
    public static void StartGame()
    {
        // ask for player name
        Console.WriteLine("Choose your name: ");
        string name = Console.ReadLine();

        // create player (WHAT HP)
        Player player = new Player(100, World.Locations[0], World.Weapons[0], 100, name);
        

        // Intro
        Console.WriteLine("Welcome " + player.Name);
        Console.WriteLine("You are now at: " + player.CurrentLocation.Name);
        player.CurrentLocation.Events();
        
        // Main game loop
        while (true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Change directions");
            Console.WriteLine("2. Check inventory");
            Console.WriteLine("3. Check stats");
            Console.WriteLine("4. Quit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                player.ChangeDirections();
            }
            else if (choice == "2")
            {
                //player.GetInventory();
            }
            else if (choice == "3")
            {
                //player.GetStats();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }

}