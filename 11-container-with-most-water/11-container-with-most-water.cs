public class Solution
{
	public int MaxArea(int[] height)
	{
		var front = 0;
		var back = height.Length - 1;
		var size = back;

		var result = 0;

		while (size > 0)
		{
			int minHeight;

			if (height[front] > height[back])
			{
				minHeight = height[back];
				back--;
			}
			else
			{
				minHeight = height[front];
				front++;
			}

			var area = size-- * minHeight;

			if (result < area)
			{
				result = area;
			}
		}

		return result;
	}
}