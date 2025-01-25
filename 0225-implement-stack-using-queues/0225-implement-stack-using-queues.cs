public class MyStack {

    private Queue<int> q1;
    private Queue<int> q2;
    public MyStack() {
        q1 = new Queue<int>();
        q2 = new Queue<int>();
    }
    
    public void Push(int x) {
        q1.Enqueue(x);
        q2.Enqueue(x);
    }
    
    public int Pop() {
        while(q2.Count != 1)
        {
            q2.Dequeue();
        }
        var res = q2.Dequeue();
       
        var size = q1.Count - 1;
        for(int i = 0; i < size; i++)
        {
            q2.Enqueue(q1.Dequeue());
        }
        q1 = new Queue<int>(q2);
        return res;
    }
    
    public int Top() {
        while(q2.Count != 1)
        {
            q2.Dequeue();
        }
        var res = q2.Dequeue();
        q2 = new Queue<int>(q1);
        return res;
    }
    
    public bool Empty() {
       
        if (q1.Count == 0) 
            return true;
        return false;
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