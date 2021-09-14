public class Solution {
        public void NextPermutation(int[] nums)
        {
			if (IsDesc(nums))
			{
				Array.Sort(nums);
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

		private void Swap(int[] nums, int leftPoint, int minIndex)
		{
			var tmp = nums[leftPoint];
			nums[leftPoint] = nums[minIndex];
			nums[minIndex] = tmp;
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