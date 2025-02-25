public class Solution {
    public char FindTheDifference(string s, string t) {
        var res = '\0';
        foreach(var i in s) res ^= i;
        foreach(var i in t) res ^= i;
        return res;
    }
}