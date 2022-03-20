/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
	public ListNode SwapPairs(ListNode head)
	{
		var stack = new Stack<ListNode>();

		var current = head;
		var size = 0;

		while (current != null)
		{
			stack.Push(current);
			current = current.next;
			size++;
		}

		var lastNode = head;

		while (stack.Count > 1)
		{
			if (stack.Count % 2 == 0)//2 4 6
			{
				var back = stack.Pop();
				var front = stack.Pop();

				var tmpBackNext = back.next;
				front.next = tmpBackNext;
				back.next = front;

				lastNode = back;

				if (stack.TryPeek(out var peek))
				{
					peek.next = back;
				}
			}
			else//3 5
			{
				var tail = stack.Pop();
			}
		}

		return lastNode;
	}
}