public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        int [] res = Enumerable.Repeat(-1, nums1.Length).ToArray();
        var stk = new Stack<int>();
        var map = new Dictionary<int,int>();
        for(int index = 0; index < nums1.Length; index++)
        {
            map[nums1[index]] = index;
        }

        foreach(int num in nums2)
        {
            while(stk.Count != 0 && stk.Peek() < num)
            {
                int val = stk.Pop();
                int idx = map[val];
                res[idx] = num;
            }
            if(map.ContainsKey(num))
            {
                stk.Push(num);
            }
        }
        return res;
    }
}