public class Solution {
    public string FrequencySort(string s) {
        var pq = new PriorityQueue<string, int>();
        var map = new Dictionary<char, int>();
        foreach(var i in s)
        {
            map[i] = map.GetValueOrDefault(i) + 1;
        }

        foreach(var i in map.Keys)
        {
            pq.Enqueue(new string(i, map[i]), -map[i]);
        }

        var res = "";
        while(pq.Count > 0)
        {
            res += pq.Dequeue();
        }

        return res;       
    }
}