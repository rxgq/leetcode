namespace leetcode.easy;

public partial class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        if (cloned == null || cloned.val == target.val) return cloned;
        return GetTargetCopy(original, cloned.left, target) ?? GetTargetCopy(original, cloned.right, target);
    }
}