public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int curr = 0, maxx = int.MinValue;
        foreach(var num in nums)
        {
            if(num == 1)
                curr++;
            else
            {
                maxx = Math.Max(curr, maxx);
                curr = 0;
            }
        }
        return Math.Max(curr, maxx);
    }
}