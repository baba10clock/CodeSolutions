public class Solution {
    public int TriangleNumber(int[] nums) {
        Array.Sort(nums);
        int count = 0;
        for(int k = nums.Length - 1; k >= 2; k--)
        {
            int i = 0;
            int j = k - 1;
            while(i < j)
            {
                if(nums[i] + nums[j] > nums[k])
                {
                    count += (j - i);
                    j--;
                }
                else
                {
                    i++;
                }
            }
        }
        return count;
    }
}