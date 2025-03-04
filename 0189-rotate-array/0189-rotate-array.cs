public class Solution {
    public void Rotate(int[] nums, int k) {
        var len = nums.Length;
        k = k % len;
        Array.Reverse(nums);
        Array.Reverse(nums, 0 , k);
        Array.Reverse(nums, k, len - k);
    }
}