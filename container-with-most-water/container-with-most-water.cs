public class Solution
{
	public int MaxArea(int[] height)
	{
		var max = 0;
		var start = 0;
		var last = height.Length - 1;

		while (last > start)
		{
			var gap = last - start;
			var rect = gap * Math.Min(height[start], height[last]);

			if (max < rect)
			{
				max = rect;
			}

			if (height[start] < height[last])
			{
				start++;
			}
			else
			{
				last--;
			}
		}

		return max;
	}
}
