public class Solution
{
    public IList<int> TargetIndices(int[] nums, int target)
    {
        var result = new List<int>();

        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < target)
            {
                continue;
            }

            if (nums[i] == target)
            {
                result.Add(i);
            }
            else if(nums[i] > target)
            {
                break;
            }
        }

        return result;
    }
}