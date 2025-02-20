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
    private int good;
    public int GoodNodes(TreeNode root) {
        good = 0;
        Verify(root, root.val);
        return good;
    }
    public void Verify(TreeNode root, int max)
    {
        if(root == null)    return;
        if(root.val >= max)
        {
                good++;
                max = root.val;
        }
        Verify(root.left, max);
        Verify(root.right, max); 
    }
}