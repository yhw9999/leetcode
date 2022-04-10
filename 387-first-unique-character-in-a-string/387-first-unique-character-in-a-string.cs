public class Solution
{
    public int FirstUniqChar(string s)
    {
        var increasement = new Dictionary<char, int>();
        var indices = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!increasement.TryGetValue(s[i], out var value))
            {
                increasement.Add(s[i], 0);
                indices.Add(s[i], i);
            }

            increasement[s[i]]++;
        }

        var first = increasement.FirstOrDefault(x => x.Value == 1);

        return first.Key == default(char) ? -1 :indices[first.Key];
    }
}