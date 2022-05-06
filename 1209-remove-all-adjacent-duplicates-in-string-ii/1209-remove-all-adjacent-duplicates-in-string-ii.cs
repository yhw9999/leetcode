public class Solution
{
    public string RemoveDuplicates(string s, int k)
    {
        var stack = new Stack<KeyValuePair<char, int>>();
        var limit = k - 1;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            var c = s[i];

            if (stack.TryPeek(out var peek))
            {
                if (peek.Key == c)
                {
                    stack.Pop();

                    if (peek.Value != limit)
                    {
                        stack.Push(new KeyValuePair<char, int>(c, peek.Value + 1));
                    }
                }
                else
                {
                    stack.Push(new KeyValuePair<char, int>(c, 1));
                }
            }
            else
            {
                stack.Push(new KeyValuePair<char, int>(c, 1));
            }
        }

        var result = new StringBuilder();

        while (stack.TryPop(out var peek))
        {
            for (int i = 0; i < peek.Value; i++)
            {
                result.Append(peek.Key);
            }
        }

        return result.ToString();
    }
}