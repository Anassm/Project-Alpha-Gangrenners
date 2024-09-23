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

        Console.WriteLine($"Combat initialized! {this.player.Name} vs {this.monster.Name}");
    }

    // methods
    public void Start()
    {
        while (true)
        {
            this.PlayerTurn();
            if (this.monster.CurrentHitPoints <= 0)
            {
                Console.WriteLine($"Congratulations! Monster {this.monster.Name} has been defeated! You gained {this.monster.Experience} experience.");
                this.player.GainExperience(this.monster.Experience);
                break;
            }

            this.MonsterTurn();
            if (this.player.CurrentHitPoints <= 0)
            {
                Console.Clear();
                Console.WriteLine("You died.");
                // End the game (application) for now. Can be changed to restart the game, perchance respawn the player?
                break;
            }
        }
    }

    public void PlayerTurn()
    {
        Console.WriteLine("Player's turn!");

        Console.WriteLine($"You currently have {this.player.CurrentHitPoints}HP.");
        Console.WriteLine("Press 1 to Attack");
        int decision = Convert.ToInt32(Console.ReadLine() ?? "1");

        switch (decision)
        {
            case 1:
                this.monster.TakeDamage(this.player.Attack(this.monster));
                break;
        }
    }

    public void MonsterTurn()
    {
        Console.WriteLine("Monster's turn!");

        this.player.TakeDamage(this.monster.Attack(this.player));
    }
}