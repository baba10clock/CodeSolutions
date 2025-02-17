public class MyQueue {
    private Stack<int> first;
    private Stack<int> second;
    public MyQueue() {
        first = new Stack<int>();
        second = new Stack<int>();
    }
    
    public void Push(int x) {
        
        while(second.Count > 0)
        {
            first.Push(second.Pop());
        }
        first.Push(x);
        while(first.Count > 1)
        {
            second.Push(first.Pop());
        }
    }
    
    public int Pop() {
        var temp = first.Pop();
        if(first.Count == 0 && second.Count > 0)
        {
            first.Push(second.Pop());
        }
        return temp;
    }
    
    public int Peek() {
        return first.Peek();
    }
    
    public bool Empty() {
        if(first.Count == 0 && second.Count == 0)   return true;
        return false;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */