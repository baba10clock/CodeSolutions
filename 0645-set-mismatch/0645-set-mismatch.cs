public class Solution {
    public int[] FindErrorNums(int[] nums) {
        var minHeap = new PriorityQueue<int, int>();
        var set = new HashSet<int>(nums);
        foreach(var i in nums)
        {
            minHeap.Enqueue(i,i);
        }
        var len = minHeap.Count;
        var prev = 0;
        var missing = 0;
        var repeating = 0;
        for(int i = 0; i < len; i++)
        {
            prev = minHeap.Peek();
            if( minHeap.Count > 0 && (i + 1) != minHeap.Peek() && !set.Contains(i+1))
            {
                missing = i + 1;
            }
            minHeap.Dequeue();
            if(minHeap.Count > 0 && prev == minHeap.Peek())
            {
                repeating = prev;
            }   
        }
        // 2,3,3,4,5,6
        return new int[] { repeating, missing };
    }
}