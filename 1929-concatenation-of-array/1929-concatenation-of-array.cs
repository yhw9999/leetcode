public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        var result = new int[nums.Length * 2];

        for (int i = 0; i < nums.Length * 2; i++)
        {
            result[i] = nums[i % nums.Length];
        }

        return result;
    }
}