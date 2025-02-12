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
    public IList<int> PreorderTraversal(TreeNode root) {
        lst = new List<int>();
        Preorder(root);
        return lst;
    }
    public void Preorder(TreeNode root)
    {
        if(root != null)
        {
            lst.Add(root.val);
            Preorder(root.left);
            Preorder(root.right);
        }
    }
}