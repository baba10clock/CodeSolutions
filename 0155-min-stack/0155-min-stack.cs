public class MinStack {
    private Stack<int> stk;
    private Stack<int> minStk;
    public MinStack() {
        stk = new Stack<int>();
        minStk = new Stack<int>();
    }
    
    public void Push(int val) {
        stk.Push(val);
        if(minStk.Count == 0 || minStk.Peek() >= val)
        {
            minStk.Push(val);
        }
        
    }
    
    public void Pop() {
        if(stk.Peek() == minStk.Peek())
        {
            minStk.Pop();
        }
        stk.Pop();
      
    }
    
    public int Top() {
        return stk.Peek();
    }
    
    public int GetMin() {
        return minStk.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */