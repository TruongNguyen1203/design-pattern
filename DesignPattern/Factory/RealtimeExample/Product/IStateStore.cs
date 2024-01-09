namespace AbstractionFactory;

public interface IStateStore
{
    State GetStateByNameOrAbbreviation(string searchTerm);
    List<State> GetStates(string searchTerm);
}