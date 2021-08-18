public class Solution
{
	public string LongestPalindrome(string s)
	{

		var result = string.Empty;

		for (int i = 0; i < s.Length; i++)
		{
			for (int j = i; j < s.Length; j++)
			{
				if (j - i < result.Count())
				{
					j += result.Length - 1;
					continue;
				}
				if (IsPalindrromic(i, j, s))
				{
					if (result.Length - 1 < j - i)
					{
						string str = GetString(i, j, s);

						result = str;
					}
				}
			}
		}

		return result;
	}
	private string GetString(int i, int j, string s)
	{
		var sb = new StringBuilder();

		for (int index = i; index <= j; index++)
		{
			sb.Append(s[index]);
		}

		return sb.ToString();
	}

	private bool IsPalindrromic(int i, int j, string s)
	{
		if (i == j)
		{
			return true;
		}

		var step = 0;

		var front = i + step;
		var back = j - step;

		while (front <= back)
		{
			front = i + step;
			back = j - step;

			if (s[front] != s[back])
			{
				return false;
			}

			step++;
		}

		return true;
	}
}