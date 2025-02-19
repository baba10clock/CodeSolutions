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
    private List<int> res;
    public IList<int> RightSideView(TreeNode root) {
        res = new List<int>();
        if(root == null)    return res;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        
        while(q.Count > 0)
        {
            var len = q.Count;
            for(int i = 0; i < len; i++)
            {
                var node = q.Dequeue();
                if(i == len - 1)
                {
                    res.Add(node.val);
                }
                if(node.left != null)   q.Enqueue(node.left);
                if(node.right != null)  q.Enqueue(node.right);
            }
        }
        return res;
    }
}