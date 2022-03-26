public class Solution
{
	public void Rotate(int[][] matrix)
	{
		var n = matrix.GetLength(0);
		var size = n - 1;
		var depthSize = n / 2;

		for (int depth = 0; depth < depthSize; depth++)
		{
			var endAmount = size - (depth * 2);
			for (int i = 0; i < endAmount; i++)
			{
				var tmpValue = matrix[depth][depth + i];

				matrix[depth][depth + i] = matrix[size - depth - i][depth];
				matrix[size - depth - i][depth] = matrix[size - depth][size - depth - i];
				matrix[size - depth][size - depth - i] = matrix[depth + i][size - depth];
				matrix[depth + i][size - depth] = tmpValue;
			}
		}
	}
}