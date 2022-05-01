public class Solution
{
    public bool BackspaceCompare(string s, string t)
    {
        return RemainString(s).Equals(RemainString(t));
    }

    private string RemainString(string s)
    {
        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '#')
            {
                stack.TryPop(out var _);
            }
            else
            {
                stack.Push(s[i]);
            }
        }

        return new string(stack.ToArray());
    }
}