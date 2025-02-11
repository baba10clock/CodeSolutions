public class Solution {
    public void ReverseString(char[] s) {
        int l = 0, r = s.Length -1;
        while(l <= r)
        {
            (s[l], s[r]) = (s[r], s[l]);
            r--;
            l++;
        }

    }
}