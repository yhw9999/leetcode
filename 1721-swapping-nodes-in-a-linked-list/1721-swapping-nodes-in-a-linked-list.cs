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
	public ListNode SwapNodes(ListNode head, int k)
	{
		var frontHead = head;
		var windowHead = head;
		var windowTail = head;

		while (--k > 0)
		{
			frontHead = frontHead.next;
		}

		windowTail = frontHead;

		while (windowTail.next != null)
		{
			windowHead = windowHead.next;
			windowTail = windowTail.next;
		}

		var tmpValue = frontHead.val;
		frontHead.val = windowHead.val;
		windowHead.val = tmpValue;

		return head;
	}
}