public class Solution
{
    public int SubtractProductAndSum(int n)
    {
        var sum = 0;
        var multiple = 1;

        while (n > 0)
        {
            var value = n % 10;
            sum += value;
            multiple *= value;
            n /= 10;
        }

        return multiple - sum;
    }
}