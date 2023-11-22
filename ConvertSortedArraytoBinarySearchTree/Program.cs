//var t3 = new TreeNode(3);
//var t2 = new TreeNode(2, t3, null);
//var t1 = new TreeNode(1, null, t2);

new Solution().SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 });


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

public class ExtTreeNode : TreeNode
{
    public ExtTreeNode eleft => left as ExtTreeNode;
    public ExtTreeNode eright => right as ExtTreeNode;
    public int Balance => 1 + Math.Max(eleft?.Balance ?? 0, eright?.Balance ?? 0);

    public ExtTreeNode(int val = 0, ExtTreeNode left = null, ExtTreeNode right = null) : base(val, left, right) { }
}

public class Solution
{
    public ExtTreeNode BalanceNode(ExtTreeNode node)
    {
        if (node == null) return node;
        while (true)
        {
            int lb = node.eleft?.Balance ?? 0;
            int rb = node.eright?.Balance ?? 0;
            int dif = lb - rb;
            if (Math.Abs(dif) > 1)
            {
                if (Math.Sign(dif) > 0)
                {
                    ExtTreeNode lm = MaxRight(node.eleft);
                    lm.right = node;
                    var temp = node.eleft;
                    node.left = null;
                    node = temp;
                }
                else
                {
                    ExtTreeNode rm = MaxLeft(node.eright);
                    rm.left = node;
                    var temp = node.eright;
                    node.right = null;
                    node = temp;
                }
            }
            else
            {
                node.left = BalanceNode(node.eleft);
                node.right = BalanceNode(node.eright);
                return node;
            }
        }
    }

    public ExtTreeNode MaxRight(ExtTreeNode node)
    {
        if (node.eright == null) return node;
        return MaxRight(node.eright);
    }

    public ExtTreeNode MaxLeft(ExtTreeNode node)
    {
        if (node.eleft == null) return node;
        return MaxLeft(node.eleft);
    }

    public TreeNode GetTree(int start, int end)
    {
        if (end < start) return null;
        if (start == end) return new(nums[start]);
        int middle = start + ((end - start) / 2);
        TreeNode node = new(nums[middle]);
        node.left = GetTree(start, middle - 1);
        node.right = GetTree(middle + 1, end);
        return node;
    }
    public int[] nums;
    public TreeNode SortedArrayToBST(int[] nums)
    {
        this.nums = nums;
        var root = GetTree(0, nums.Length - 1);
        return root;
    }

    public TreeNode SortedArrayToBST2(int[] nums)
    {
        ExtTreeNode root = new ExtTreeNode(nums[0]);
        ExtTreeNode cur = root;
        for (int i = 1; i < nums.Length; ++i)
        {
            cur.right = new ExtTreeNode(nums[i]);
            cur = cur.eright;
        }
        root = BalanceNode(root);
        return root;
    }
}