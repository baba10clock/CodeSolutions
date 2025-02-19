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
    private List<int> lst;
    public int KthSmallest(TreeNode root, int k) {
        lst = new List<int>();
        getList(root);
        return lst[k - 1];
    }
    public void getList(TreeNode root)
    {
        if(root == null)    return;
        getList(root.left);
        lst.Add(root.val);
        getList(root.right);
        return;
    }
}