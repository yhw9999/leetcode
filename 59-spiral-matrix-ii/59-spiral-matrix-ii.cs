public class Solution
{
    public int[][] GenerateMatrix(int n)
    {
        var result = new int[n][];
        for (int i = 0; i < n; i++)
        {
            result[i] = new int[n];
        }

        var row = 0;
        var col = 0;
        var direction = Direction.Right;
        var directionCount = n;
        var directionChangedCount = 1;
        var directionChanged = false;

        for (int i = 1; i <= Math.Pow(n, 2); i++)
        {
            result[row][col] = i;

            if (--directionCount == 0)
            {
                direction = (Direction)(((int)direction + 1) % 4);
                directionCount = n - directionChangedCount;

                if (directionChanged)
                {
                    directionChanged = false;
                    directionChangedCount++;
                }
                else
                {
                    directionChanged = true;
                }
            }

            switch (direction)
            {
                case Direction.Right:
                    col++;
                    break;
                case Direction.Down:
                    row++;
                    break;
                case Direction.Left:
                    col--;
                    break;
                case Direction.Up:
                    row--;
                    break;
            }

            
        }

        return result;
    }
}

enum Direction
{
    Right = 0,
    Down = 1,
    Left = 2,
    Up = 3
}