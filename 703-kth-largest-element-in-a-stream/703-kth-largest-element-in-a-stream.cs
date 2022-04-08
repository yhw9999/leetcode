public class KthLargest
{
	List<int> list;
	int Kth;
	public KthLargest(int k, int[] nums)
	{
		list = new List<int>(k);
		Kth = k;
		Array.Sort(nums);

		var addAmount = Math.Min(nums.Length, k);

		var stack = new Stack<int>();

		var index = 0;

		while (k-- > 0 && index < nums.Length)
		{
			stack.Push(nums[nums.Length - index++ - 1]);
		}

		while (stack.Count > 0)
		{
			list.Add(stack.Pop());
		}
	}

	public int Add(int val)
	{
		if (list.Count < Kth)
		{
			list.Add(val);
		}
		else if (list.First() < val)
		{
			list.RemoveAt(0);
			list.Add(val);
		}

		list.Sort();

		return list.First();
	}
}