Console.WriteLine(new Solution().BinaryTreePaths(new TreeNode(1, new TreeNode(2, null, new TreeNode(5)), new TreeNode(3)))); // ["1->2->5","1->3"]
Console.WriteLine(new Solution().BinaryTreePaths(new TreeNode(1))); // ["1"]


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
    private void RecPaths(TreeNode node, string path, List<string> paths)
    {
        string p = path + "->" + node.val;
        if (node.left is null && node.right is null)
        {
            
            paths.Add(p.StartsWith("->") ? p.Substring(2) : p);
            return;
        }
        if (node.left is not null) RecPaths(node.left, p, paths);
        if (node.right is not null) RecPaths(node.right, p, paths);
    }
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        List<string> paths = new();
        RecPaths(root, "", paths);
        return paths;
    }
}