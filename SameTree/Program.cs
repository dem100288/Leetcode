﻿var t3 = new TreeNode(3);
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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if ((p == null && q != null) || (q == null && p != null)) return false;
        if (p == null && q == null) return true;
        if (p.val != q.val) return false;
        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }
}