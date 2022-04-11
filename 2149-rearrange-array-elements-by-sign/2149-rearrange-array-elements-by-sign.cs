public class Solution
{
    public int[] RearrangeArray(int[] nums)
    {
        var positiveQueue = new Queue<int>(nums.Length / 2);
        var negativeQueue = new Queue<int>(nums.Length / 2);

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                positiveQueue.Enqueue(nums[i]);
            }
            else
            {
                negativeQueue.Enqueue(nums[i]);
            }
        }

        var index = 0;

        while (positiveQueue.Count > 0)
        {
            nums[index++] = positiveQueue.Dequeue();
            nums[index++] = negativeQueue.Dequeue();
        }

        return nums;
    }
}