//Linked List Cycle
ListNode l1 = new ListNode(1);
ListNode l2 = new ListNode(2);
ListNode l3 = new ListNode(3); 
ListNode l4 = new ListNode(4);
ListNode l5 = new ListNode(5);
ListNode l6 = new ListNode(6);
ListNode l7 = new ListNode(7);
l5.next = l6;
l6.next = l5;

l1.next = l2;
l2.next = l3;
l3.next = l4;
l4.next = l2;

Console.WriteLine(new Solution().HasCycle(l1));
Console.WriteLine(new Solution().HasCycle(l5));
Console.WriteLine(new Solution().HasCycle(l7));

Console.ReadKey();

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        while (head != null)
        {
            if (head.val == int.MaxValue) return true;
            head.val = int.MaxValue;
            head = head.next;
        }
        return false;
    }
}