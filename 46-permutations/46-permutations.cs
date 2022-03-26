public class Solution
{
	bool[] visited;
	List<IList<int>> result = new List<IList<int>>();

	public IList<IList<int>> Permute(int[] nums)
	{
		visited = new bool[nums.Length];

		var stack = new Stack<int>();

		for (int i = 0; i < nums.Length; i++)
		{
			visited[i] = true;
			stack.Push(nums[i]);
			Permute(nums, stack);
			stack.Pop();
			visited[i] = false;
		}

		return result;
	}

	private void Permute(int[] nums, Stack<int> stack)
	{
		if (stack.Count == nums.Length)
		{
			result.Add(new List<int>(stack));
			return;
		}

		for (int i = 0; i < nums.Length; i++)
		{
			if (visited[i])
			{
				continue;
			}

			visited[i] = true;
			stack.Push(nums[i]);
			Permute(nums, stack);
			stack.Pop();
			visited[i] = false;
		}
	}
}