namespace ConsoleApp3.Stack;

public class Stack<T> where T : IComparable<T>
{
    private List<T> _list = new List<T>();

    public void Push(T items)
    {
        _list.Add(items);
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("List is empty");
        }

        return _list[_list.Count - 1];
    }

    public bool IsEmpty()
    {
        return _list.Count == 0;
    }

    public T Max()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("List is empty");
        }

        T max = _list[0];
        foreach (T item in _list)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }

        return max;
    }
}

