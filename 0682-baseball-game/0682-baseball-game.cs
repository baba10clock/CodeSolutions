public class Solution {
    public int CalPoints(string[] operations) {
        var stk = new Stack<int>();
       foreach(var ops in operations)
       {    
            if(ops == "C")
            {
                stk.Pop();
            }
            else if(ops == "D")
            {
                stk.Push(stk.Peek() * 2);
            }
            else if(ops == "+")
            {
                int x = stk.Pop();
                int y = stk.Peek();
                stk.Push(x);
                stk.Push(x + y);
            }
            else
            {
                stk.Push(int.Parse(ops));
            }
       }
       return stk.Count > 0 ? stk.Sum() : 0;
    }
}