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
	public TreeNode RecoverFromPreorder(string traversal)
	{
		var stack = new Stack<TreeNode>();
		var depth = 0;

		for (int i = 0; i < traversal.Length; i++)
		{
			var item = traversal[i];
			
			//Depth일 경우
			if (item == '-')
			{
				depth++;
			}
			//숫자일 경우
			else
			{
				var numberLength = GetNumberLength(traversal, i);
				var value = int.Parse(traversal.Substring(i, numberLength));
				i += numberLength - 1;
				var newNode = new TreeNode(value);

				if (stack.Count != 0)
				{
					while (stack.Count > depth)
					{
						stack.Pop();
					}

					var parent = stack.Peek();

					if (parent.left == null)
					{
						parent.left = newNode;
					}
					else
					{
						parent.right = newNode;
					}
				}

				stack.Push(newNode);

				depth = 0;
			}
		}

		return stack.Last();
	}

	private int GetNumberLength(string traversal, int startIndex)
	{
		var numberLength = 0;

		for (int i = startIndex; i < traversal.Length; i++)
		{
			if (traversal[i] != '-')
			{
				numberLength++;
			}
			else
			{
				break;
			}
		}

		return numberLength;
	}
}