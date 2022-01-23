public class Solution {
	public int ThirdMax(int[] nums)
	{
		var sortedSet = new SortedSet<int>(nums).ToArray();

		if (sortedSet.Length < 3)
		{
			return sortedSet.Last();
		}
		else
		{
			return sortedSet[sortedSet.Length - 3];
		}
	}
}