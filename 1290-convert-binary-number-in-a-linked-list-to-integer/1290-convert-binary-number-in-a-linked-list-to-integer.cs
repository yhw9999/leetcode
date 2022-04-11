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
    public int GetDecimalValue(ListNode head) {
        var result = 0;
        
        while(head != null)
        {
            result <<= 1;
            if(head.val == 1){
                result |= 1;
            }
            
            head = head.next;
        }
        
        return result;
    }
}