public class Solution
{
	public int Reverse(int x)
	{
		if (x == 0)
		{
			return 0;
		}
		else
		{
			var stack = default(Stack<char>);

			if (x < 0)
			{
				stack = new Stack<char>(x.ToString().Skip(1));
			}
			else
			{
				stack = new Stack<char>(x.ToString());
			}

			while (true)
			{
				if (stack.Peek() == '0')
				{
					stack.Pop();
				}
				else
				{
					break;
				}
			}

			var sb = new StringBuilder();

			while (stack.Count > 0)
			{
				sb.Append(stack.Pop());
			}

			if (int.TryParse(sb.ToString(), out var result))
			{
				return x < 0 ? -result : result;
			}
			else
			{
				return 0;
			}
		}
	}
}