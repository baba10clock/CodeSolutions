public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //make frequency map
        var map = new Dictionary<int,int>();
        foreach(var i in nums)
        {
            map[i] = map.GetValueOrDefault(i) + 1;
        }
        //create bucket
        var bucket = new List<int>[nums.Length + 1];

        //fill bucket
        foreach(var pair in map)
        {
            int val = pair.Value;
            if(bucket[val] == null)
                bucket[val] = new List<int>();
            bucket[val].Add(pair.Key);
        }

        //get top k from bucket
        var res = new List<int>();
        for(int i = bucket.Length - 1; i > 0 && res.Count < k; i--)
        {
            if(bucket[i] != null)
                res.AddRange(bucket[i]);
        }

        //return result
        return res.Take(k).ToArray();
    }

   
}