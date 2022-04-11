public class Solution
{
    public string TruncateSentence(string s, int k)
    {
        var sb = new StringBuilder();
        k--;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ' && k-- == 0)
            {
                break;
            }

            sb.Append(s[i]);
        }

        return sb.ToString();
    }
}