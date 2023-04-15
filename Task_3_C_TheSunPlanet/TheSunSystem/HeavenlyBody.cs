namespace TheSunSystem;

public abstract class HeavenlyBody
{
    private string _name;
    private long _age;
    private double _weight;

    public HeavenlyBody(string name, long age, double weight)
    {
        _name = name;
        _age = age;
        _weight = weight;
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (!string.IsNullOrEmpty(value) && !char.IsDigit(value[0]))
            {
                _name = value;
            }
            else
            {
                Console.WriteLine("Error! Name is empty or is begin from num.");
            }
        }
    }


    public long Age
    {
        get { return _age; }
        set
        {
            if (value > 0)
            {
                _age = value;
            }
            else
            {
                Console.WriteLine("Error! Age is less then zero.");
            }
        }
    }


    public double Weight
    {
        get { return _weight; }
        set
        {
            if (!(value <= 0))
            {
                _weight = value;
            }
            else
            {
                Console.WriteLine("Error! Weight is less then or equals zero.");
            }
        }
    }


    public override string ToString()
    {
        return $"Название:{Name}, возраст: {Age}, масса: {Weight}";
    }
}