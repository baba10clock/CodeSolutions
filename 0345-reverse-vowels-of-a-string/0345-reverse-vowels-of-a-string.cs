public class Solution {
    public string ReverseVowels(string s) {
        var set = new HashSet<char> {'a','e','i','o','u','A','O','I','E','U'};
        var word = s.ToCharArray();
        int i = 0, j = word.Length - 1;
        while(i <=j )
        {
            if(set.Contains(word[i]) && set.Contains(word[j]))
            {
                (word[i],word[j]) = (word[j],word[i]);
                i++;
                j--;
            }
            else if(!set.Contains(word[i]))
            {
                i++;
            }
            else
                j--;
            
            
        }
        return string.Join("", word);
    }
}