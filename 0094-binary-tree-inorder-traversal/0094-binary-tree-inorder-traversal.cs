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
    public IList<int> InorderTraversal(TreeNode root) {
        lst = new List<int>();
        InOrder(root);
        return lst;

    }
    public IList<int> InOrder(TreeNode root)
    {
        if(root != null)
        {
            InOrder(root.left);
            lst.Add(root.val);
            InOrder(root.right);
        }
        return null;
    }
}