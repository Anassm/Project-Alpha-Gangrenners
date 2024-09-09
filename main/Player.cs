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
}