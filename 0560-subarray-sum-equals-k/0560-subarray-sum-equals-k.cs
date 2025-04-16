public class Solution {
    public int SubarraySum(int[] nums, int k) {
        var map = new Dictionary<int, int>();
        int preSum = 0, count = 0;
        map[preSum] = 1;
        foreach(var i in nums)
        {
            preSum += i;
            int remove = preSum - k;
            count += map.GetValueOrDefault(remove);
            map[preSum] = map.GetValueOrDefault(preSum) + 1;
        }
        return count;
    }
}