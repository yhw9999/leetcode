	public class Solution
	{
		public string LongestCommonPrefix(string[] strs)
		{
			var sb = new StringBuilder();

			var oredered = strs.OrderBy(x=>x.Length);
			var first = oredered.First();
            
            if (first.Length == 0)
			{
				return sb.ToString();
			}
            
			var index = 0;

			while (index < first.Length)
			{
				var value = first[index];
				var isSame = true;
				foreach (var item in strs)
				{
					if (item[index] != value)
					{
						isSame = false;
						break;
					}
				}

				if (!isSame)
				{
					break;
				}

				index++;

				sb.Append(value);
			}

			return sb.ToString();
		}
	}