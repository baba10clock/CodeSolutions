public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var pq = new PriorityQueue<int[],int>();
        foreach(var point in points)
        {
            var dist = point[0]*point[0] + point[1]*point[1];
            pq.Enqueue(point, -dist);
            if(pq.Count > k)
            {
                pq.Dequeue();
            }
        }
        var res = new int [k][];
        for(int i = 0; i < k; i++)
        {
            res[i] = pq.Dequeue();
        }
        return res;
    }
}