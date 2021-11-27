public class Solution
{
	public int RemoveDuplicates(int[] nums)
	{
		if (nums.Length == 0)
		{
			return 0;
		}

		var max = nums[0];
		var currentIndex = 1;
		var result = 1;

		for (int i = 1; i < nums.Length; i++)
		{
			if (max < nums[i])
			{
				result++;
				max = nums[i];
				nums[currentIndex++] = nums[i];
			}
		}

		return result;
	}
}