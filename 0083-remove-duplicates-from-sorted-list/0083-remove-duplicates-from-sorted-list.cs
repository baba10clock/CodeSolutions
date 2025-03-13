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
    public ListNode DeleteDuplicates(ListNode head) {
        var set = new HashSet<int>();
        ListNode dummy = new ListNode(0, head);
        ListNode prev = dummy;
        while(head != null)
        {
            ListNode next = head.next;
            if(set.Contains(head.val))
            {
                prev.next = next;
            }
            else
            {
                set.Add(head.val);
                prev = head;
            }
            head = next;
        }
        return dummy.next;
    }
}