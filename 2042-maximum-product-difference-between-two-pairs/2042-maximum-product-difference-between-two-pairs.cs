public class Solution {
    public int MaxProductDifference(int[] nums) {
        Array.Sort(nums);
        int a = nums[^1];
        int b = nums[^2];
        int c = nums[0];
        int d = nums[1];
        return a*b - c*d;
    }
}