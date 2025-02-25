public class Solution {
    public char FindTheDifference(string s, string t) {
        var smap = new Dictionary<char, int>();
        foreach(var i in s)
        {
            smap[i] = smap.GetValueOrDefault(i) + 1;
        }
        foreach(var i in t)
        {
            if(smap.ContainsKey(i))
            {
                if(smap[i] == 0)    return i;
                smap[i]--;
            }
            else
            {
                return i;
            }
        }
        return 'i';
    }
}