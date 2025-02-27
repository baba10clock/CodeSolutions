public class KthLargest {
    private PriorityQueue<int,int> pq;
    private int limit;
    public KthLargest(int k, int[] nums) {
        pq = new PriorityQueue<int,int>();
        limit = k;
        foreach(var i in nums)
        {
            Add(i);
        }
    }
    
    public int Add(int val) {
        pq.Enqueue(val,val);
        if(pq.Count > limit)    pq.Dequeue();
        return pq.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */