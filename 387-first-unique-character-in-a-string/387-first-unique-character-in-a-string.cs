public class Solution
{
    public int FirstUniqChar(string s)
    {
        var increasement = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            increasement[s[i] - 'a']++;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (increasement[s[i] - 'a'] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}