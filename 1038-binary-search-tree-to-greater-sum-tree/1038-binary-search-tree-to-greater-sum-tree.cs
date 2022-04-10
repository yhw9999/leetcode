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
    int sum = 0;

    public TreeNode BstToGst(TreeNode root)
    {
        Gst(root);

        return root;
    }

    private void Gst(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        Gst(node.right);
        node.val += sum;
        sum = node.val;
        Gst(node.left);
    }
}