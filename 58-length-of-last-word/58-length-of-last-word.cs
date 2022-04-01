public class Solution
{
	public int LengthOfLastWord(string s)
	{
		var result = 0;
		for (int i = s.Length - 1; i >= 0; i--)
		{
			if (s[i] != ' ')
			{
				result++;
			}
			else
			{
				if (result == 0)
				{
					continue;
				}
				else
				{
					return result;
				}
			}
		}

		return result;
	}
}