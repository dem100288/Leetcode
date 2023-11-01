Console.WriteLine(new Solution().IsPalindrome(121));
Console.WriteLine(new Solution().IsPalindrome(-121));
Console.WriteLine(new Solution().IsPalindrome(10));
Console.WriteLine(new Solution().IsPalindrome(11));
Console.ReadKey();

public class Solution
{
    public bool IsPalindrome(int x)
    {
        bool result = true;
        var x_str = x.ToString();
        int str_len = x_str.Length;
        int part_len = str_len / 2;
        for(int i = 0; i < part_len; i++)
        {
            if (x_str[i] != x_str[str_len - i - 1])
            {
                result = false;
                break;
            }
        }
        return result;
    }
}
