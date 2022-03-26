public class Solution
{
	public int Search(int[] nums, int target)
	{
		var minIndex = 0;
		var maxIndex = nums.Length - 1;
		var midIndex = 0;

		while (minIndex != maxIndex)
		{
			var newMidIndext = (minIndex + maxIndex) / 2;

			if (newMidIndext == midIndex)
			{
				break;
			}
			else
			{
				midIndex = newMidIndext;
			}

			var currentNum = nums[midIndex];

			if (currentNum < target)
			{
				minIndex = midIndex;
			}
			else if(currentNum > target)
			{
				maxIndex = midIndex;
			}
			else
			{
				return midIndex;
			}
		}

		if (nums[minIndex] == target)
		{
			return minIndex;
		}

		if (nums[maxIndex] == target)
		{
			return maxIndex;
		}

		return -1;
	}
}