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

                stk.Push(stk.ToArray()[0] + stk.ToArray()[1]);
            }
            else
            {
                stk.Push(int.Parse(ops));
            }
            Console.WriteLine(stk.Count > 0 ? stk.Peek() : 0);
       }
       return stk.Count > 0 ? stk.Sum() : 0;
    }
}