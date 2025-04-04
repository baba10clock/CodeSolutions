public class Solution {
    public int MinimumLength(string s) {
        int len = s.Length;
        int pre = 0, suf = len - 1;
        while(pre < suf)
        {
            while(pre + 1 < suf && s[pre] == s[pre + 1])
                pre++;
            while(suf - 1 > pre && s[suf] == s[suf - 1])
                suf--;
            if(s[pre] == s[suf])
            {
                pre++;
                suf--;
            }
            if(s[pre] != s[suf])
                break;
        }
        return suf - pre + 1;
    }
}