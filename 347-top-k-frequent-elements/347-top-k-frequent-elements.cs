public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (!dict.TryGetValue(nums[i], out var value))
            {
                dict.Add(nums[i], 0);
            }

            dict[nums[i]]++;
        }

        return dict.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
    }
}