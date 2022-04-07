public class Solution
{
	public int LastStoneWeight(int[] stones)
	{
		var stoneList = new List<int>(stones);

		while (stoneList.Count > 1)
		{
			stoneList.Sort();

			var op1 = stoneList[stoneList.Count - 1];
			var op2 = stoneList[stoneList.Count - 2];

			if (op1 == op2)
			{
				stoneList.RemoveAt(stoneList.Count - 1);
				stoneList.RemoveAt(stoneList.Count - 1);
			}
			else if(op1 > op2)
			{
				stoneList.RemoveAt(stoneList.Count - 1);
				stoneList[stoneList.Count - 1] = op1 - op2;
			}
			else
			{
				stoneList.RemoveAt(stoneList.Count - 1);
				stoneList[stoneList.Count] = op2 - op1;
			}
		}

		return stoneList.FirstOrDefault();
	}
}