// See https://aka.ms/new-console-template for more information

public sealed class Singleton
{
    private Singleton()
    {
    }

    private static Singleton _instance;
    private static readonly object _lock = new object();
    public string Value { get; set; }

    public static Singleton GetInstance(string value)
    {
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                    _instance.Value = value;
                }
            }
        }

        return _instance;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Thread thread1 = new Thread(() =>
        {
            TestSingleton("One");
        });
        
        Thread thread2 = new Thread(() =>
        {
            TestSingleton("Two");
        });
        
        thread1.Start();
        thread2.Start();
        
        thread1.Join();
        thread2.Join();
        // Caching caching = Caching.GetInstance();
        // caching.Add("Id", 1);
        // caching.Add("Name", "Nguyen");
        // caching.Add("Id", 2);
        // caching.AddOrUpdate("Id", 2);
        // Console.WriteLine(caching.Get("Id"));
        // Console.WriteLine(caching.Get("Name"));
    }

    private static void TestSingleton(string value)
    {
        var instane = Singleton.GetInstance(value);
        Console.WriteLine(instane.Value);
    }
}