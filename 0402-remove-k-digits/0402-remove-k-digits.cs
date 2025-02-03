public class Solution {
    public string RemoveKdigits(string num, int k) {
        var stk = new Stack<char>();
 
        foreach(var i in num)
        {
            while(stk.Count > 0 && k > 0 && i < stk.Peek())
            {
                stk.Pop();
                k--;
            }
            stk.Push(i);
        }

        while(stk.Count > 0 && k > 0)
        {
            stk.Pop();
            k--;
        }

        var res = new string(stk.Reverse().ToArray()).TrimStart('0');

        return res.Length > 0 ? res : "0";

    }
}