ListNode l11 = new ListNode(1);
ListNode l12 = new ListNode(2);
ListNode l13 = new ListNode(4);
ListNode l21 = new ListNode(1);
ListNode l22 = new ListNode(3);
ListNode l23 = new ListNode(4);
l11.next = l12;
l12.next = l13;
l21.next = l22;
l22.next = l23;

Console.WriteLine(new Solution().MergeTwoLists(l11, l21));
Console.WriteLine(new Solution().MergeTwoLists(null, null));
Console.WriteLine(new Solution().MergeTwoLists(null, new ListNode(0)));
//Console.WriteLine(new Solution().MergeTwoLists("()[]{}"));
//Console.WriteLine(new Solution().MergeTwoLists("[{}]"));

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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 is null && list2 is null) return null;
        ListNode cur_node = null;
        ListNode first_node = null;
        var l1 = list1;
        var l2 = list2;
        if ((l1?.val ?? 101) < (l2?.val ?? 101))
        {
            cur_node = l1;
            first_node = l1;
            l1 = l1.next;
        }
        else
        {
            cur_node = l2;
            first_node = l2;
            l2 = l2.next;
        }
        
        while (l1 is not null || l2 is not null)
        {
            if ((l1?.val ?? 101) < (l2?.val ?? 101))
            {
                cur_node.next = l1;
                cur_node = l1;
                l1 = l1.next;
            }
            else
            {
                cur_node.next = l2;
                cur_node = l2;
                l2 = l2.next;
            }
        }
        return first_node;
    }
}