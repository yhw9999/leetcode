public class Solution
{
	public int SumOfUnique(int[] nums)
	{
		var dict = new Dictionary<int, int>();

		var sum = 0;

		for (int i = 0; i < nums.Length; i++)
		{
			if (dict.TryGetValue(nums[i], out var value))
			{
				if (value != -1)
				{
					dict[nums[i]] = -1;
					sum -= nums[i];
				}
			}
			else
			{
				dict.Add(nums[i], 1);
				sum += nums[i];
			}
		}

		return sum;
	}
}