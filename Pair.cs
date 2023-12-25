namespace ConsoleApp3.Pair;

public class Pair<T,U> where T : class  where U : class
{
    private T _first;
    private U _second;

    public Pair(T first, U second)
    {
        _first = first;
        _second = second;
    }

    public T First
    {
        get { return _first; }
        set { _first = value; }
    }

    public U Second
    {
        get { return _second; }
        set { _second = value; }
    }

    public override string ToString()
    {
        return $"({_first}, {_second})";
    }   
}