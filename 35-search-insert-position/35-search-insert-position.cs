public class Solution
{
	public int SearchInsert(int[] nums, int target)
	{
		var index = Array.BinarySearch(nums, target);

		if (index < 0)
		{
			return Math.Abs(index) - 1;
		}

		return index;
	}
}