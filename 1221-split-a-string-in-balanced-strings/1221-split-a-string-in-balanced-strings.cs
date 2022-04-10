public class Solution
{
    public int BalancedStringSplit(string s)
    {
        var result = 0;
        var lCount = 0;
        var rCount = 0;

        foreach (var item in s)
        {
            switch (item)
            {
                case 'L':
                    lCount++;
                    break;
                case 'R':
                    rCount++;
                    break;
            }

            if (lCount == rCount)
            {
                result++;
            }
        }

        return result;
    }
}