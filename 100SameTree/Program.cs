//Console.WriteLine(new Solution().IsSameTree(new TreeNode(1, new TreeNode(2), new TreeNode(3)), new TreeNode(1, new TreeNode(2), new TreeNode(3)))); // true
//Console.WriteLine(new Solution().IsSameTree(new TreeNode(1, new TreeNode(2)), new TreeNode(1, null, new TreeNode(2)))); // false
//Console.WriteLine(new Solution().IsSameTree(new TreeNode(1, new TreeNode(2), new TreeNode(1)), new TreeNode(1, new TreeNode(1), new TreeNode(2)))); // false
Console.WriteLine(new Solution().IsSameTree(new TreeNode(10, new TreeNode(5), new TreeNode(15)), new TreeNode(10, new TreeNode(5, null, new TreeNode(15))))); // false

Console.ReadKey();

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p is null || q is null) return p is null && q is null;
        if (p.val != q.val) return false;
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}