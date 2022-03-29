public class Solution
{
	public int FindDuplicate(int[] nums)
	{
		var set = new HashSet<int>();
		var result = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			if (set.Contains(nums[i]))
			{
				result = nums[i];
				break;
			}

			set.Add(nums[i]);
		}

		return result;
	}
}