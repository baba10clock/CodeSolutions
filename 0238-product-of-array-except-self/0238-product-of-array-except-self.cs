public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int n = nums.Length;
        var res = new int[n];
        Array.Fill(res,1);
        int prefix = 1;
        for(int i = 0; i < n; i++)
        {
            res[i] = prefix;
            prefix *= nums[i]; 

        }
        int suffix = 1;
        for(int i = n - 1; i >= 0; i--)
        {
            res[i] *= suffix;
            suffix *= nums[i];
        }
        return res;

    }
}