public class Solution
{
	public IList<string> GenerateParenthesis(int n)
	{
		var result = new List<string>();

		var openCount = n;
		var closeCount = n;

		Generate(string.Empty, openCount, closeCount, result);

		return result;
	}

	private void Generate(string text, int openCount, int closeCount, List<string> result)
	{
		if (openCount == 0 && closeCount == 0)
		{
			result.Add(text);
			return;
		}

		if (openCount > 0)
		{
			Generate(text + "(", openCount - 1, closeCount, result);
		}

		if (openCount < closeCount)
		{
			Generate(text + ")", openCount, closeCount - 1, result);
		}
	}
}