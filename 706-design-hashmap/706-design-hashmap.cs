public class MyHashMap
{
    int[,] map = new int[1000001, 2];

    public MyHashMap()
    {
        for (int i = 0; i < 1000001; i++)
        {
            map[i, 1] = -1;
        }
    }

    public void Put(int key, int value)
    {
        map[key, 1] = value;
    }

    public int Get(int key)
    {
        return map[key, 1];
    }

    public void Remove(int key)
    {
        map[key, 1] = -1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */