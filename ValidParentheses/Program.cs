Console.WriteLine(new Solution().IsValid("()"));
Console.WriteLine(new Solution().IsValid("()[]{}"));
Console.WriteLine(new Solution().IsValid("[{}]"));

Console.WriteLine(new Solution().IsValid("[{[}{]}]"));
Console.WriteLine(new Solution().IsValid("({([]}{()}[])[{}])"));
Console.WriteLine(new Solution().IsValid("(({[]}{([]})[])[{}])"));
Console.WriteLine(new Solution().IsValid("((({[]}{)})))"));
Console.WriteLine(new Solution().IsValid("[({}])"));
Console.WriteLine(new Solution().IsValid("(]"));
Console.ReadKey();

public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> a = new();
        foreach (var c in s)
        {
            switch (c)
            {
                case '(':
                    a.Push(')');
                    break;
                case '{':
                    a.Push('}');
                    break;
                case '[':
                    a.Push(']');
                    break;
                case ']':
                case ')':
                case '}':
                    if (a.Count == 0) return false;
                    var ac = a.Pop();
                    if (ac != c) return false;
                    break;
            }
        }

        return a.Count == 0;
    }
}