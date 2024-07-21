namespace leetcode.easy;

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public partial class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        ListNode s = head;
        ListNode f = head;

        while (f != null && f.next != null)
        {
            s = s.next;
            f = f.next.next;
        }

        return s;
    }
}
