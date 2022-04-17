public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        return s.OrderBy(x => x).SequenceEqual(t.OrderBy(x => x));
    }
}