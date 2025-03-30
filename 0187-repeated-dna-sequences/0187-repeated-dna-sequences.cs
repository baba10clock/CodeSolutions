public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        var map = new Dictionary<string, int>();
        var res = new List<string>();
        for(int i = 0; i < s.Length - 9; i++)
        {
            var subStr = s[i..(i+10)];
            map[subStr] = map.GetValueOrDefault(subStr) + 1;
            if(!res.Contains(subStr) && map[subStr] > 1)
            {
                res.Add(subStr);
            }
        }
        return res;
    }
}