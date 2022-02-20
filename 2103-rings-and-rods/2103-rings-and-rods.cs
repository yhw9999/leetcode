public class Solution
{
	public int CountPoints(string rings)
	{
		var rods = new Dictionary<int, HashSet<char>>();

		for (int i = 0; i < 10; i++)
		{
			rods.Add(i, new HashSet<char>() { 'R', 'G', 'B'});
		}

		for (int i = 0; i < rings.Length / 2; i++)
		{
			var color = rings[i * 2];
			var rodIndex = Convert.ToInt32(rings[i * 2 + 1]) - 48;

			if (rods.TryGetValue(rodIndex, out var rod))
			{
				rod.Remove(color);

				if (rod.Count == 0)
				{
					rods.Remove(rodIndex);
				}
			}
		}

		return 10 - rods.Count;
	}
}