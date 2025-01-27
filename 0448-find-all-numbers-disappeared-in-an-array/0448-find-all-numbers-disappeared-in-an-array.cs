public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        var set = new HashSet<int>(nums);
        var res = new List<int>();
        if(set.Count < nums.Length)
        {
            for(int i = 1; i <= nums.Length; i++)
            {
                if(!set.Contains(i))
                {
                    res.Add(i);
                }
            }
        }
        return res;
    }
}