public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int[],double>();
        foreach(var point in points)
        {
            var dist = Math.Sqrt(Math.Pow(point[0],2) + Math.Pow(point[1], 2));
            pq.Enqueue(point, -dist);
            if(pq.Count > k)
            {
                pq.Dequeue();
            }
        }
        var res = new int [k][];
        var len = pq.Count;
        for(int i = 0; i < len; i++)
        {
            res[i] = pq.Dequeue();
        }
        return res;
    }
}