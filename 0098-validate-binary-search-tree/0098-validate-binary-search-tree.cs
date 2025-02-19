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
    public bool IsValidBST(TreeNode root) {
        return Verify(root, long.MinValue, long.MaxValue);
        
    }
    public bool Verify(TreeNode root, long rootValueForLeft,long rootValueForRight)
    {
        if(root == null)    return true;
        if(root.val <= rootValueForLeft || root.val >= rootValueForRight) return false;
        return Verify(root.left,rootValueForLeft,root.val) && Verify(root.right, root.val, rootValueForRight);
    }
}