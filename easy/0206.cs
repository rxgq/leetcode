
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public partial class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode current = head;
        ListNode previous = null;

        while (current is not null) {
            ListNode next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }

        return previous;
    }
}