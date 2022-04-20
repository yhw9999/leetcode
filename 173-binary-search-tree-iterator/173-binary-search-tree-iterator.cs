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
public class BSTIterator
{
    Queue<TreeNode> queue = new Queue<TreeNode>();

    public BSTIterator(TreeNode root)
    {
        Tour(root);
    }

    private void Tour(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        Tour(node.left);
        queue.Enqueue(node);
        Tour(node.right);
    }

    public int Next()
    {
        return queue.Dequeue().val;
    }

    public bool HasNext()
    {
        return queue.Count > 0;
    }
}


/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */