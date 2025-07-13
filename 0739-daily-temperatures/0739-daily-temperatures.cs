public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stk = new Stack<int>(); // storing days
        var res = new int[temperatures.Length];
        for(int i = 0; i < temperatures.Length; i++)
        {
            if(stk.Count == 0 || temperatures[i] <= temperatures[stk.Peek()])
            {
                stk.Push(i);
            }
            else
            {
                while(stk.Count > 0 && temperatures[i] > temperatures[stk.Peek()])
                {
                    res[stk.Peek()] = i - stk.Peek();
                    stk.Pop();
                }
                stk.Push(i);
            }
        }
        return res;
    }
}