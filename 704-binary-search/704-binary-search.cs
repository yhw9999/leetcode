public class Solution
{
	public int Search(int[] nums, int target)
	{
		var minIndex = 0;
		var maxIndex = nums.Length - 1;
		var midIndex = 0;

		while (minIndex <= maxIndex)
		{
			midIndex = (minIndex + maxIndex) / 2;

			var currentNum = nums[midIndex];

			if (currentNum < target)
			{
				minIndex = midIndex + 1;
			}
			else if(currentNum > target)
			{
				maxIndex = midIndex - 1;
			}
			else
			{
				return midIndex;
			}


		}

		return -1;
	}
}