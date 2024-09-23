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

        Text.Warning($"{this.player.Name} vs {this.monster.Name}");
    }

    // methods
    public void Start()
    {
        while (true)
        {
            this.PlayerTurn();
            if (this.monster.CurrentHitPoints <= 0)
            {
                Text.GoodNews($"Congratulations! Monster {this.monster.Name} has been defeated! You gained {this.monster.Experience} experience.");
                this.player.GainExperience(this.monster.Experience);
                break;
            }

            this.MonsterTurn();
            if (this.player.CurrentHitPoints <= 0)
            {
                Console.Clear();
                Text.Alert("You died.");
                // End the game (application) for now. Can be changed to restart the game, perchance respawn the player?
                break;
            }
        }
    }

    public void PlayerTurn()
    {
        Text.Info("Player's turn!");

        Text.Info($"You currently have {this.player.CurrentHitPoints}HP.");
        Text.nl();
        Text.Options("1. Attack");
        Text.Options("2. Use Item");
        Text.nl();
        Console.Write("Choose 1 or 2: ");
        int decision = Convert.ToInt32(Console.ReadLine() ?? "1");

        switch (decision)
        {
            case 1:
                this.monster.TakeDamage(this.player.Attack(this.monster));
                break;
            case 2:
                Text.Warning("Item selection not implemented yet.");
                break;
        }
    }

    public void MonsterTurn()
    {
        Text.Info("Monster's turn!");

        this.player.TakeDamage(this.monster.Attack(this.player));
    }
}