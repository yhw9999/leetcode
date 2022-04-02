public class Solution
{
	public bool ValidPalindrome(string s)
	{
		return Solve(s, 0, s.Length - 1, 0);
	}

	private bool Solve(string s, int front, int back, int adjustCount)
	{
		while (front < back)
		{
			if (s[front] != s[back])
			{
				if (adjustCount > 0)
				{
					return false;
				}

				return Solve(s, front + 1, back, adjustCount + 1) || Solve(s, front, back - 1, adjustCount + 1);
			}

			front++;
			back--;
		}

		return true;
	}
}