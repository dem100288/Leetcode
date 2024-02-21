Console.WriteLine(new Solution().IsPalindrome(new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1)))))); // true
Console.WriteLine(new Solution().IsPalindrome(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(2, new ListNode(1))))))); // true
Console.WriteLine(new Solution().IsPalindrome(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(2, new ListNode(1)))))))); // true
Console.WriteLine(new Solution().IsPalindrome(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(3, new ListNode(2, new ListNode(1))))))))); // true
Console.WriteLine(new Solution().IsPalindrome(new ListNode(1))); // true
Console.WriteLine(new Solution().IsPalindrome(new ListNode(1, new ListNode(2)))); // false
Console.WriteLine(new Solution().IsPalindrome(new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(1)))))))); // false
Console.WriteLine(new Solution().IsPalindrome(new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(2, new ListNode(3, new ListNode(2, new ListNode(2, new ListNode(3)))))))))); // false
Console.WriteLine(new Solution().IsPalindrome(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3, new ListNode(2, new ListNode(1, new ListNode(1, new ListNode(3, new ListNode(2, new ListNode(2, new ListNode(3, new ListNode(1)))))))))))))); // false


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
    public bool IsPalindrome(ListNode head)
    {
        if (head.next is null) return true;
        if (head.next.next is null) return head.val == head.next.val;
        int sum_l = head.val;
        int ssum_l = sum_l;
        ListNode mid_l = head;
        ListNode mid_r = head.next.next;
        int sum_r = head.next.next.val;
        int ssum_r = sum_r;
        int sign = 1;
        int sign_mid = 1;
        head = head.next.next.next;
        while (head != null)
        {
            sign *= -1;
            sum_r *= -1;
            sum_r += head.val;
            ssum_r += head.val;
            if (sign < 0)
            {
                sign_mid *= -1;
                mid_l = mid_l.next;
                sum_l += mid_l.val * sign_mid;
                ssum_l += mid_l.val;
            }
            else
            {
                sum_r += mid_r.val * sign_mid;
                ssum_r -= mid_r.val;
                mid_r = mid_r.next;
            }
            head = head.next;
        }
        return sum_l == sum_r && ssum_l == ssum_r;
    }
}