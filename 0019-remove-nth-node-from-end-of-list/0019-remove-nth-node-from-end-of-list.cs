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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        if(head.next == null) return null;
        var len = 0;
        var temp = head;
        while(temp != null)
        {
            len++;
            temp = temp.next;
        }

        var res = new ListNode();
        res.next = head;
        var times = len - n - 1;
        while(times > 0 && head != null)
        {
            times--;
            head = head.next;
        }

        if(len == n)
            return head.next;

        if(head.next != null)
            head.next = head.next.next;
        
        return res.next;
    }
}