public class Solution {
    public bool ValidateStackSequences(int[] pushed, int[] popped) {
        var stk = new Stack<int>();
        var q = new Queue<int>(popped);
        foreach(var i in pushed)
        {
            while(stk.Count > 0 && stk.Peek() == q.Peek())
            {
                stk.Pop();
                q.Dequeue();
            }
            stk.Push(i);   
        }

        while(stk.Count > 0)
        {
            if(stk.Peek() == q.Peek())
            {
                q.Dequeue();
            }
            stk.Pop();
        }

        if(q.Count > 0)
            return false;
        return true;
    }
}