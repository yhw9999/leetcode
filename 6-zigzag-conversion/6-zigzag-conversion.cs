public class Solution
{
	public string Convert(string s, int numRows)
	{
		if (numRows == 1)
		{
			return s;
		}

		var result = new StringBuilder(s.Length);

		var rows = new List<StringBuilder>();

		for (int i = 0; i < numRows; i++)
		{
			rows.Add(new StringBuilder());
		}

		var cycleSize = numRows * 2 - 2;

		for (int i = 0; i < s.Length; i++)
		{
			var remain = i % cycleSize;

			if (remain < numRows)
			{
				rows[remain].Append(s[i]);
			}
			else
			{
				var startIndex = remain - numRows;
				rows[numRows - startIndex - 2].Append(s[i]);
			}
		}

		rows.ForEach(x => result.Append(x));

		return result.ToString();
	}
}