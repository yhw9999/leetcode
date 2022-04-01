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
	public ListNode DeleteDuplicates(ListNode head)
	{
		if (head == null)
		{
			return head;
		}

		var result = head;

		while (true)
		{
			if (head.next != null)
			{
				if (head.val == head.next.val)
				{
					head.next = head.next.next;
				}
				else
				{
					head = head.next;
				}
			}
			else
			{
				break;
			}
		}

		return result;
	}
}