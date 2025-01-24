public class Solution {
    public int PivotIndex(int[] nums) {
        int lSum = 0, rSum = 0, total = nums.Sum();
        for(int i = 0; i < nums.Length ; i++)
        {
            
            rSum = total - nums[i] - lSum ;
            if(rSum == lSum)
            {
                return i;
            }
            lSum += nums[i];
        }
        return -1;
    }
}