public class Solution {
    public int LastStoneWeight(int[] stones) {
        var pq = new PriorityQueue<int,int>();
        foreach(var i in stones)
        {
            pq.Enqueue(i, -i);
        }
        while(pq.Count > 1)
        {
            var a = pq.Dequeue();
            var b = pq.Dequeue();
            if(a == b)  pq.Enqueue(0, 0);
            else    pq.Enqueue(a-b, -(a-b));
        }
        return pq.Dequeue();
    }
}