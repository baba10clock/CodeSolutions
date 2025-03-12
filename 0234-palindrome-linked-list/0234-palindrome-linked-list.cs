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
    public bool IsPalindrome(ListNode head) {
        var stk = new Stack<int>();
        ListNode fast = head;
        ListNode slow = head;
        while(fast != null && fast.next != null)
        {
            stk.Push(slow.val);
            
            slow = slow.next;
            fast = fast.next.next;
        }
        if (fast != null) {
            slow = slow.next;
        }
        while(slow != null)
        {
            
            if(slow.val != stk.Pop())
                return false;
            slow = slow.next;
            
        }
        return true;

    }
}