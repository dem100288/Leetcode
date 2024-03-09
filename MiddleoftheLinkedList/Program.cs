// See https://aka.ms/new-console-template for more information

Console.WriteLine(1);

Console.ReadKey();

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MiddleNode(ListNode head)
    {
        if (head.next is null) return head;
        ListNode fast = head;
        ListNode slow = fast;
        while (fast?.next is not null)
        {
            slow = slow.next;
            fast = fast.next?.next;
        }
        return slow;
    }
}