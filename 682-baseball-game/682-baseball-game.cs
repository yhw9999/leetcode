public class Solution
{
    public int CalPoints(string[] ops)
    {
        var stack = new Stack<int>();

        foreach (var op in ops)
        {
            switch (op)
            {
                case "C":
                    stack.Pop();
                    break;
                case "D":
                    stack.Push(stack.Peek() * 2);
                    break;
                case "+":
                    var tmp = stack.Pop();
                    var newValue = tmp + stack.Peek();
                    stack.Push(tmp);
                    stack.Push(newValue);
                    break;
                default:
                    stack.Push(int.Parse(op));
                    break;
            }
        }

        return stack.Sum();
    }
}