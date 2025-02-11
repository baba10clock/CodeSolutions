public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)    return false;
        var sMap = new Dictionary<char, int>();
        var tMap = new Dictionary<char, int>();
        foreach(var i in s)
        {
            sMap[i] = (sMap.ContainsKey(i) ? sMap[i] : 0) + 1;
        }

        foreach(var i in t)
        {
            tMap[i] = (tMap.ContainsKey(i) ? tMap[i] : 0) + 1;
        }

        foreach(var key in sMap.Keys)
        {
            if(tMap.ContainsKey(key))
            {
                if(sMap[key] != tMap[key]) return false;
            }
            else
                return false;
        }

        return true;
    }
}