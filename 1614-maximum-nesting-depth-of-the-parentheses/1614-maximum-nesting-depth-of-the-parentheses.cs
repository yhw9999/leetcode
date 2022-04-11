public class Solution
{
    public int MaxDepth(string s)
    {
        var max = 0;
        var currentParentheses = 0;
        foreach (var item in s)
        {
            switch (item)
            {
                case '(':
                    currentParentheses++;
                    break;
                case ')':
                    currentParentheses--;
                    break;
            }

            if (currentParentheses > max)
            {
                max = currentParentheses;
            }
        }

        return max;
    }
}