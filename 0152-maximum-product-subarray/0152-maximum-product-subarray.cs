public class Solution {
    public int MaxProduct(int[] nums) {
        int res = nums[0], maxx = nums[0], minn = nums[0];
        for(var i = 1; i < nums.Length; i++)
        {
            var num = nums[i];
            if(num < 0)
            {
                (maxx, minn)=(minn, maxx);
            }

            maxx = Math.Max(num, maxx * num);
            minn = Math.Min(num, minn * num);

            res = Math.Max(res, maxx);
        }
        return res;
    }
}