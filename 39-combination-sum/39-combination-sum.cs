public class Solution
{
	List<IList<int>> result = new List<IList<int>>();

	public IList<IList<int>> CombinationSum(int[] candidates, int target)
	{
		for (int i = 0; i < candidates.Length; i++)
		{
			Combinatioin(candidates, new List<int>() { candidates[i] }, i, candidates[i], target);
		}

		return result;
	}

	private void Combinatioin(int[] candidates, List<int> elements, int index, int sum, int target)
	{
		if (sum > target)
		{
			return;
		}
		else if(sum == target)
		{
			result.Add(elements);
			return;
		}
		else
		{
			for (int i = index; i < candidates.Length; i++)
			{
				var newElements = new List<int>(elements);
				newElements.Add(candidates[i]);
				Combinatioin(candidates, newElements, i, sum + candidates[i], target);
			}
		}
	}
}