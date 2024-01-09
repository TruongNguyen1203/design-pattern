public interface ICaching
{
    bool Add(object key, object value);
    bool AddOrUpdate(object key, object value);
    bool Remove(object key);
    object Get(object key);
    void Clear();
}