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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        var res = new ListNode();
        var temp = res;
        while(list1 != null && list2 != null)
        {
            if(list1.val <= list2.val)
            {
                res.next = list1;
                list1 = list1.next;
            }
            else if(list2.val < list1.val)
            {
                res.next = list2;
                list2 = list2.next;
            }
            res = res.next;
        }
        if(list1 != null)  res.next = list1;
        else if(list2 != null)  res.next = list2;
        return temp.next;
    }
}