public class Solution {
    public int MissingNumber(int[] nums) {
        var set = new HashSet<int>(nums);
        var len = nums.Length;
        int i = 0;
        for(i = 0; i < len; i++)
        {
        if(!set.Contains(i))    return i;
        }   
        return i;
    }
  
}