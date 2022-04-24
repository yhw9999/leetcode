public class CustomStack
{
    Stack<int> stack;
    Dictionary<int, int> increments;
    int MaxSize = 0;
    public CustomStack(int maxSize)
    {
        stack = new Stack<int>(maxSize);
        MaxSize = maxSize;
        increments = new Dictionary<int, int>();

        for (int i = 1; i <= maxSize; i++)
        {
            increments.Add(i, 0);
        }
    }

    public void Push(int x)
    {
        if (MaxSize > stack.Count)
        {
            stack.Push(x);
        }
    }

    public int Pop()
    {
        if (stack.Count > 0)
        {
            var increase = increments[stack.Count];
            increments[stack.Count] = 0;
            return increase + stack.Pop();
        }

        return -1;
    }

    public void Increment(int k, int val)
    {
        for (int i = 1; i <= Math.Min(k, stack.Count); i++)
        {
            increments[i] += val;
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */