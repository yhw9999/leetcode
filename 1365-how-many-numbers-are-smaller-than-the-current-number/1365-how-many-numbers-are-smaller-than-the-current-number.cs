public class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        var result = new int[nums.Length];

        var appearCount = new Dictionary<int, int>();

        foreach (var item in nums)
        {
            if (!appearCount.TryGetValue(item, out _))
            {
                appearCount.Add(item, 0);
            }

            appearCount[item]++;
        }

        var ordered = appearCount.OrderBy(x => x.Key);

        var frontAmout = 0;

        foreach (var item in ordered)
        {
            appearCount[item.Key] = frontAmout;
            frontAmout += item.Value;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = appearCount[nums[i]];
        }

        return result;
    }
}