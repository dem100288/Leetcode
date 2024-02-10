TreeNode n11 = new TreeNode(1);
TreeNode n12 = new TreeNode(2);
TreeNode n13 = new TreeNode(3);
TreeNode n14 = new TreeNode(4);
TreeNode n15 = new TreeNode(5);
TreeNode n16 = new TreeNode(6);
TreeNode n21 = new TreeNode(1);

n11.left = n12;
n11.right = n13;
n12.left = n14;
n12.right = n15;
n13.left = n16;



Console.WriteLine(new Solution().CountNodes(n11));
Console.WriteLine(new Solution().CountNodes(null));
Console.WriteLine(new Solution().CountNodes(n21));


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
    public int CountNodes(TreeNode root)
    {
        if (root == null) return 0;
        return 1 + CountNodes(root.left) + CountNodes(root.right);
    }
}