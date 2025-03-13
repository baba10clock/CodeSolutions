public class Solution {
    public string LargestGoodInteger(string num) {
        string [] nums = new string [] {"999", "888", "777", "666", "555", "444", "333", "222", "111", "000"};
        foreach(var i in nums)
        {
            if(num.Contains(i))
                return i;
        } 
        return "";
    }

}