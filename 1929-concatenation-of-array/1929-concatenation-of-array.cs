public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        var result = new int[nums.Length * 2];

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i];
            result[i + nums.Length] = nums[i];
        }

        return result;
    }
}