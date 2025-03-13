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
    public ListNode RemoveElements(ListNode head, int val) {
        
        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode prev = dummy;

        while(head != null)
        {
            ListNode next = head.next;
            if(head.val == val)
                prev.next = next;
            else
                prev = head;
            head = next;
        }

        return dummy.next;
    }
}