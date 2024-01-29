ListNode n1 = new ListNode(1);
ListNode n2 = new ListNode(2);
ListNode n3 = new ListNode(3); 
ListNode n4 = new ListNode(4);
ListNode n5 = new ListNode(5);
n1.next = n2;
n2.next = n3;
n3.next = n4;
n4.next = n5;

Console.WriteLine(new Solution().ReverseList(n1));


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
    public ListNode ReverseList(ListNode head)
    {
        if (head?.next is null) return head;
        ListNode? current = head;
        ListNode? next = head.next;
        ListNode? prev = null;
        while (next is not null)
        {
            current.next = prev;
            prev = current;
            current = next;
            next = current?.next;
        }
        current.next = prev;
        return current;
    }
}
