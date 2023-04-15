namespace TheSunSystem;

public class StarSystem
{
    private List<Star> _stars;
    private List<Planet> _planets;
    private List<Moon> _moons;

    public StarSystem(List<Star> stars, List<Planet> planets, List<Moon> moons)
    {
        _stars = stars;
        _planets = planets;
        _moons = moons;
    }
    
    public List<Star> Stars { get
    {
        return _stars;
    } }
    public List<Planet> Planets {
        get { return _planets; }
    }

    public List<Moon> Moons
    {
        get
        {
            return _moons;
        }
    }

    public void PlanetAdd(Planet planet)
    {
        _planets.Add(planet);
    }
    
    public void PlanetsShow()
    {
        int count = 0;
        foreach (Planet planet  in _planets)
        {
            count++;
            Console.WriteLine($"Номер планеты:{count} , название: {planet.Name}");
        }
        Console.WriteLine($"Число планет в системе:{count}");
    }

    public void PlanetShow(int index)
    {
        Console.WriteLine(_planets.ElementAt(index-1).ToString());
    }

    public void StarsShow()
    {
        int count = 0;
        foreach (Star star  in _stars)
        {
            count++;
            Console.WriteLine($"Номер звезды:{count} , название: {star.Name}");
        }
        Console.WriteLine($"Число звёзд в системе:{count}");
    }
    public void StarShow(int index)
    {
        Console.WriteLine(_stars.ElementAt(index-1).ToString());

    }
    public void MoonsShow()
    {
        int count = 0;
        foreach (Moon moon  in _moons)
        {
            count++;
            Console.WriteLine($"Номер спутника в системе:{count} , название: {moon.Name}, планета: {moon.Planet}");
        }
        Console.WriteLine($"Число спутников в системе:{count}");
    }
    public void MoonShow(int index)
    {
        Console.WriteLine(_moons.ElementAt(index-1).ToString());

    }
}