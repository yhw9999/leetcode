public class Solution
{
    int minDistance = int.MaxValue;
    bool[][] visited;
    int n;
    public int ShortestPathBinaryMatrix(int[][] grid)
    {
        if (grid[0][0] == 1)
        {
            return -1;
        }

        var queue = new Queue<Tuple<int, int, int>>();

        n = grid.Length;
        visited = new bool[n][];

        for (int i = 0; i < n; i++)
        {
            visited[i] = new bool[n];
        }

        queue.Enqueue(Tuple.Create(0, 0, 1));
        visited[0][0] = true;

        while (queue.Count > 0)
        {
            var step = queue.Dequeue();
            var x = step.Item2;
            var y = step.Item1;
            var distance = step.Item3;

            if (step.Item1 == n - 1 && step.Item2 == n - 1)
            {
                return distance;
            }

            //8방향 체크
            if (x > 0 && y > 0)
            {
                if (!visited[y - 1][x - 1] && grid[y - 1][x - 1] == 0)
                {
                    visited[y - 1][x - 1] = true;
                    queue.Enqueue(Tuple.Create(y - 1, x - 1, distance + 1));
                }
            }

            if (x > 0)
            {
                if (!visited[y][x - 1] && grid[y][x - 1] == 0)
                {
                    visited[y][x - 1] = true;
                    queue.Enqueue(Tuple.Create(y, x - 1, distance + 1));
                }
            }

            if (x > 0 && y < n - 1)
            {
                if (!visited[y + 1][x - 1] && grid[y + 1][x - 1] == 0)
                {
                    visited[y + 1][x - 1] = true;
                    queue.Enqueue(Tuple.Create(y + 1, x - 1, distance + 1));
                }
            }

            if (y > 0)
            {
                if (!visited[y - 1][x] && grid[y - 1][x] == 0)
                {
                    visited[y - 1][x] = true;
                    queue.Enqueue(Tuple.Create(y - 1, x, distance + 1));
                }
            }

            if (y > 0 && x < n - 1)
            {
                if (!visited[y - 1][x + 1] && grid[y - 1][x + 1] == 0)
                {
                    visited[y - 1][x + 1] = true;
                    queue.Enqueue(Tuple.Create(y - 1, x + 1, distance + 1));
                }
            }

            if (x < n - 1)
            {
                if (!visited[y][x + 1] && grid[y][x + 1] == 0)
                {
                    visited[y][x + 1] = true;
                    queue.Enqueue(Tuple.Create(y, x + 1, distance + 1));
                }
            }

            if (x < n - 1 && y < n - 1)
            {
                if (!visited[y + 1][x + 1] && grid[y + 1][x + 1] == 0)
                {
                    visited[y + 1][x + 1] = true;
                    queue.Enqueue(Tuple.Create(y + 1, x + 1, distance + 1));
                }
            }

            if (y < n - 1)
            {
                if (!visited[y + 1][x] && grid[y + 1][x] == 0)
                {
                    visited[y + 1][x] = true;
                    queue.Enqueue(Tuple.Create(y + 1, x, distance + 1));
                }
            }
        }

        return -1;
    }
}