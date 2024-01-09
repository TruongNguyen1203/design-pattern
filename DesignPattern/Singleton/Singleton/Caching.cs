public sealed class Caching : ICaching
{
    private static Caching _caching;
    private static readonly object _lock = new object();
    
    private Dictionary<object, object> _dictionary = new Dictionary<object, object>();
    
    private Caching(){}

    public static Caching GetInstance()
    {
        if (_caching == null)
        {
            lock (_lock)
            {
                if (_caching == null)
                {
                    _caching = new Caching();
                }
            }
        }

        return _caching;
    }
    public bool Add(object key, object value)
    {
       return _dictionary.TryAdd(key, value);
    }

    public bool AddOrUpdate(object key, object value)
    {
        if (_dictionary.ContainsKey(key))
        {
            _dictionary.Remove(key);
        }
        return _dictionary.TryAdd(key, value);
    }

    public bool Remove(object key)
    {
        return _dictionary.Remove(key);
    }

    public object Get(object key)
    {
        if (_dictionary.ContainsKey(key))
        {
            return _dictionary[key];
        }

        return null;
    }

    public void Clear()
    {
        _dictionary.Clear();
    }
}