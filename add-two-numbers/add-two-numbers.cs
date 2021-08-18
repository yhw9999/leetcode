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
	public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
	{
		var result = default(ListNode);
		var root = default(ListNode);
		var isOver = false;

		var op1 = l1;
		var op2 = l2;

		while (op1 != null || op2 != null)
		{
			var val1 = op1 == null ? 0 : op1.val;
			var val2 = op2 == null ? 0 : op2.val;

			var sum = val1 + val2;

			if (isOver)
			{
				sum += 1;
			}

			if (sum >= 10)
			{
				isOver = true;
			}
			else
			{
				isOver = false;
			}

			var resultValue = sum % 10;
			if (result == null)
			{
				result = new ListNode(resultValue);
				root = result;
			}
			else
			{
				var next = new ListNode(resultValue);
				result.next = next;

				result = next;
			}

			op1 = op1?.next;
			op2 = op2?.next;
		}

		if (isOver)
		{
			result.next = new ListNode(1);
		}

		return root;
	}
}