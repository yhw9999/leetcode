/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
	public int DeepestLeavesSum(TreeNode root)
	{
		var deepestIndex = 0;

		SetDeepestIndex(root, ref deepestIndex, 0);

		var sum = 0;

		SumDeepestValues(root, ref sum, 0, deepestIndex);

		return sum;
	}

	private void SumDeepestValues(TreeNode node, ref int sum, int currentIndex, int deepestIndex)
	{
		if (node == null)
		{
			return;
		}

		if (currentIndex == deepestIndex)
		{
			sum += node.val;

			return;
		}

		if (currentIndex < deepestIndex)
		{
			SumDeepestValues(node.left, ref sum, currentIndex + 1, deepestIndex);
			SumDeepestValues(node.right, ref sum, currentIndex + 1, deepestIndex);
		}

		return;
	}

	private void SetDeepestIndex(TreeNode node, ref int deepestIndex, int currentIndex)
	{
		if (deepestIndex < currentIndex)
		{
			deepestIndex = currentIndex;
		}

		if (node.left != null)
		{
			SetDeepestIndex(node.left, ref deepestIndex, currentIndex + 1);
		}

		if (node.right != null)
		{
			SetDeepestIndex(node.right, ref deepestIndex, currentIndex + 1);
		}
	}
}