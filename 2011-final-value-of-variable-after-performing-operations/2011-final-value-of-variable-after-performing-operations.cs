public class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        var result = 0;

        foreach (var operation in operations)
        {
            if (operation.First() == '+' || operation.Last() == '+')
            {
                result++;
            }
            else
            {
                result--;
            }
        }

        return result;
    }
}