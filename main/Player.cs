public class Player
{
    public int CurrentHitPoints;
    public Location CurrentLocation;
    public int MaximumHitPoints;
    public string Name;
    public int Experience;
    public int Balance;
    public Item Weapon1 = World.Items[0];
    public Item? Weapon2;
    public Inventory Inv;

    public Player(int currentHitPoints, Location currentLocation, int maximumHitPoints, string name)

    {
        CurrentHitPoints = currentHitPoints;
        CurrentLocation = currentLocation;
        MaximumHitPoints = maximumHitPoints;
        Name = name;
        Balance = 25;
        Inv = new Inventory();
        Inv.AddItem(World.Items[0], 1);
    }


    // change location of player
    public void ChangeDirections()
    {
        CurrentLocation.GetMap();
        Text.Info("Where do you want to go?");
        string direction = (Console.ReadLine() ?? string.Empty).ToUpper();
        bool validDirection = CurrentLocation.CheckDirection(direction);
        while (!validDirection)
        {
            Text.Info("Where do you want to go?");
            direction = (Console.ReadLine() ?? string.Empty).ToUpper();
            validDirection = CurrentLocation.CheckDirection(direction);
        }
        Location? newLocation = CurrentLocation.GetNewLocation(direction);
        if (newLocation != null)
        {
            CurrentLocation = newLocation;
        }
        else
        {
            Text.Warning("The new location is invalid.");
        }
        Console.Clear();
        Console.WriteLine("You are now at: " + CurrentLocation.Name);
        Text.nl();
        CurrentLocation.Events(this);
    }

    public int Attack(Monster monster)
    {
        Random random = new Random();

        int critical = random.Next(0, 100);
        int damage = 0;
        if (Weapon2 == null)
        {
            damage = (int)(random.Next(1, 10) * (Weapon1.Damage_Multiplier));
        }
        else
        {
            damage = (int)(random.Next(1, 10) * (Weapon1.Damage_Multiplier + (Weapon2.Damage_Multiplier - 1)));
        }
        // 10% chance to critical hit
        if (critical < 10)
        {
            damage *= 2;
        }

        Text.Info($"{monster.Name} has {monster.CurrentHitPoints}HP left.");
        Text.Warning($"{(critical < 10 ? "Critical! " : string.Empty)}Player {Name} attacked {monster.Name} for {damage} damage.");

        return damage;
    }

    public void TakeDamage(int damage)
    {
        CurrentHitPoints -= damage;
    }

    public void GainExperience(int experience)
    {
        Text.GoodNews($"Player {Name} gained {experience} experience.");
        Experience += experience;
    }

    public void Get_Gold(int gold)
    {
        Balance += gold;
    }

    public void Stats()
    {
        Text.Info($"Player: {Name}");
        Text.Info($"HP: {CurrentHitPoints}/{MaximumHitPoints}");
        Text.Info($"Experience: {Experience}");
        Text.Info($"Gold: {Balance}");
        Text.Info($"Weapon 1: {Weapon1.Name}");
        if (Weapon2 != null)
        {
            Text.Info($"Weapon 2: {Weapon2.Name}");
        }
        Inv.OpenInventory();
    }
}