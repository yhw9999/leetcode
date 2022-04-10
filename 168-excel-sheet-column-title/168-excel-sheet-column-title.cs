public class Solution
{
    public string ConvertToTitle(int columnNumber)
    {
        var sb = new StringBuilder();
        var stack = new Stack<char>();
        while (columnNumber > 0)
        {
            var remain = columnNumber % 26;
            columnNumber--;
            columnNumber /= 26;

            stack.Push(remain == 0 ? 'Z' : (char)(remain + 64));
        }

        while (stack.Count > 0)
        {
            sb.Append(stack.Pop());
        }

        return sb.ToString();
    }
}