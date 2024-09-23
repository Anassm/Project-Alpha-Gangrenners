public class Player
{
    public int CurrentHitPoints;
    public Location CurrentLocation;
    public int MaximumHitPoints;
    public string Name;
    public int Experience;
    public int Balance;
    public Item Weapon1;
    public Item? Weapon2;


    public Player(int currentHitPoints, Location currentLocation, int maximumHitPoints, string name, Item weapon1, Item? weapon2)

    {
        CurrentHitPoints = currentHitPoints;
        CurrentLocation = currentLocation;
        MaximumHitPoints = maximumHitPoints;
        Name = name;
        Balance = 25;
        Weapon1 = weapon1;
        Weapon2 = weapon2;
    }


    // change location of player
    public void ChangeDirections()
    {
        CurrentLocation.GetMap();
        Console.WriteLine("Where do you want to go?");
        string direction = Console.ReadLine().ToUpper();
        bool validDirection = CurrentLocation.CheckDirection(direction);
        while (!validDirection)
        {
            Console.WriteLine("Where do you want to go?");
            direction = Console.ReadLine().ToUpper();
            validDirection = CurrentLocation.CheckDirection(direction);
        }
        Location newLocation = CurrentLocation.GetNewLocation(direction);
        CurrentLocation = newLocation;
        Console.WriteLine("You are now at: " + CurrentLocation.Name);
        Console.WriteLine("");
        CurrentLocation.Events(this);
    }

    public int Attack(Monster monster)
    {
        Random random = new Random();

        int critical = random.Next(0, 100);
        int damage = (int)(random.Next(1, 10) * (Weapon1.Damage_Multiplier + (Weapon2.Damage_Multiplier - 1)));

        // 10% chance to critical hit
        if (critical < 10)
        {
            damage *= 2;
        }

        Console.WriteLine($"{monster.Name} has {monster.CurrentHitPoints}HP left.");
        Console.WriteLine($"{(critical < 10 ? "Critical!" : string.Empty)} Player {Name} attacked {monster.Name} for {damage} damage.");

        return damage;
    }

    public void TakeDamage(int damage)
    {
        CurrentHitPoints -= damage;
    }

    public void GainExperience(int experience)
    {
        Console.WriteLine($"Player {Name} gained {experience} experience.");
        Experience += experience;
    }

    public void Get_Gold(int gold)
    {
        Balance += gold;
    }
}