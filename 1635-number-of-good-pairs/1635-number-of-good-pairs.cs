public class Solution {
    public int NumIdenticalPairs(int[] nums) {
        var map = new Dictionary<int,int>();
        foreach(var i in nums)
        {
            map[i] = map.GetValueOrDefault(i) + 1;
        }
        int pairs = 0;
        foreach(var val in map.Values)
        {
            if(val > 1)
            {
                pairs += (val * (val - 1)/2);
            }
        }
        return pairs;
    }
}