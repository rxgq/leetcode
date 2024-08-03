
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
 
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var result = new List<int>();

        void inOrder(TreeNode node) {
          if (node is null) 
            return;

          inOrder(node.left);
          result.Add(node.val);
          inOrder(node.right);
        }

        inOrder(root);
        return result;
    }
}