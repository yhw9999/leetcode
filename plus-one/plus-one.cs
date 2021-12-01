public class Solution
{
	public int[] PlusOne(int[] digits)
	{
		var stack = new Stack<int>();

		var isIncrease = true;

		for (int i = digits.Length - 1; i >= 0 ; i--)
		{
			if (!isIncrease)
			{
				stack.Push(digits[i]);
			}
			else
			{
				if (digits[i] == 9)
				{
					stack.Push(0);
				}
				else
				{
					stack.Push(digits[i] + 1);
					isIncrease = false;
				}
			}
		}


		if (isIncrease)
		{
			stack.Push(1);
		}

		return stack.ToArray();
	}
}