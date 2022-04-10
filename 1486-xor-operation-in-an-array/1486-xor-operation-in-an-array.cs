public class Solution
{
    public int XorOperation(int n, int start)
    {
        var result = start;

        for (int i = 1; i < n; i++)
        {
            start += 2;
            result ^= start;
        }

        return result;
    }
}