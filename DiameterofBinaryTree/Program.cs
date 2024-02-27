Console.WriteLine(new Solution().DiameterOfBinaryTree(new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3)))); // 3
Console.WriteLine(new Solution().DiameterOfBinaryTree(new TreeNode(1, new TreeNode(2)))); // 1

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
    private (int lenth, int diameter) RecDiameterNode(TreeNode node)
    {
        if (node is null) return (0, 0);
        var left = RecDiameterNode(node.left);
        var right = RecDiameterNode(node.right);
        var diameter = left.lenth + right.lenth;
        return (1 + Math.Max(left.lenth, right.lenth), Math.Max(diameter, Math.Max(left.diameter, right.diameter)));
    }
    public int DiameterOfBinaryTree(TreeNode root)
    {
        return RecDiameterNode(root).diameter;
    }
}