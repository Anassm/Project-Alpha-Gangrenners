public class Program
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Project Alpha Gangrenners");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Made by: ");
        Console.WriteLine("The Gangrenners");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("The goal of this game is to complete the 3 different quests");
        Console.WriteLine("You can move around the map and fight monsters");
        Console.WriteLine("Good luck!");
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Press any key to start the game");
       // Console.Read();
       // Console.Clear();
        StartGame();
    }


    // give player options to choose from and fire events based on the choice
    public static void StartGame()
    {
        // ask for player name
        Console.WriteLine("Choose your name: ");
        string name = Console.ReadLine();

        if (string.IsNullOrEmpty(name))
        {
            name = "Player";
        }

        if (name == "AMONGUS"){
            Location.playerIcon = "\u0D9E";
        }

        // create player (WHAT HP)
        Player player = new Player(1, World.Locations[0], World.Weapons[0], 100, name);
        

        // Intro
        Console.WriteLine("Welcome " + player.Name);
        Console.WriteLine("You are now at: " + player.CurrentLocation.Name);
        player.CurrentLocation.Events(player);

        bool GameRunning = true;

        // Main game loop
        while (GameRunning)
        {
            Console.WriteLine("What do you want to do? Enter the number of your choice");
            if (player.CurrentHitPoints <= 0)
            {
                GameRunning = false;
                break;
            }
            Console.WriteLine("1. Change directions");
            Console.WriteLine("2. Check inventory");
            Console.WriteLine("3. List of quests");
            Console.WriteLine("4. Check stats");
            Console.WriteLine("5. Quit");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                player.ChangeDirections();
            }
            else if (choice == "2")
            {
<<<<<<< Updated upstream
                //player.GetInventory();
=======
                player.Inv.OpenInventory();
                GroupedItem? mainitem = null;
                Console.WriteLine("Would you like too switch your main weapon?");
                string mainweapon = Console.ReadLine();
                int count = 0;
                if (mainweapon == "yes" || mainweapon == "YES" || mainweapon == "y" || mainweapon == "Y")
                {
                    foreach (GroupedItem groupeditem in player.Inv.Inv)
                    {
                        count++;
                        Console.WriteLine($"{count} {groupeditem.Item.Name}");
                    }
                    Console.WriteLine("choose a number.");
                    int choiceItem = Convert.ToInt32(Console.ReadLine());
                    switch(choiceItem)
                    {
                        case 1:
                            bool switchitemone = false;
                            GroupedItem? grItemone = null; 
                            int countone = 0; 
                            foreach (GroupedItem item in player.Inv.Inv)
                            {
                                countone++;
                                if (countone == 2)
                                {
                                    switchitemone = true;
                                    grItemone = item;
                                }
                            }
                            if (switchitemone == true)
                            {
                                player.Inv.SwitchItem(grItemone.Item.Name);
                            }
                            break;
                        case 2:
                            bool switchitemtwo = false;
                            GroupedItem? grItemtwo = null; 
                            int counttwo = 0; 
                            foreach (GroupedItem item in player.Inv.Inv)
                            {
                                counttwo++;
                                if (counttwo == 2)
                                {
                                    switchitemtwo = true;
                                    grItemtwo = item;
                                }
                            }
                            if (switchitemtwo == true)
                            {
                                player.Inv.SwitchItem(grItemtwo.Item.Name);
                            }
                            break;
                        case 3:
                            bool switchitemthree = false;
                            GroupedItem? grItemthree = null; 
                            int countthree = 0; 
                            foreach (GroupedItem item in player.Inv.Inv)
                            {
                                countthree++;
                                if (countthree == 2)
                                {
                                    switchitemthree = true;
                                    grItemthree = item;
                                }
                            }
                            if (switchitemthree == true)
                            {
                                player.Inv.SwitchItem(grItemthree.Item.Name);
                            }
                            break;
                        case 4:
                            bool switchitemfour = false;
                            GroupedItem? grItemfour = null; 
                            int countfour = 0; 
                            foreach (GroupedItem item in player.Inv.Inv)
                            {
                                countfour++;
                                if (countfour == 2)
                                {
                                    switchitemfour = true;
                                    grItemfour = item;
                                }
                            }
                            if (switchitemfour == true)
                            {
                                player.Inv.SwitchItem(grItemfour.Item.Name);
                            }
                            break;
                    };
                }
>>>>>>> Stashed changes
            }
            else if (choice == "3")
            {
                Quest.completed_quests();
            }
            else if (choice == "4")
            {
                //stats   
            }
            else if (choice == "5")
            {
                Console.WriteLine("You have not completed all quests yet");
                Console.WriteLine("Keep going!");
                Console.WriteLine("Are you sure you want to quit?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                string quit = Console.ReadLine().ToLower();
                if (quit == "1" || quit == "Yes" || quit == "y")
                {   
                    
                    break;
                }
                else
                {
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
            
            //check if 3 quests are done
            int countnumber = 0;
            for (int i = 0; i < World.Quests.Count; i++)
            {
                if (World.Quests[i].IsDone == true)
                {
                    countnumber++;   
                }
            }
            if (countnumber == 3)
            {
                Console.WriteLine("You have completed all quests!");
                Console.WriteLine("You have won the game!");
                GameRunning = false;
            }

                
            
        }
        if (player.CurrentHitPoints >= 0)
        {
            Console.Clear();
        }
        
        Console.WriteLine("Thank you for playing!");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine(" GGGGG   OOO   OOO   DDDD   BBBB   Y   Y  EEEEE ");
        Console.WriteLine("G       O   O O   O  D   D  B   B   Y Y   E     ");
        Console.WriteLine("G  GGG  O   O O   O  D   D  BBBB     Y    EEEEE ");
        Console.WriteLine("G   G   O   O O   O  D   D  B   B    Y    E     ");
        Console.WriteLine(" GGGGG   OOO   OOO   DDDD   BBBB     Y    EEEEE ");
        Console.ResetColor();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

    }

}
