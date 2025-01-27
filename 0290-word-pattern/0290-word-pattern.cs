public class Solution {
    public bool WordPattern(string pattern, string s) {
        if(pattern.Length != s.Split(" ").Length) return false;
        var map = new Dictionary<char, string>();
        var rMap = new Dictionary<string, char>();
        var sArr = s.Split(" ");

        for(int i = 0; i < pattern.Length; i++ )
        {
            if(map.ContainsKey(pattern[i]))
            {
                if(map[pattern[i]] != sArr[i])
                {
                    return false;
                }
            }
            else
            {
                map[pattern[i]] = sArr[i];
            }


            if(rMap.ContainsKey(sArr[i]))
            {
                if(rMap[sArr[i]] != pattern[i])
                {
                    return false;
                }
            }
            else
            {
                rMap[sArr[i]] = pattern[i];
            }
        }
        return true;

    }
}