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
    public TreeNode SortedArrayToBST(int[] nums) {
        return BST(nums, 0, nums.Length - 1);
    }
    public TreeNode BST(int [] nums, int left, int right)
    {
        if(left > right)
        {
            return null;
        }
        int mid = left + (right - left) / 2;
        TreeNode node = new TreeNode(nums[mid]);
        node.left = BST(nums, left, mid - 1);
        node.right = BST(nums, mid + 1, right);
        return node;

    }
}