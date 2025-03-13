public class Solution {
    public string LargestGoodInteger(string num) {
        int i = 0, j = 1, k = 2;
        var lst = new List<string>();
        var res = "0";
        while(k < num.Length)
        {
            if(num[i] == num[j] && num[j] == num[k])
            {
                var temp = string.Concat(num[i],num[j], num[k]);
                if(int.TryParse(temp, out int val1) && int.TryParse(res, out int val2))
                {
                    if(val1 >= val2)
                        res = temp;
                }
            }
            i++;
            j++;
            k++;
        }
        return res == "0" ? "" : res;
    }
}