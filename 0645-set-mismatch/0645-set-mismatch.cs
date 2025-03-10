public class Solution {
    public int[] FindErrorNums(int[] nums) {
        var boolArr = new bool [nums.Length + 1];
        var res = new int [2];
        foreach(var i in nums)
        {
            if(boolArr[i] == true)
                res[0] = i;
            boolArr[i] = true;
        }

        for(int i = 1; i < nums.Length + 1; i++)
        {
            if(boolArr[i] == false)
            {
                res[1] = i;
                break;
            }
        }
        return res;
    }
}