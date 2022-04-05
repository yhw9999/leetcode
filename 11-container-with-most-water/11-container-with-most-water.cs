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
			var minHeight = Math.Min(height[front], height[back]);
			var area = size-- * minHeight;

			if (result < area)
			{
				result = area;
			}

			if (height[front] > height[back])
			{
				back--;
			}
			else
			{
				front++;
			}
		}

		return result;
	}
}