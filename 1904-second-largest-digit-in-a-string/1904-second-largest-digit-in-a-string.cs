public class Solution {
    public int SecondHighest(string s) {
        int maxx = -1, secMaxx = -1;
        foreach(var i in s)
        {
            if(char.IsDigit(i))
            {
                var val = i - '0';
                if(val > maxx)
                {
                    secMaxx = maxx;
                    maxx = val;
                }
                else if(val > secMaxx && val != maxx)
                {
                    secMaxx = val;
                }
            }
        }
        return secMaxx;
    }
}