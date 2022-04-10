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
    public TreeNode BstToGst(TreeNode root)
    {
        Gst(root, 0);

        return root;
    }

    private int Gst(TreeNode node, int val)
    {
        if (node == null)
        {
            return val;
        }

        node.val += Gst(node.right, val);
        return Gst(node.left, node.val);
    }
}