public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        var word1StringBuilder = new StringBuilder();
        var word2StringBuilder = new StringBuilder();

        foreach (var item in word1)
        {
            word1StringBuilder.Append(item);
        }

        foreach (var item in word2)
        {
            word2StringBuilder.Append(item);
        }

        return word1StringBuilder.ToString().Equals(word2StringBuilder.ToString());
    }
}