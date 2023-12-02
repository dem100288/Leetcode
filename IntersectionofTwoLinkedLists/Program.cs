//Intersection of Two Linked Lists

ListNode a1 = new ListNode(4);
ListNode a2 = new ListNode(1);
ListNode b1 = new ListNode(5);
ListNode b2 = new ListNode(6);
ListNode b3 = new ListNode(1);
ListNode c1 = new ListNode(8);
ListNode c2 = new ListNode(4);
ListNode c3 = new ListNode(5);

a1.next = a2;
a2.next = c1;

b1.next = b2;
b2.next = b3;
b3.next = c1;

c1.next = c2;
c2.next = c3;

Console.WriteLine(new Solution().GetIntersectionNode(a1, b1).val);

Console.ReadKey();

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        int A_len = 1;
        int B_len = 1;
        var A_cur = headA;
        var B_cur = headB;
        while (A_cur.next != null || B_cur.next != null)
        {
            if (A_cur.next != null)
            {
                A_len++;
                A_cur = A_cur.next;
            }
            if (B_cur.next != null)
            {
                B_len++;
                B_cur = B_cur.next;
            }
        }
        if (A_cur != B_cur) return null;
        var short_branch = A_len < B_len ? headA : headB;
        var long_branch = A_len < B_len ? headB : headA;
        int dif = Math.Abs(A_len - B_len);
        for (int i = 0; i < dif; ++i) long_branch = long_branch.next;
        while (long_branch != short_branch)
        {
            long_branch = long_branch.next;
            short_branch = short_branch.next;
        }
        return short_branch;
    }
}