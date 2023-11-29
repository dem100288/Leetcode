//Binary Tree Postorder Traversal
TreeNode n1 = new TreeNode(1);
TreeNode n2 = new TreeNode(2);
TreeNode n3 = new TreeNode(3);
TreeNode n21 = new TreeNode(1);
TreeNode n22 = new TreeNode(2);
TreeNode n23 = new TreeNode(3);

n1.right = n2;
n2.left = n3;
n23.left = n21;
n23.right = n22;

Console.WriteLine(string.Join(" ", new Solution().PostorderTraversal(null)));
Console.WriteLine(string.Join(" ", new Solution().PostorderTraversal(n1)));
Console.WriteLine(string.Join(" ", new Solution().PostorderTraversal(n23)));

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
    public IList<int> PostorderTraversal(TreeNode root)
    {
        List<int> res = new List<int>();
        if (root == null) return res;
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        while (stack.Count > 0)
        {
            var node = stack.Pop();
            res.Insert(0, node.val);
            if (node.left != null) stack.Push(node.left);
            if (node.right != null) stack.Push(node.right);
        }
        return res;
    }
}