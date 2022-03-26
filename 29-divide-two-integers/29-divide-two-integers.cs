public class Solution
{
	public int Divide(int dividend, int divisor)
	{
		if (divisor == 1)
		{
			return dividend;
		}

		if (divisor == -1)
		{
			if (dividend == int.MaxValue)
			{
				return int.MinValue;
			}
			else if(dividend == int.MinValue)
			{
				return int.MaxValue;
			}
			else
			{
				return -dividend;
			}
		}

		return dividend / divisor;
	}
}