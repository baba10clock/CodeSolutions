public class Solution {
    public int ArraySign(int[] nums) {
        int countN = 0;
        foreach(var i in nums)
        {
            if(i < 0) countN++;
            else if(i == 0) return 0;
        }
        if(countN % 2 == 0) return 1;
        return -1;
    }
}