namespace AbstractionFactory;

public class StateStore : IStateStore
{
    private List<State> _states = new List<State>
    {
        new State("Alaska", "AK"),
        new State("Geogia", "GA")
    };

    public State GetStateByNameOrAbbreviation(string searchTerm) =>
        _states.SingleOrDefault(s => s.Name.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));

    public List<State> GetStates(string searchTerm) =>
        _states.Where(s => s.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
}