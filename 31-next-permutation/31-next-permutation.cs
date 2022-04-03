public class Solution
{
	public void NextPermutation(int[] nums)
	{
		if (IsDesc(nums))
		{
			Reverse(nums);
			return;
		}

		var leftPoint = 0;

		var index = 0;
		while (index < nums.Length - 1)
		{
			if (nums[index] < nums[index + 1])
			{
				leftPoint = index;
			}

			index++;
		}

		index = nums.Length - 1;

		var changePoint = leftPoint;

		while (index > leftPoint)
		{
			if (nums[index] > nums[index - 1])
			{
				changePoint = index;

				break;
			}

			index--;
		}

		var minIndex = changePoint;

		index = nums.Length - 1;

		while (index > changePoint)
		{
			if (nums[index] < nums[minIndex] && nums[index] > nums[leftPoint])
			{
				minIndex = index;
			}

			index--;
		}

		Swap(nums, leftPoint, minIndex);

		Array.Sort(nums, changePoint, nums.Length - changePoint);
	}

	private void Reverse(int[] nums)
	{
		for (int i = 0; i < nums.Length / 2; i++)
		{
			Swap(nums, i, nums.Length - i - 1);
		}
	}

	private void Swap(int[] nums, int op1, int op2)
	{
		var tmp = nums[op1];
		nums[op1] = nums[op2];
		nums[op2] = tmp;
	}

	private bool IsDesc(int[] nums)
	{
		for (int i = nums.Length - 1; i > 0; i--)
		{
			if (nums[i] > nums[i - 1])
			{
				return false;
			}
		}

		return true;
	}
}