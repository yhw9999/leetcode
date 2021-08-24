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
public class Solution {
		public ListNode RemoveNthFromEnd(ListNode head, int n)
		{
			var dict = new Dictionary<int, ListNode>();
			var index = 0;
			var startNode = head;

			while (startNode != null)
			{
				dict.Add(index++, startNode);
				startNode = startNode.next;
			}

			var length = index;

			var frontIndex = length - n - 1;

			if (frontIndex < 0)
			{
				head = head.next;
			}
			else
			{
				var frontNode = dict[frontIndex];

				frontNode.next = frontNode.next.next;
			}

			return head;
		}
}