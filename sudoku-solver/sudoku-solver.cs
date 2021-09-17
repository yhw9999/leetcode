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

			Find(board);
			//Print Board

			PrintBorad(board);
		}

		private void PrintBorad(char[][] board)
		{
			for (int i = 0; i < 9; i++)
			{
				for (int j = 0; j < 9; j++)
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

				//PrintBorad(board);

				//Find(board);

				if (IsCorrect(board))
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

		private bool IsCorrect(char[][] board)
		{
			return CheckCross(board) && CheckRect(board);
		}

		private bool CheckRect(char[][] board)
		{
			var set = new HashSet<char>();

			for (int i = 0; i < boardSize; i += 3)
			{
				for (int j = 0; j < boardSize; j += 3)
				{
					set.Clear();

					var startX = i / 3 * 3;
					var startY = j / 3 * 3;

					for (int x = startX; x < startX + 3; x++)
					{
						for (int y = startY; y < startY + 3; y++)
						{
							var value = board[x][y];

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
				}
			}

			return true;
		}

		private bool CheckCross(char[][] board)
		{
			// i : x
			// j : y
			for (int i = 0; i < boardSize; i++)
			{
				for (int j = 0; j < boardSize; j++)
				{
					var current = board[i][j];

					if (current == '.')
					{
						continue;
					}

					//가로 체크
					for (int k = 0; k < boardSize; k++)
					{
						if (j == k)
						{
							continue;
						}

						if (current == board[i][k])
						{
							return false;
						}
					}

					//세로 체크
					for (int k = 0; k < boardSize; k++)
					{
						if (i == k)
						{
							continue;
						}

						if (current == board[k][j])
						{
							return false;
						}
					}
				}
			}

			return true;
		}
	}