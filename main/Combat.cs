public class Combat
{
    // fields
    public Player player;
    public Monster monster;

    // constructor
    public Combat(Player player, Monster monster)
    {
        this.player = player;
        this.monster = monster;

        Console.WriteLine($"Combat initialized! {this.player.Name} vs {this.monster.name}");
    }

    // methods
    public void Start()
    {
        while (true)
        {
            this.PlayerTurn();
            if (this.monster.currentHitPoints <= 0)
            {
                Console.WriteLine($"Congratulations! Monster {this.monster.name} has been defeated!");
                break;
            }

            this.MonsterTurn();
            if (this.player.CurrentHitPoints <= 0)
            {
                Console.WriteLine("$You died.");
                // End the game (application) for now. Can be changed to restart the game, perchance respawn the player?
                Environment.Exit(0);
            }
        }
    }

    public void PlayerTurn()
    {
        Console.WriteLine("Player's turn!");

        Console.WriteLine("1. Attack");
        Console.WriteLine("2. Use Item");

        Console.Write("Choose 1 or 2: ");
        int decision = Convert.ToInt32(Console.ReadLine() ?? "1");

        switch (decision)
        {
            case 1:
                this.monster.TakeDamage(this.player.Attack);
                break;
            case 2:
                Console.WriteLine("Item selection not implemented yet.");
                break;
        }
    }

    public void MonsterTurn()
    {
        Console.WriteLine("Monster's turn!");

        this.monster.Attack(this.player);
    }
}