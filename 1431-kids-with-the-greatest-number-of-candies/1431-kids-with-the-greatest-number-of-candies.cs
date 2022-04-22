public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var result = new List<bool>();
        var max = candies.Max();

        for (int i = 0; i < candies.Length; i++)
        {
            if (max <= candies[i] + extraCandies)
            {
                result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }

        return result;
    }
}