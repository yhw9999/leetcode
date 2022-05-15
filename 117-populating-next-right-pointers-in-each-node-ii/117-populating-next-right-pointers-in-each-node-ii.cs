/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/
public class Solution
{
    public Node Connect(Node root)
    {
        if(root is null)
        {
            return root;
        }
        
        var result = root;
        var queue = new Queue<Node>();
        queue.Enqueue(root);

        Add(queue);

        return result;
    }

    private void Add(Queue<Node> queue)
    {
        var count = queue.Count;

        if (count == 0)
        {
            return;
        }

        var frontNode = default(Node);

        while (count-- > 0)
        {
            var node = queue.Dequeue();

            if (frontNode is not null)
            {
                frontNode.next = node;
            }

            frontNode = node;

            if (node.left is not null)
            {
                queue.Enqueue(node.left);
            }

            if (node.right is not null)
            {
                queue.Enqueue(node.right);
            }
        }
        
        frontNode.next = null;

        Add(queue);
    }
}