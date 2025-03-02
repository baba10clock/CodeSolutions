public class Solution {
    public bool IsPowerOfTwo(int n) {
        var log = Math.Log2(n);
        return log == (int)log ? true : false; 
    }
}