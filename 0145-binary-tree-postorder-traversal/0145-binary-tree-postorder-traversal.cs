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
    public IList<int> PostorderTraversal(TreeNode root) {
        lst = new List<int>();
        Postorder(root);
        return lst;
    }
    public void Postorder(TreeNode root)
    {
        if(root != null)
        {
            Postorder(root.left);
            Postorder(root.right);
            lst.Add(root.val);
        }
    }
}