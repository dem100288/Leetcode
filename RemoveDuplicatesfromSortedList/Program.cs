
ListNode l13 = new ListNode(2);
ListNode l12 = new ListNode(1, l13);
ListNode l11 = new ListNode(1, l12);

ListNode l25 = new ListNode(3);
ListNode l24 = new ListNode(3, l25);
ListNode l23 = new ListNode(2, l24);
ListNode l22 = new ListNode(1, l23);
ListNode l21 = new ListNode(1, l22);


Console.WriteLine(new Solution().DeleteDuplicates(l11));
Console.WriteLine(new Solution().DeleteDuplicates(l21));


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
    public ListNode DeleteDuplicates(ListNode head)
    {
        var first = head;
        while (head != null)
        {
            if (head.next != null)
            {
                if (head.val == head.next.val)
                {
                    head.next = head.next.next;
                }
                else
                {
                    head = head.next;
                }
            }
            else
            {
                head = head.next;
            }
        }
        return first;
    }
}