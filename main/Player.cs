public class Player
{
    public int CurrentHitPoints;
    public Location CurrentLocation;
    public Weapon CurrentWeapon;
    public int MaximumHitPoints;
    public string Name;
    public int Experience;
    public int Balance;

    // Can equipment slots better be an object or dictionary?
    //public Dictionary<string, Item> Equipment = new();

    public Player(int currentHitPoints, Location currentLocation, Weapon currentWeapon, int maximumHitPoints, string name)
    {
        this.CurrentHitPoints = currentHitPoints;
        this.CurrentLocation = currentLocation;
        this.CurrentWeapon = currentWeapon;
        this.MaximumHitPoints = maximumHitPoints;
        this.Name = name;
        this.Balance = 25;
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
        int damage = random.Next(0, this.CurrentWeapon.MaximumDamage);

        // 10% chance to critical hit
        if (critical < 10)
        {
            damage *= 2;
        }

        Console.WriteLine($"{monster.Name} has {monster.CurrentHitPoints}HP left.");
        Console.WriteLine($"{(critical < 10 ? "Critical!" : string.Empty)} Player {this.Name} attacked {monster.Name} for {damage} damage.");

        return damage;
    }

    public void TakeDamage(int damage)
    {
        this.CurrentHitPoints -= damage;
    }

    public void GainExperience(int experience)
    {
        Console.WriteLine($"Player {this.Name} gained {experience} experience.");
        this.Experience += experience;
    }

    public void Get_Gold(int gold)
    {
        this.Balance += gold;
    }
}