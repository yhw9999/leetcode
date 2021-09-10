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
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
			if (l1 == null)
			{
                return l2;
			}
			else if(l2 == null)
            {
                return l1;
			}
            var l1Cursor = l1;
            var l2Cursor = l2;

            var result = default(ListNode);
            var resultCursor = default(ListNode);

            if (l1Cursor.val > l2Cursor.val)
			{
                result = l2;
                l2Cursor = l2.next;
			}
			else
			{
                result = l1;
                l1Cursor = l1.next;
			}

            resultCursor = result;

            while (l1Cursor != null && l2Cursor != null)
			{
				if (l1Cursor.val > l2Cursor.val)
				{
                    resultCursor.next = l2Cursor;
                    l2Cursor = l2Cursor.next;
				}
				else
				{
                    resultCursor.next = l1Cursor;
                    l1Cursor = l1Cursor.next;
                }

                resultCursor = resultCursor.next;
            }

			if (l1Cursor != null)
			{
                resultCursor.next = l1Cursor;
			}
			else
			{
                resultCursor.next = l2Cursor;
			}

            return result;
        }
}