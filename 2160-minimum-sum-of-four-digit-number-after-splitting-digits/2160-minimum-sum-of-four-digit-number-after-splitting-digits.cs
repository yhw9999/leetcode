public class Solution
{
    public int MinimumSum(int num)
    {
        var nums = new int[4];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = num % 10;
            num /= 10;
        }

        Array.Sort(nums);

        return nums[0] * 10 + nums[2] + nums[1] * 10 + nums[3];
    }
}
