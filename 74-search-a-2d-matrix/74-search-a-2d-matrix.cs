public class Solution
{
	public bool SearchMatrix(int[][] matrix, int target)
	{
		var m = matrix.Length;
		var n = matrix[0].Length;

		for (int i = 0; i < m; i++)
		{
			if (matrix[i].Last() >= target)
			{
				var index = Array.BinarySearch(matrix[i], target);

				if (index > -1)
				{
					return true;
				}
			}
		}

		return false;
	}
}