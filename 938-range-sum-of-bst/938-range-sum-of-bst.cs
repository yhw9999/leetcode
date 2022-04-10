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
    private int lowValue;
    private int highValue;

    public int RangeSumBST(TreeNode root, int low, int high)
    {
        lowValue = low;
        highValue = high;

        var result = 0;

        Sum(root, ref result);

        return result;
    }

    private void Sum(TreeNode node, ref int result)
    {
        if (node == null) return;
        
        if (node.val >= lowValue && node.val <= highValue)
        {
            result += node.val;
        }
        
        Sum(node.left, ref result);
        Sum(node.right, ref result);
    }
}