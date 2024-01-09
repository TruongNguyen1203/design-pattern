namespace AbstractionFactory;

public class GooglePlaceCreator : IPlaceCreator
{
    private readonly IStateStore _stateStore;

    public GooglePlaceCreator(IStateStore stateStore)
    {
        _stateStore = stateStore;
    }
    public State? CreateStateFromCity(string city, string sessionId)
    {
        string name = _stateStore.GetStateByNameOrAbbreviation(city)?.Name ?? "unknow";
        return !string.IsNullOrEmpty(name) ? new State(name, sessionId) : null;
    }
}

// internal class Program
// {
//     public static void Main(string[] args)
//     {
//         IPlaceCreator placeCreator = new GooglePlaceCreator(new StateStore());
//         var state = placeCreator.CreateStateFromCity("Alaska", "123");
//         Console.WriteLine("State: " + state.Name + " " + state.Abbreviation);
//     }
// }