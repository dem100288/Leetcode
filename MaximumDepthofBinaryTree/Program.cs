var t3 = new TreeNode(3);
var t2 = new TreeNode(2, t3, null);
var t1 = new TreeNode(1, null, t2);

//new Solution().IsSameTree(t1);


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
    public int RecNode(TreeNode node, int depth)
    {
        if (node == null) return depth;
        depth++;
        return Math.Max(RecNode(node.left, depth), RecNode(node.right, depth));
    }
    public int MaxDepth(TreeNode root)
    {
        return RecNode(root, 0);
    }
}