using System.Xml.Linq;

TreeNode n1 = new TreeNode(1);
TreeNode n3 = new TreeNode(3);
TreeNode n6 = new TreeNode(6);
TreeNode n9 = new TreeNode(9);
TreeNode n2 = new TreeNode(2, n1, n3);
TreeNode n7 = new TreeNode(7, n6, n9);
TreeNode n4 = new TreeNode(4, n2, n7);

TreeNode n21 = new TreeNode(1);
TreeNode n23 = new TreeNode(3);
TreeNode n22 = new TreeNode(2, n21, n23);

Console.WriteLine(new Solution().InvertTree(n4));
Console.WriteLine(new Solution().InvertTree(n22));
Console.WriteLine(new Solution().InvertTree(null));


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
    private void InvertNode(TreeNode node)
    {
        if (node is null) return;
        InvertNode(node.left);
        InvertNode(node.right);
        (node.left, node.right) = (node.right, node.left);
    }
    public TreeNode InvertTree(TreeNode root)
    {
        InvertNode(root);
        return root;
    }
}