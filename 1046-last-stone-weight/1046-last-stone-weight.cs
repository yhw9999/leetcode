public class Solution
{
	public int LastStoneWeight(int[] stones)
	{
		var stoneList = new List<int>(stones);

		while (stoneList.Count > 1)
		{
			stoneList.Sort();
			var lastIndex = stoneList.Count - 1;

			var op1 = stoneList[lastIndex];
			var op2 = stoneList[lastIndex - 1];

			stoneList.RemoveAt(lastIndex);

			if (op1 == op2)
			{
				stoneList.RemoveAt(lastIndex - 1);
			}
			else if(op1 > op2)
			{
				stoneList[lastIndex - 1] = op1 - op2;
			}
			else
			{
				stoneList[lastIndex - 1] = op2 - op1;
			}
		}

		return stoneList.FirstOrDefault();
	}
}