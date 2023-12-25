namespace ConsoleApp3;

public class Calculator<T> where T : IComparable<T>
{
    public static Calculator<T> CreateInstance()
    {
        return new Calculator<T>();
    }

    public T Add(T x, T y)
    {
        return (dynamic) x + (dynamic) y;
    }

    T Zero()
    {
        return default(T);
    }
    
    
}