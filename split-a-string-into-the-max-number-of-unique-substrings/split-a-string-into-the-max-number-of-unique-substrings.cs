public class Solution
{
	public int MaxUniqueSplit(string s)
	{
		var set = new HashSet<string>();
		var stack = new Stack<string>();

		var maximum = 0;

		Split(s, 0, set, stack, ref maximum);

		return maximum;
	}

	private void Split(string s, int currentIndex, HashSet<string> set, Stack<string> stack, ref int maximum)
	{
		if (currentIndex == s.Length)
		{
			if (set.Count > maximum)
			{
				maximum = set.Count;
			}

			return;
		}

		for (int i = 1; i <= s.Length - currentIndex; i++)
		{
			var subString = s.Substring(currentIndex, i);

			if (set.Contains(subString))
			{
				continue;
			}
			else
			{
				set.Add(subString);
				stack.Push(subString);

				Split(s, currentIndex + i, set, stack, ref maximum);

				set.Remove(stack.Pop());
			}
		}
	}
}