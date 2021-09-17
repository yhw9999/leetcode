	public class Solution
    {
		public struct Point {
			public int X;
			public int Y;

			public Point(int x, int y) : this()
			{
				X = x;
				Y = y;
			}
		}

		List<char> numbers = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
		int boardSize = 9;
		Stack<Point> blanks = new Stack<Point>();

		public void SolveSudoku(char[][] board)
		{
			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
				{
					if (board[i][j] == '.')
					{
						blanks.Push(new Point(Convert.ToInt32(i), Convert.ToInt32(j)));
					}
				}
			}

			var blankSet = new HashSet<Point>(blanks);
			var beforeSetCount = int.MaxValue;

			var set = new HashSet<char>();

			while (blankSet.Count != beforeSetCount)
			{
				beforeSetCount = blankSet.Count;
				for (int i = 0; i < boardSize; i++)
				{
					for (int j = 0; j < boardSize; j++)
					{
						if (board[i][j] != '.')
						{
							continue;
						}

						set.Clear();

						set.Add('1');
						set.Add('2');
						set.Add('3');
						set.Add('4');
						set.Add('5');
						set.Add('6');
						set.Add('7');
						set.Add('8');
						set.Add('9');

						var rootX = i / 3;
						var rootY = j / 3;

						//3x3
						RemoveExistNumbers(board, set, rootX, rootY);

						//종단
						//횡단
						RemoveCross(board, set, i, j);

						if (set.Count == 1)
						{
							board[i][j] = set.First();
							blankSet.Remove(new Point(i, j));
						}
					}
				}
			}

			blanks = new Stack<Point>(blankSet);

			Find(board);

			//PrintBorad(board);
		}

		private void PrintBorad(char[][] board)
		{
			for (int i = 0; i < boardSize; i++)
			{
				for (int j = 0; j < boardSize; j++)
				{
					Console.Write(board[i][j] + " ");
				}

				Console.WriteLine();
			}

			Console.WriteLine("-------------------------------");
		}

		private bool Find(char[][] board)
		{
			if (blanks.Count == 0)
			{
				return true;
			}

			var blank = blanks.Pop();

			foreach (var number in numbers)
			{
				board[blank.X][blank.Y] = number;

				if (IsCorrect(board, blank.X, blank.Y))
				{
					if (Find(board))
					{
						return true;
					}
				}
			}

			board[blank.X][blank.Y] = '.';
			blanks.Push(blank);

			return false;
		}

		private bool IsCorrect(char[][] board, int x, int y)
		{
			return CheckCross(board, x, y) && CheckRect(board, x, y);
		}

		private void RemoveCross(char[][] board, HashSet<char> set, int x, int y)
		{
			for (int i = 0; i < boardSize; i++)
			{
				if (i != x)
				{
					set.Remove(board[i][y]);
				}

				if (i != y)
				{
					set.Remove(board[x][i]);
				}
			}
		}

		private void RemoveExistNumbers(char[][] board, HashSet<char> set, int rootX, int rootY)
		{
			var startX = rootX * 3;
			var startY = rootY * 3;

			for (int i = startX; i < startX + 3; i++)
			{
				for (int j = startY; j < startY + 3; j++)
				{
					var value = board[i][j];
					set.Remove(value);
				}
			}
		}

		private bool CheckRect(char[][] board, int x, int y)
		{
			var set = new HashSet<char>();

			var startX = x / 3 * 3;
			var startY = y / 3 * 3;

			for (int i = startX; i < startX + 3; i++)
			{
				for (int j = startY; j < startY + 3; j++)
				{
					var value = board[i][j];

					if (value == '.')
					{
						continue;
					}

					if (set.Contains(value))
					{
						return false;
					}
					else
					{
						set.Add(value);
					}
				}
			}

			return true;
		}

		private bool CheckCross(char[][] board, int x, int y)
		{
			// i : x
			// j : y
			for (int k = 0; k < boardSize; k++)
			{
				if (y != k)
				{
					if (board[x][y] == board[x][k])
					{
						return false;
					}
				}

				if (x != k)
				{
					if (board[x][y] == board[k][y])
					{
						return false;
					}
				}
			}

			return true;
		}
	}