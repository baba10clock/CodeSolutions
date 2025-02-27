public class Solution {
    public int LargestPerimeter(int[] nums) {
        nums = nums.OrderByDescending(x => x).ToArray();
        for(int i = 0; i < nums.Length - 2; i++)
        {
            if(nums[i] < nums[i+1] + nums[i+2]) return nums[i] + nums[i+1] + nums[i+2];
        }
        return 0;
    }
}