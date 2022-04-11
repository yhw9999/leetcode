public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        var result = 0;

        var set = new HashSet<char>(allowed);

        foreach (var word in words)
        {
            if (word.Count(c => set.Contains(c)) == word.Length)
            {
                result++;
            }
        }

        return result;
    }
}