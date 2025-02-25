public class Solution {
    public int LengthOfLastWord(string s) {
        var res = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        return res[res.Length - 1].Length;
    }
}