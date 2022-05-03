public class Solution
{
    public int FindUnsortedSubarray(int[] nums)
    {
        var sorted = new int[nums.Length];
        Array.Copy(nums, sorted, nums.Length);
        Array.Sort(sorted);

        var left = 0;
        var right = nums.Length - 1;

        while (nums[left] == sorted[left])
        {
            if (left == right)
            {
                return 0;
            }

            left++;
        }


        while (nums[right] == sorted[right])
        {
            right--;
        }

        return right - left + 1;
    }
}