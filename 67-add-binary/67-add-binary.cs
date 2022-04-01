public class Solution
{
	public string AddBinary(string a, string b)
	{
		var stack = new Stack<char>();
		var aStack = new Stack<char>(a);
		var bStack = new Stack<char>(b);

		var isIncrease = false;

		while (aStack.Count > 0 || bStack.Count > 0)
		{
			aStack.TryPop(out var op1);
			bStack.TryPop(out var op2);

			if (op1 == '1' && op2 == '1')
			{
				if (isIncrease)
				{
					stack.Push('1');
				}
				else
				{
					stack.Push('0');
				}
				isIncrease = true;
			}
			else if (op1 == '1' || op2 == '1')
			{
				if (isIncrease)
				{
					stack.Push('0');
					isIncrease = true;
				}
				else
				{
					stack.Push('1');
					isIncrease = false;
				}
			}
			else
			{
				if (isIncrease)
				{
					stack.Push('1');
				}
				else
				{
					stack.Push('0');
				}
					
				isIncrease = false;
			}
		}

		if (isIncrease)
		{
			stack.Push('1');
		}

		return new string(stack.ToArray());
	}
}