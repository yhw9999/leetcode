public class Solution
{
    public int[] RearrangeArray(int[] nums)
    {
        var result = new int[nums.Length];
        var positiveIndex = 0;
        var negativeIndex = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                result[positiveIndex] = nums[i];
                positiveIndex += 2;
            }
            else
            {
                result[negativeIndex] = nums[i];
                negativeIndex += 2;
            }
        }

        return result;
    }
}