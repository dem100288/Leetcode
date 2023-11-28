var t3 = new TreeNode(3);
var t2 = new TreeNode(2);
var t1 = new TreeNode(1, t3, t2);

Console.WriteLine(new Solution().MinDepth(t1));


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
    public int MinDepthBranches(TreeNode root)
    {
        if (root.left == null && root.right == null) return 1;

        return 1 + Math.Min(
            root.left == null ? int.MaxValue : MinDepthBranches(root.left), 
            root.right == null ? int.MaxValue : MinDepthBranches(root.right)
            );
    }

    public int MinDepth(TreeNode root)
    {
        return root == null ? 0 : MinDepthBranches(root);
    }
}