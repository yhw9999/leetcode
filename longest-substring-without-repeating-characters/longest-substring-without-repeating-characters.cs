public class Solution
{
	public int LengthOfLongestSubstring(string s)
	{
		var set = new HashSet<char>();
		var ss = new StringBuilder();
		var result = 0;

		foreach (var item in s)
		{
			if (set.Contains(item))
			{
				var index = 0;
				for (int i = 0; i < ss.Length; i++)
				{
					if (ss[i] == item)
					{
						index = i;
						break;
					}
				}

				for (int i = 0; i <= index; i++)
				{
					set.Remove(ss[0]);
					ss.Remove(0, 1);
				}


			}

			ss.Append(item);
			set.Add(item);

			if (result < ss.Length)
			{
				result = ss.Length;
			}
		}
		return result;
	}
}