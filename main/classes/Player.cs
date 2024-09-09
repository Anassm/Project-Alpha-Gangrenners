public class Player
{
    public int CurrentHitPoints;
    public Location CurrentLocation;
    public Weapon CurrentWeapon;
    public int MaximumHitPoints;
    public string Name;

    public Player(int currentHitPoints, Location currentLocation, Weapon currentWeapon, int maximumHitPoints, string name)
    {
        this.CurrentHitPoints = currentHitPoints;
        this.CurrentLocation = currentLocation;
        this.CurrentWeapon = currentWeapon;
        this.MaximumHitPoints = maximumHitPoints;
        this.Name = name;
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
    }


}