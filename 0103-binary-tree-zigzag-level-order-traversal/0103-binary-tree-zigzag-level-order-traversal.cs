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
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        var res = new List<IList<int>>();
        var q = new Queue<TreeNode>();
        if(root != null)
        {
            q.Enqueue(root);
        }
        else
        {
            return res;
        }
        var flag = false;
        while( q.Count > 0)
        {
           
            var level = new List<int>();
            int qCount = q.Count;
            for(int i = 0 ; i < qCount; i++)
            {
                var node = q.Dequeue();
                level.Add(node.val);
                if(node.left != null)
                    q.Enqueue(node.left);
                if(node.right != null)
                    q.Enqueue(node.right);     
            }
            if(flag == true)
            {
                level.Reverse();
            }
            res.Add(level);
            flag = !flag;
        }
        return res;
    }
}