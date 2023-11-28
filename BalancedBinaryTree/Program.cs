var t3 = new TreeNode(3);
var t2 = new TreeNode(2);
var t1 = new TreeNode(1, t3, t2);

Console.WriteLine(new Solution().IsBalanced(t1));


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
    public int MaxDifDepthBranches = 0;
    public int DepthBranches(TreeNode root)
    {
        if (root == null) return 0;
        var lt = DepthBranches(root.left);
        var rt = DepthBranches(root.right);
        MaxDifDepthBranches = Math.Max(MaxDifDepthBranches, Math.Abs(lt - rt));
        return 1 + Math.Max(lt, rt);
    }

    public bool IsBalanced(TreeNode root)
    {
        DepthBranches(root);
        return MaxDifDepthBranches <= 1;
    }
}