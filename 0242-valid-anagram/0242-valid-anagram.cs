public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        var res = new int[26];
        foreach(var i in s)
        {
            res[i - 'a']++;
        } 
        foreach(var i in t)
        {
            if(--res[i - 'a'] < 0)
            {
                return false;
            }
        }
        return true;
    }
}