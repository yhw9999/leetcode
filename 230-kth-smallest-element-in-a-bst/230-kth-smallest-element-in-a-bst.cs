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
    int counter = 0;
    TreeNode result;

    public int KthSmallest(TreeNode root, int k)
    {
        Tour(root, k);

        return result.val;
    }

    private void Tour(TreeNode node, int k)
    {
        if (counter == k)
        {
            return;
        }

        if (node.left != null)
        {
            Tour(node.left, k);
        }

        counter++;

        if (counter == k)
        {
            result = node;
        }

        if (node.right != null)
        {
            Tour(node.right, k);
        }

    }
}