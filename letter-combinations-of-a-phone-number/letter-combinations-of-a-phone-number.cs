	public class Solution
	{
		Dictionary<char, List<string>> keyMap = new Dictionary<char, List<string>>()
		{
			{ '2', new List<string>{ "a","b","c"}},
			{ '3', new List<string>{ "d","e","f"}} ,
			{ '4', new List<string>{ "g","h","i"}} ,
			{ '5', new List<string>{ "j","k","l"}} ,
			{ '6', new List<string>{ "m","n","o"}} ,
			{ '7', new List<string>{ "p","q","r","s"}} ,
			{ '8', new List<string>{ "t","u","v"}} ,
			{ '9', new List<string>{ "w","x","y","z"}}
		}; 								 
		public IList<string> LetterCombinations(string digits)
		{
			var result = new List<string>();

			foreach (var num in digits)
			{
				if (result.Count > 0)
				{
					var newResult = new List<string>();

					foreach (var item in result)
					{
						foreach (var key in keyMap[num])
						{
							newResult.Add(item + key);
						}
					}

					result = newResult;
				}
				else
				{
					result = new List<string>(keyMap[digits[0]]);
				}
			}

			return result;
		}
	}