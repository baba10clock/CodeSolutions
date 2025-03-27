public class Solution {
    public int MaxDepth(string s) {
        var stk = new Stack<int>();
        var maxx = 0;
        foreach(var i in s)
        {
            if(i == '(')
            {
                stk.Push('(');
                maxx = Math.Max(maxx, stk.Count);
            }
            else if(i == ')')
                stk.Pop();
        }
        return maxx;
    }
}