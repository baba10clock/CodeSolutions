public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int actualSumm = nums.Sum(), n = nums.Length, expectedSumm = (n*(n + 1))/2;
        int repeating = 0;
        var set = new HashSet<int>();
        foreach(var i in nums)
        {
            if(set.Contains(i))
            {
                repeating = i;
                break;
            }
            else
            {
                set.Add(i);
            }
        }
        int missing = expectedSumm - actualSumm + repeating;
        return new int[] { repeating, missing };
    }
}