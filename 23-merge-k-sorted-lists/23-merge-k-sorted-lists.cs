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
	public ListNode MergeKLists(ListNode[] lists)
	{
		if (lists.Length < 1)
		{
			return null;
		}

		var notNullIndex = 0;

		foreach (var node in lists)
		{
			if (node == null)
			{
				notNullIndex++;
			}
			else
			{
				break;
			}
		}

		if (notNullIndex >= lists.Length)
		{
			return lists[0];
		}

		var result = lists[notNullIndex];

		for (int i = notNullIndex + 1; i < lists.Length; i++)
		{
			if (lists[i] != null)
			{
				if (result.val > lists[i].val)
				{
					result = Merge(lists[i], result);
				}
				else
				{
					result = Merge(result, lists[i]);
				}
			}
		}

		return result;
	}

	private ListNode Merge(ListNode op1, ListNode op2)
	{
		var currentOp1 = op1;
		var currentOp2 = op2;

		while (currentOp2 != null)
		{
			if (currentOp1.next == null)
			{
				currentOp1.next = currentOp2;
				break;
			}
			else
			{
				if (currentOp1.next.val >= currentOp2.val)
				{
					var tmpNextOp2 = currentOp2.next;
					Interleave(currentOp1, currentOp2);
					currentOp1 = currentOp2;
					currentOp2 = tmpNextOp2;
				}
				else
				{
					currentOp1 = currentOp1.next;
				}
			}
		}

		return op1;
	}

	private void Interleave(ListNode op1, ListNode op2)
	{
		var tmp = op1.next;
		op1.next = op2;
		op2.next = tmp;
	}
}