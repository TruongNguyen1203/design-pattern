namespace AbstractionFactory;

public interface IPlaceCreator
{
    State? CreateStateFromCity(string city, string sessionId);
}