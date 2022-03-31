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
	List<int> result = new List<int>();

	public IList<int> InorderTraversal(TreeNode root)
	{
        if(root == null){
            return result;    
        }
        
		Visit(root);

		return result;
	}

	private void Visit(TreeNode node)
	{        
		if (node.left != null)
		{
			Visit(node.left);
		}
        
   		result.Add(node.val);
        
		if (node.right != null)
		{
			Visit(node.right);
		}
	}
}