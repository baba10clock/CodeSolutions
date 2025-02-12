public class MyStack {
    private Queue<int> q;
    public MyStack() {
        q = new Queue<int>();
    }
    
    public void Push(int x) {
        var len = q.Count;
        q.Enqueue(x);
        for(int i = 0; i < len; i++)
        {
            q.Enqueue(q.Dequeue());
        }
    }
    
    public int Pop() {
        return q.Dequeue();
    }
    
    public int Top() {
        return  q.Peek();
    }
    
    public bool Empty() {
        return q.Count > 0 ? false : true;
        
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */