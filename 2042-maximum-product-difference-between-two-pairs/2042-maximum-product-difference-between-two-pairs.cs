public class Solution {
    public int MaxProductDifference(int[] nums) {
        int max1 = int.MinValue, max2 = int.MinValue, min1 = int.MaxValue, min2 = int.MaxValue;
        foreach(var ele in nums)
        {
            if(ele > max1)
            {
                max2 = max1;
                max1 = ele;
            }
            else if(ele > max2)
            {
                max2 = ele;
            }

            if(min1 > ele)
            {
                min2 = min1;
                min1 = ele;
            }
            else if(min2 > ele)
            {
                min2 = ele;
            }
        }
        return max1 * max2 - min1 * min2;
    }
}