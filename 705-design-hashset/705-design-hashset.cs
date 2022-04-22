public class MyHashSet
{
    bool[] map = new bool[1000001];

    public MyHashSet()
    {

    }

    public void Add(int key)
    {
        map[key] = true;
    }

    public void Remove(int key)
    {
        map[key] = false;
    }

    public bool Contains(int key)
    {
        return map[key];
    }
}
/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */