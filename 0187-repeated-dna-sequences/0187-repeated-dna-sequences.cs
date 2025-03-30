public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        var map = new Dictionary<string, int>();
        for(int i = 0; i < s.Length - 9; i++)
        {
            var subStr = s[i..(i+10)];
            map[subStr] = map.GetValueOrDefault(subStr) + 1;
        }

        var res = new List<string>();
        foreach(var i in map.Keys)
        {
            if(map[i] > 1)
            {
                res.Add(i);
            }
        }
        return res.ToArray();
    }
}