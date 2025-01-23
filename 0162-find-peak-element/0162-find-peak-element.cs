public class Solution {
    public int FindPeakElement(int[] nums) {
        int l = 0, m, r = nums.Length - 1;
        while(l <= r)
        {
            m = l + ((r - l) / 2);
            if(m > 0 && nums[m] < nums[m-1])
            {
                r = m - 1;
            }
            else if(m < nums.Length - 1 && nums[m] < nums[m+1])
            {
                l = m + 1;
            }
            else
                return m;
        }
        return 0;
    }
}