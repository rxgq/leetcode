namespace leetcode.easy;


public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public partial class Solution {
    public bool EvaluateTree(TreeNode root) {
        if (root is null) return false;
        if (root.left is null && root.right is null) return root.val == 1;

        if (root.val == 2) return EvaluateTree(root.left) || EvaluateTree(root.right);
        else return EvaluateTree(root.left) && EvaluateTree(root.right);
    }
}