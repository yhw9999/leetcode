public class Solution
{
    int rowSize = 0;
    int columnSize= 0;

    public void GameOfLife(int[][] board)
    {
        rowSize = board.Length;
        columnSize = board[0].Length;

        for (int i = 0; i < rowSize; i++)
        {
            for (int j = 0; j < columnSize; j++)
            {
                var liveCount = GetLiveNeighbors(board, i, j);

                //dead
                if (board[i][j] % 10 == 0)
                {
                    board[i][j] += liveCount == 3 ? 10 : 0;
                }
                else
                {
                    if (liveCount == 2 || liveCount == 3)
                    {
                        board[i][j] += 10;
                    }
                }
            }
        }

        for (int i = 0; i < rowSize; i++)
        {
            for (int j = 0; j < columnSize; j++)
            {
                board[i][j] /= 10;
            }
        }
    }

    private int GetLiveNeighbors(int[][] board, int rowIndex, int columnIndex)
    {
        var result = 0;

        for (int i = rowIndex - 1; i <= rowIndex + 1; i++)
        {
            if (i < 0 || i >= rowSize)
            {
                continue;
            }

            for (int j = columnIndex - 1; j <= columnIndex + 1; j++)
            {
                if (j < 0 || j >= columnSize || (i == rowIndex && j == columnIndex))
                {
                    continue;
                }

                if (board[i][j] % 10 == 1)
                {
                    result++;
                }
            }
        }

        return result;
    }
}