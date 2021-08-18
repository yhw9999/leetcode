public class Solution
{
	public bool CanBeIncreasing(int[] nums)
	{
		if (!IsIncrease(nums))
		{
			var toList = nums.ToList();

			for (int i = 0; i < nums.Length; i++)
			{
				var value = nums[i];
				toList.RemoveAt(i);

				if (IsIncrease(toList))
				{
					return true;
				}

				toList.Insert(i, value);
			}

			return false;
		}

		return true;

	}

	private bool IsIncrease(IList<int> nums)
	{
		for (int i = 0; i < nums.Count - 1; i++)
		{
			if (nums[i] >= nums[i + 1])
			{
				return false;
			}
		}

		return true;
	}
}