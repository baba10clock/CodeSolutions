public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int actualSumm = 0, n = nums.Length, expectedSumm = (n*(n + 1))/2;
        int repeating = 0;
        var set = new HashSet<int>();
        foreach(var i in nums)
        {
            if(set.Contains(i))
            {
                repeating = i;
            }
            else
            {
                set.Add(i);
            }
            actualSumm += i;
        }
        int missing = expectedSumm - actualSumm + repeating;
        return new int[] { repeating, missing };
    }
}