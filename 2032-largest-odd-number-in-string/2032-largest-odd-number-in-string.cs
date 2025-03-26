public class Solution {
    public string LargestOddNumber(string num) {
        var res = "";
        for(int i = num.Length - 1; i >=0 ; i--)
        {
            if(char.IsDigit(num[i]))
            {
                if((num[i] - '0') % 2 != 0)
                {
                    return num.Substring(0, i+1);
                }
            }
        }
        return res;
    }
}