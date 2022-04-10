public class Solution
{
    public int FindCenter(int[][] edges)
    {
        var set = new HashSet<int>();

        for (int i = 0; i < edges.Length; i++)
        {
            if (set.Contains(edges[i][0]))
            {
                return edges[i][0];
            }
            else if (set.Contains(edges[i][1]))
            {
                return edges[i][1];
            }

            set.Add(edges[i][0]);
            set.Add(edges[i][1]);
        }

        return -1;
    }
}