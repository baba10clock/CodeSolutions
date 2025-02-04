public class Solution {
    public int SearchInsert(int[] nums, int target) {
        

        int l = 0, r = nums.Length - 1, m;
        while(l <= r)
        {
            m = l + (r - l)/2;
            if(target == nums[m])    return m;
            else if(target < nums[m])   r = m - 1;
            else    l = m + 1;
        }
        return l;
    }
}