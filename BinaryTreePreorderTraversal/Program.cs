//Binary Tree Preorder Traversal
TreeNode n1 = new TreeNode(1);
TreeNode n2 = new TreeNode(2);
TreeNode n3 = new TreeNode(3);

n1.right = n2;
n2.left = n3;

Console.WriteLine(string.Join(" ", new Solution().PreorderTraversal(null)));
Console.WriteLine(string.Join(" ", new Solution().PreorderTraversal(n1)));

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
    public IList<int> PreorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        if (root == null) return res;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            res.Add(node.val);
            if (node.right != null) stack.Push(node.right);
            if (node.left != null) stack.Push(node.left);
        }
        return res;
    }
}