public class Solution
{
	public int MinAddToMakeValid(string s)
	{
		var stack = new Stack<char>();

		for (int i = 0; i < s.Length; i++)
		{
			if (stack.Count == 0)
			{
				stack.Push(s[i]);
			}
			else
			{
				var peek = stack.Peek();

				if (peek == '(' && s[i] == ')')
				{
					stack.Pop();
				}
				else
				{
					stack.Push(s[i]);
				}
			}
		}

		return stack.Count;
	}
}