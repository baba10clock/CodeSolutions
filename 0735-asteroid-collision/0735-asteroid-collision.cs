public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        var stk = new Stack<int>();
        for(int i = 0; i < asteroids.Length; i++)
        {
            var a = asteroids[i];
            while(stk.Count > 0 && a < 0 && stk.Peek() > 0)
            {
                var diff = a + stk.Peek();
                if(diff < 0)
                    stk.Pop();
                else if(diff > 0)
                    a = 0;
                else
                {
                    a = 0;
                    stk.Pop();
                }
            }
            if(a != 0)
                stk.Push(a);
        }
        return stk.Reverse().ToArray();
    }
}