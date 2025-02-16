public class Solution {
    public int MaxProduct(int[] nums) {
        int maxProd = 0, l = 0, r = nums.Length - 1;
        while(l < r)
        {
            var prod = (nums[l] - 1) * (nums[r] - 1);
            if(nums[l] <= nums[r])  l++;
            else if(nums[r] < nums[l]) r--;
            maxProd = Math.Max(maxProd, prod);
        }
        return maxProd;
    }
}