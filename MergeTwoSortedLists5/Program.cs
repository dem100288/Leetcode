using System;

namespace MergeTwoSortedLists5
{
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
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Console.WriteLine(new Program().MergeTwoLists(l11, l21));
            //Console.WriteLine(new Solution().MergeTwoLists("()[]{}"));
            //Console.WriteLine(new Solution().MergeTwoLists("[{}]"));

            Console.ReadKey();
        }

        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
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

            while (l1 is not null && l2 is not null)
            {
                if ((l1?.val ?? 101) < (l2?.val ?? 101))
                {
                    var temp = l1.next;
                    cur_node = l1;
                    first_node = l1;
                    l1 = temp;
                }
                else
                {
                    var temp = l2.next;
                    cur_node = l2;
                    first_node = l2;
                    l2 = temp;
                }
            }
            return first_node;
        }
    }
}
