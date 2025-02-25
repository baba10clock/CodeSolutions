public class Solution {
    public string MergeAlternately(string word1, string word2) {
        var res = "";
        int len1 = word1.Length;
        int len2 = word2.Length;
        int i = 0, j = 0;
        while(i < len1 || j < len2)
        {
            if(i < len1)
            {
                res += word1[i];
                i++;
            }
            if(j < len2)
            {
                res += word2[j];
                j++;
            }
        }
        return res;
    }
}