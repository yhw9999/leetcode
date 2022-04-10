public class Solution
{
    public int[] Shuffle(int[] nums, int n)
    {
        var queue = new Queue<int>();
        var half = nums.Length / 2;

        for (int i = 0; i < half; i++)
        {
            queue.Enqueue(nums[i]);
            queue.Enqueue(nums[i + half]);
        }

        return queue.ToArray();
    }
}