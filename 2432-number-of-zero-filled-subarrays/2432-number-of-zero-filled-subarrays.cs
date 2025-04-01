public class Solution {
    public long ZeroFilledSubarray(int[] nums) {
        long totalCount = 0, currCount = 0;
        foreach(var i in nums)
        {
            if(i != 0)
            {
                totalCount += (currCount * (currCount + 1))/2;
                currCount = 0;
            }
            else
            {
                currCount++;
            }
        }
        totalCount += (currCount * (currCount + 1))/2;
        return totalCount;
    }
}