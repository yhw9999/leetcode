public class Solution
{
	public int ClimbStairs(int n)
	{
		if (n == 1)
		{
			return 1;
		}

		if (n == 2)
		{
			return 2;
		}

		var op1 = 1;
		var op2 = 2;

		for (int i = 2; i < n; i++)
		{
			var sum = op1 + op2;
			op1 = op2;
			op2 = sum;
		}

		return op2;
	}
}