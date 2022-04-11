public class Solution
{
    public IList<IList<int>> ShiftGrid(int[][] grid, int k)
    {
        var rowSize = grid.Length;
        var columnSize = grid[0].Length;

        while (k-- > 0)
        {
            var beforeValue = grid[rowSize - 1][columnSize - 1];

            for (int i = 0; i < rowSize; i++)
            {
                for (int j = 0; j < columnSize; j++)
                {
                    var tmp = grid[i][j];
                    grid[i][j] = beforeValue;
                    beforeValue = tmp;
                }
            }
        }

        return grid;
    }
}