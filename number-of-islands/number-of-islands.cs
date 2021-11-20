	public class Solution
	{
		int n, m;

		public int NumIslands(char[][] grid)
		{
			n = grid.GetLength(0);
			m = grid[0].Length;

			var lands = new int[n][];

			for (int i = 0; i < n; i++)
			{
				lands[i] = new int[m];
			}

			var landId = 0;

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					if (grid[i][j] == '0' || lands[i][j] != 0)
					{
						continue;
					}

					Mark(i, j, grid, lands, ++landId);
				}
			}

			return landId;
		}

		private void Mark(int i, int j, char[][] grid, int[][] lands, int landId)
		{
			if (grid[i][j] == '0' || lands[i][j] != 0)
			{
				return;
			}

			lands[i][j] = landId;

			var left = j - 1;
			var right = j + 1;
			var top = i - 1;
			var bottom = i + 1;

			if (left > -1)
			{
				Mark(i, left, grid, lands, landId);
			}

			if(right < m)
			{
				Mark(i, right, grid, lands, landId);
			}

			if (top > -1)
			{
				Mark(top, j, grid, lands, landId);
			}

			if(bottom < n)
			{
				Mark(bottom, j, grid, lands, landId);
			}
		}
	}