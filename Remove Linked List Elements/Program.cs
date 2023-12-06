//Remove Linked List Elements

ListNode l1 = new ListNode(1);
ListNode l2 = new ListNode(2);
ListNode l3 = new ListNode(2);
ListNode l4 = new ListNode(1);


l1.next = l2;
l2.next = l3;
l3.next = l4;


Console.WriteLine(new Solution().RemoveElements(l1, 2)); 
Console.WriteLine(new Solution().RemoveElements(l1, 3)); 
Console.WriteLine(new Solution().RemoveElements(l1, 5)); 

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
    public ListNode RemoveElements(ListNode head, int val)
    {
        ListNode prev_node = null;
        ListNode node = head;
        ListNode new_head = head;
        while (node != null)
        {
            if (node.val == val)
            {
                if (prev_node == null)
                {
                    new_head = node.next;
                }
                else
                {
                    prev_node.next = node.next;
                }
            }
            else
            {
                prev_node = node;
            }
            node = node.next;
        }
        return new_head;
    }
}