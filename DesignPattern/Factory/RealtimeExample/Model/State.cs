namespace AbstractionFactory;

public class State
{
    public string Name { get; set; }
    public string Abbreviation { get; set; }

    public State(string name, string abbreviation)
    {
        Name = name;
        Abbreviation = abbreviation;
    }
}