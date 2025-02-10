public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        if(strs == null || strs.Length == 0) return "";
        for(int i = 0; i < strs[0].Length; i++)
        {
            foreach(var curr in strs)
            {
                if(i == curr.Length || curr[i] != strs[0][i])
                {
                    return curr.Substring(0, i);
                }
            }
        }
        return strs[0];
    }
}