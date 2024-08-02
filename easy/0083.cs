namespace leetcode.easy;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        ListNode curr = head;

        while (curr != null) {
          while (curr.next != null && curr.next.val == curr.val)
            curr.next = curr.next.next;

          curr = curr.next;
        }

        return head;
    }
}