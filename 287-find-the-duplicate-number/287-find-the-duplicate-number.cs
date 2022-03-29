public class Solution
{
	public int FindDuplicate(int[] nums)
	{
		for (int i = 0; i < nums.Length; i++)
		{
            var value = Math.Abs(nums[i]);
			var index = value - 1;

			if (nums[index] < 0)
			{
				return value;
			}
			else
			{
				nums[index] = -nums[index];
			}
		}

		return -1;
	}
}