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
    public ListNode ReverseList(ListNode head) {
        var curr = head;
        ListNode prev = null;
        while(curr != null)
        {
            var temp = prev;
            prev = curr;
            curr = curr.next;
            prev.next = temp;
            
        }
        return prev;
    }
}