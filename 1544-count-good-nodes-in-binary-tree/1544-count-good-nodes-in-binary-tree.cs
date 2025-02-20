/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    private int count = 0;
   public int GoodNodes(TreeNode root) {
        Inorder(root, long.MinValue);
        return count;
    }

    private void Inorder(TreeNode node, long max) {
        if (node == null)
            return;

        if (node.val >= max) {
            count++;
            max = node.val;
        }

        Inorder(node.left, max);
        Inorder(node.right, max);
    }
}