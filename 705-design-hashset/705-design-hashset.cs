public class MyHashSet
{
    List<int> container = new List<int>();

    public MyHashSet()
    {

    }

    public void Add(int key)
    {
        if (!container.Contains(key))
        {
            container.Add(key);
        }
    }

    public void Remove(int key)
    {
        container.Remove(key);
    }

    public bool Contains(int key)
    {
        return container.Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */