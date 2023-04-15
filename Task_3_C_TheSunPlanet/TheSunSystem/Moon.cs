namespace TheSunSystem;

public class Moon : HeavenlyBody
{
    private Planet _planet;

    public string Planet
    {
        get
        {
            return _planet.Name;
        }
    }

    public Moon(string name, long age, double weight, Planet planet) : base(name, age, weight)
    {
        _planet = planet;
    }
}