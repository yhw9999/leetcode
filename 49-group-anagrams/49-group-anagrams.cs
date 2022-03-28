public class Solution
{
	public IList<IList<string>> GroupAnagrams(string[] strs)
	{
		var dict = new Dictionary<string, IList<string>>();

		foreach (var item in strs)
		{
			var arr = item.ToCharArray();
			Array.Sort(arr);
			var key = new string(arr);
			if (!dict.TryGetValue(key, out var list))
			{
				dict.Add(key, new List<string>());
			}

			dict[key].Add(item);
		}

		return dict.Values.OrderBy(x => x.Count).ToList();
	}
}