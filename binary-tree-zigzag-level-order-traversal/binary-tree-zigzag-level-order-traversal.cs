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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();

        if (root == null)
        {
            return result;
        }

        var nextNodes = new Queue<TreeNode>();

        nextNodes.Enqueue(root);

        var fromLeft = true;

        while (nextNodes.Count > 0)
        {
            if (fromLeft)
            {
                ToRight(nextNodes, result);
            }
            else
            {
                ToLeft(nextNodes, result);
            }

            fromLeft = !fromLeft;
        }

        return result;
    }

    private void ToLeft(Queue<TreeNode> nextNodes, List<IList<int>> result)
    {
        var nodeCount = nextNodes.Count;

        var currentResult = new List<int>();

        var stack = new Stack<TreeNode>();

        for (int i = 0; i < nodeCount; i++)
        {
            var item = nextNodes.Dequeue();

            currentResult.Add(item.val);

            if (item.right != null)
            {
                stack.Push(item.right);
            }

            if (item.left != null)
            {
                stack.Push(item.left);
            }
        }

        while (stack.Count > 0)
        {
            nextNodes.Enqueue(stack.Pop());
        }

        result.Add(currentResult);
    }

    private void ToRight(Queue<TreeNode> nextNodes, List<IList<int>> result)
    {
        var nodeCount = nextNodes.Count;

        var currentResult = new List<int>();

        var stack = new Stack<TreeNode>();

        for (int i = 0; i < nodeCount; i++)
        {
            var item = nextNodes.Dequeue();

            currentResult.Add(item.val);

            if (item.left != null)
            {
                stack.Push(item.left);
            }

            if (item.right != null)
            {
                stack.Push(item.right);
            }
        }

        while (stack.Count > 0)
        {
            nextNodes.Enqueue(stack.Pop());
        }

        result.Add(currentResult);
    }
}