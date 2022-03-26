public class Solution
{
	Dictionary<string, int> symbolSheet = new Dictionary<string, int>()
	{
		{"I", 1},
		{"IV", 4},
		{"V", 5},
		{"IX", 9},
		{"X", 10},
		{"XL", 40},
		{"L", 50},
		{"XC", 90},
		{"C", 100},
		{"CD", 400},
		{"D", 500},
		{"CM", 900},
		{"M", 1000 }
	};

	public int RomanToInt(string s)
	{
		var result = 0;

		for (int i = 0; i < s.Length; i++)
		{
			var key = GetSymbol(s, ref i);

			result += symbolSheet[key];
		}

		return result;
	}

	private string GetSymbol(string s, ref int index)
	{
		if (index == s.Length - 1)
		{
			return s.Substring(index, 1);
		}

		var key = s.Substring(index, 2);

		if (!symbolSheet.TryGetValue(key, out var value))
		{
			key = s.Substring(index, 1);
		}
		else
		{
			index += 1;
		}

		return key;
	}
}