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
    private int dia = 0;
    public int DiameterOfBinaryTree(TreeNode root) {
        if(root == null)    return 0;
        Maxx(root);
        return dia;
    }
    public int Maxx(TreeNode root)
    {
        if(root == null)
            return 0;
        var left = Maxx(root.left);
        var right = Maxx(root.right);
        dia = Math.Max(dia, left + right);
        return Math.Max(left, right) + 1;
    }
}