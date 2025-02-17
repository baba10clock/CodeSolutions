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
    private TreeNode prev, first, second;
    public void RecoverTree(TreeNode root) {
        Dfs(root);
        (first.val, second.val)=(second.val, first.val);
    }
    private void Dfs(TreeNode root)
    {
        if(root == null)    return;
        Dfs(root.left);
        if(prev != null && prev.val > root.val)
        {
            if(first == null)   first = prev;
            second = root;
        }
        prev = root;

        Dfs(root.right);
    }
}