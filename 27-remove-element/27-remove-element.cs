public class Solution
{
	public int RemoveElement(int[] nums, int val)
	{
		var saveIndex = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			if (nums[i] != val)
			{
				nums[saveIndex++] = nums[i];
			}
		}

		return saveIndex;
	}
}