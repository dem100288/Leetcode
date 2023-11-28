var t3 = new TreeNode(3);
var t2 = new TreeNode(2);
var t1 = new TreeNode(1, t3, t2);

Console.WriteLine(new Solution().HasPathSum(t1, 4));


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
    public bool FindSumm(TreeNode root, int targetSum)
    {
        var val = targetSum - root.val;
        if (root.left == null && root.right == null)
        {
            if (val == 0) return true;
        }
        var l = root.left == null ? false : FindSumm(root.left, val);
        return  l
            || (root.right == null ? false : FindSumm(root.right, val));
    }

    public bool HasPathSum(TreeNode root, int targetSum)
    {
        return root == null ? false : FindSumm(root, targetSum);
    }
}