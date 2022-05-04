public class Solution
{
    public int MaxOperations(int[] nums, int k)
    {
        var result = 0;
        Array.Sort(nums);

        var left = 0;
        var right = nums.Length - 1;

        while (right > left)
        {
            var sum = nums[right] + nums[left];

            if (sum == k)
            {
                result++;
                right--;
                left++;
            }
            else if(sum > k)
            {
                right--;
            }
            else
            {
                left++;
            }
        }

        return result;
    }
}