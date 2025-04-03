public class Solution {
    public int MinimumDifference(int[] nums, int k) {
        int i = 0, j = k - 1, res = int.MaxValue;
        Array.Sort(nums);
        while(j < nums.Length)
        {
            var temp = nums[j] - nums[i];
            res = Math.Min(temp, res);
            i++;
            j++;
        }
        return res == int.MaxValue ? 0 : res;
    }
}