namespace TheSunSystem;

public class Planet : HeavenlyBody
{
    private List<Star> _star;

    public List<Star> Stars
    {
        get
        {
            return _star;
        }
        set
        {
            if (value.Count > 0)
            {
                _star = value;
            }
        }
    }

    public Planet(string name,long age, double weight, List<Star> star):base(name,age,weight)
    {
        _star = star;
    }
    
}