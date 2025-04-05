public class Solution {
    public int[] RunningSum(int[] nums) {
        int len = nums.Length;
        int [] res = new int [len];
        int pre = 0;
        for(int i = 0; i < len; i++)
        {
            pre += nums[i];
            res[i] = pre;
        }
        return res;
    }
}