public class Solution
{
	public int TwoCitySchedCost(int[][] costs)
	{
		var sum = 0;
		var size = costs.Length / 2;
		var aCount = 0;
		var bCount = 0;

		foreach (var item in costs.OrderByDescending(x => Math.Abs(x[0] - x[1])))
		{
			var a = item[0];
			var b = item[1];

			if (a < b)
			{
				if (aCount < size)
				{
					sum += a;
					aCount++;
				}
				else
				{
					sum += b;
					bCount++;
				}
			}
			else
			{
				if (bCount < size)
				{
					sum += b;
					bCount++;
				}
				else
				{
					sum += a;
					aCount++;
				}
			}
		}

		return sum;
	}
}