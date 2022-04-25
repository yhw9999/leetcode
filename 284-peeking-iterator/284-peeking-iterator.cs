// C# IEnumerator interface reference:
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

class PeekingIterator
{
    bool hasNext = true;
    IEnumerator<int> iterator;
    // iterators refers to the first element of the array.
    public PeekingIterator(IEnumerator<int> iterator)
    {
        this.iterator = iterator;
    }

    // Returns the next element in the iteration without advancing the iterator.
    public int Peek()
    {
        return iterator.Current;
    }

    // Returns the next element in the iteration and advances the iterator.
    public int Next()
    {
        var current = iterator.Current;
        hasNext = iterator.MoveNext();

        return current;
    }

    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext()
    {
        return hasNext;
    }
}