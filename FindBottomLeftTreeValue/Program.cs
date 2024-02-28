Console.WriteLine(new Solution().FindBottomLeftValue(new TreeNode(2, new TreeNode(1), new TreeNode(3)))); // 1
Console.WriteLine(new Solution().FindBottomLeftValue(new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3, new TreeNode(5, new TreeNode(7)), new TreeNode(6))))); // 7

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
    public (int depth, int value) RecBottomLeft(TreeNode node, int depth)
    {
        if (node is null) return (0, 0);
        depth++;
        if (node.left is null && node.right is null) return (depth, node.val);
        var left = RecBottomLeft(node.left, depth);
        var right = RecBottomLeft(node.right, depth);
        return right.depth > left.depth ? right : left;
    }
    public int FindBottomLeftValue(TreeNode root)
    {
        return RecBottomLeft(root, 0).value;
    }
}