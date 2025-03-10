public class Solution {
    public int MySqrt(int x) {
        if(x == 1 || x == 2 || x == 3)    return 1;
        int l = 1, r = x;
        while( l <= r)
        {
            var m = l + (r - l)/2;
            long sqr = (long)m * m; 
            if(sqr == x)
            {
                return m;
            }
            else if ( sqr > x)
                r = m - 1;
            else
                l = m + 1;
        }
        return r;
    }
}