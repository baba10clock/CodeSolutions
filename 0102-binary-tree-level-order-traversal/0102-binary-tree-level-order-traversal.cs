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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var res = new List<IList<int>>();
        if(root == null)    return res;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        while(q.Count > 0)
        {
            var len = q.Count;
            var temp = new List<int>();
            for(int i = 0; i < len; i++)
            {
                var node = q.Dequeue();
                temp.Add(node.val);
                if(node.left != null)   q.Enqueue(node.left);
                if(node.right != null)  q.Enqueue(node.right);
            }
            res.Add(temp);
        }
        return res;
    }
}