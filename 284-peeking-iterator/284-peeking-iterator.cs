// C# IEnumerator interface reference:
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

class PeekingIterator
{
    int size = 0;
    int index = -1;
    int current = 0;
    IEnumerator<int> iterator;
    // iterators refers to the first element of the array.
    public PeekingIterator(IEnumerator<int> iterator)
    {
        this.iterator = iterator;

        while (iterator.MoveNext())
        {
            size++;
        }

        iterator.Reset();
        iterator.MoveNext();
    }

    // Returns the next element in the iteration without advancing the iterator.
    public int Peek()
    {
        return iterator.Current;
    }

    // Returns the next element in the iteration and advances the iterator.
    public int Next()
    {
        current = iterator.Current;

        if (HasNext())
        {
            index++;
            iterator.MoveNext();
        }

        return current;
    }

    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext()
    {
        return index < size;
    }
}