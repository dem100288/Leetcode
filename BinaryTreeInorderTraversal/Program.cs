var t3 = new TreeNode(3);
var t2 = new TreeNode(2, t3, null);
var t1 = new TreeNode(1, null, t2);

new Solution().InorderTraversal(t1);


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
    
    public IList<int> InorderTraversal(TreeNode root)
    {
        if (root is null) return new int[0];
        var nodes = new List<TreeNode>
        {
            root
        };
        TreeNode node = root;
        int ind = 0;
        while (true)
        {
            if (node.left != null)
            {
                nodes.Insert(ind, node.left);
                node.left = null;
                node = nodes[ind];
            }
            else if (node.right != null)
            {
                ind++;
                nodes.Insert(ind, node.right);
                node.right = null;
                node = nodes[ind];
            }
            else
            {
                ind++;
                if (ind >= nodes.Count)
                {
                    break;
                }
                node = nodes[ind];
                
            }
        }
        return nodes.Select(x => x.val).ToArray();
    }
}