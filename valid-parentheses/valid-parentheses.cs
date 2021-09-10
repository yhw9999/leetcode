public class Solution
{
	public bool IsValid(string s)
	{
		var stack = new Stack<char>();

		foreach (var item in s)
		{
			if (item == '(' || item == '[' || item == '{')
			{
				stack.Push(item);
			}
			else
			{
				if (stack.Count < 1)
				{
					return false;
				}
				else
				{
					var otherBracket = default(char);

					switch (item)
					{
						case ')':
							otherBracket = '(';
							break;
						case ']':
							otherBracket = '[';
							break;
						case '}':
							otherBracket = '{';
							break;
					}

					if (stack.Peek() != otherBracket)
					{
						return false;
					}
					else
					{
						stack.Pop();
					}
				}
			}
		}

        if(stack.Count > 0)
        {
            return false;
        }
		return true;
	}
}