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
	public bool IsSubtree(TreeNode root, TreeNode subRoot)
	{
		var result = false;

		FindRoot(root, subRoot, ref result);

		return result;
	}

	private void FindRoot(TreeNode root, TreeNode subRoot, ref bool result)
	{
		if (result)
		{
			return;
		}

		if (root.val == subRoot.val)
		{
			result = true;
			CompareRoot(root, subRoot, ref result);
		}

		if (root.left != null)
		{
			FindRoot(root.left, subRoot, ref result);
		}

		if (root.right != null)
		{
			FindRoot(root.right, subRoot, ref result);
		}
	}

	private void CompareRoot(TreeNode root, TreeNode subRoot, ref bool result)
	{
		if (!result)
		{
			return;
		}

		if (root == null || subRoot == null)
		{
			if (root != subRoot)
			{
				result = false;
			}
		}
		else
		{
			if (root.val == subRoot.val)
			{
				CompareRoot(root.left, subRoot.left, ref result);
				CompareRoot(root.right, subRoot.right, ref result);
			}
			else
			{
				result = false;
			}
		}
	}
}