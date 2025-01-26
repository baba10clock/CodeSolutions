public class Solution {
    public int MaxNumberOfBalloons(string text) {
        var map = new Dictionary<char, int>();
        foreach(var i in text)
        {
            map[i] = (map.ContainsKey(i) ? map[i] : 0) + 1;
        }
        
        int b = map.ContainsKey('b') ? map['b'] : 0;
        int a = map.ContainsKey('a') ? map['a'] : 0;
        int l = map.ContainsKey('l') ? map['l'] : 0;
        int o = map.ContainsKey('o') ? map['o'] : 0;
        int n = map.ContainsKey('n') ? map['n'] : 0;


        l /= 2;
        o /= 2;

        return Math.Min(b, Math.Min(a, Math.Min(l, Math.Min(o,n))));
    }
}