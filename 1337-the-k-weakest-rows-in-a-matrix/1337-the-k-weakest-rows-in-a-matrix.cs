public class Solution
{
	public int[] KWeakestRows(int[][] mat, int k)
	{
		var result = new List<Tuple<int, int>>();

		for (int i = 0; i < mat.GetLength(0); i++)
		{
			result.Add(Tuple.Create(mat[i].Count(x => x == 1), i));
		}

		return result.OrderBy(x => x.Item1).Select(x => x.Item2).Take(k).ToArray();
	}
}