public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stk = new Stack<(int,int)>(temperatures.Length);
        var res = new int[temperatures.Length];
        for(int i = 0; i < temperatures.Length; i++)
        {
            int t = temperatures[i];
            while(stk.Count > 0 && t > stk.Peek().Item1)
            {
                var tuple = stk.Pop();
                res[tuple.Item2] = i - tuple.Item2;
            }
            stk.Push((t,i));
        }
        return res;
    }
}