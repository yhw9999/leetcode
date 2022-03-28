public class Solution
{
	public int TwoCitySchedCost(int[][] costs)
	{
		var sum = 0;
		var size = costs.Length / 2;
		var aCount = 0;
		var bCount = 0;

		var ordered = costs.OrderByDescending(x => Math.Abs(x[0] - x[1]));

		foreach (var item in ordered)
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
					var totalCount = aCount + bCount;
					sum += ordered.Skip(totalCount).Take(size - bCount).Sum(x=> x[1]);
					return sum;
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
					var totalCount = aCount + bCount;
					sum += ordered.Skip(totalCount).Take(size - aCount).Sum(x => x[0]);
					return sum;
				}
			}
		}

		return sum;
	}
}