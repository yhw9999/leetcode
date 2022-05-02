public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        var left = 0;
        var right = nums.Length - 1;

        while (left < right)
        {
            while (nums[left] % 2 == 0 && left < right)
            {
                left++;
            }

            while (nums[right] % 2 == 1 && left < right)
            {
                right--;
            }

            if (left < right)
            {
                var tmpValue = nums[left];
                nums[left] = nums[right];
                nums[right] = tmpValue;
            }
            else
            {
                break;
            }
        }

        return nums;
    }
}