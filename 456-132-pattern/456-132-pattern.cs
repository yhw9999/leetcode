public class Solution
{
    public bool Find132pattern(int[] nums)
    {
        if (nums.Length < 3)
        {
            return false;
        }

        var mins = new int[nums.Length];

        mins[0] = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            mins[i] = Math.Min(nums[i], mins[i - 1]);
        }

        var stack = new Stack<int>();

        for (int i = nums.Length - 1; i > 0; i--)
        {
            if (nums[i] <= mins[i])
            {
                continue;
            }

            while (stack.TryPeek(out var peek))
            {
                if (peek <= mins[i])
                {
                    stack.Pop();
                }
                else
                {
                    break;
                }
            }

            if (stack.TryPeek(out var peek2))
            {
                if (peek2 < nums[i])
                {
                    return true;
                }
            }

            stack.Push(nums[i]);
        }

        return false;
    }
}