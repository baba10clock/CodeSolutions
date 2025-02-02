public class Solution {
    public string RemoveStars(string s) {
        var stk = new Stack<char>();
        foreach(var i in s)
        {
            if(stk.Count > 0 && i == '*')
            {
                stk.Pop();
            }
            else
            {
                stk.Push(i);
            }
        }
        
        return string.Concat(stk.Reverse());
    }
}