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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if(root == null) return new TreeNode(val);
        Insert(root, val);
        return root;
    }
    public void Insert(TreeNode root, int val)
    {
        if(root.val > val)
        {
            if(root.left != null)
            {
                Insert(root.left, val);
            }
            else
            {
                root.left = new TreeNode(val);
            }
        }
        if(root.val < val)
        {
            if(root.right != null)
            {
                Insert(root.right, val);
            }
            else
            {
                root.right = new TreeNode(val);
            }
        }
    }
}