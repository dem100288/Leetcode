Console.WriteLine(new Solution().IsEvenOddTree(new TreeNode(1, new TreeNode(10, new TreeNode(3, new TreeNode(12), new TreeNode(8))), 
    new TreeNode(4, new TreeNode(7, new TreeNode(6)), new TreeNode(9, null, new TreeNode(2)))))); // true
Console.WriteLine(new Solution().IsEvenOddTree(new TreeNode(5, new TreeNode(4, new TreeNode(3), new TreeNode(3)), new TreeNode(2, new TreeNode(7))))); // false

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
    private Dictionary<int, int> num_levels = new Dictionary<int, int>();

    private bool CheckNode(TreeNode node, int level)
    {
        if (node is null) return true;
        var eo_level = level % 2;
        if (node.val % 2 == eo_level) return false;
        if (num_levels.TryGetValue(level, out var val))
        {
            if (eo_level == 0)
            {
                if (node.val <= val) return false;
            }
            else
            {
                if (node.val >= val) return false;
            }
        }
        num_levels[level] = node.val;
        return CheckNode(node.left, level + 1) && CheckNode(node.right, level + 1);
    }

    public bool IsEvenOddTree(TreeNode root)
    {
        return CheckNode(root, 0);
    }
}