public class Solution
{
	public IList<string> FizzBuzz(int n)
	{
		var result = new string[n];

		for (int i = 1; i <= n; i++)
		{
			var index = i - 1;

			if (i % 15 == 0)
			{
				result[index] = "FizzBuzz";
			}
			else if (i % 5 == 0)
			{
				result[index] = "Buzz";
			}
			else if (i % 3 == 0)
			{
				result[index] = "Fizz";
			}
			else
			{
				result[index] = i.ToString();
			}
		}

		return result;
	}
}