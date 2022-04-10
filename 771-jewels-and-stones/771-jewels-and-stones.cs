public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        var set = new HashSet<char>(jewels);

        return stones.Count(stone => set.Contains(stone));
    }
}