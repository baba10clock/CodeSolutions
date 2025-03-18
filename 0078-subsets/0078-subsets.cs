public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var res = new List<IList<int>>();
        var subset = new List<int>();
        dfs(nums, 0, res, subset);
        return res;
    }
    public void dfs(int [] nums, int i, List<IList<int>> res, List<int> subset)
    {
        if(i >= nums.Length)
        {
            res.Add(new List<int>(subset));
            return;
        }
        subset.Add(nums[i]);
        dfs(nums, i + 1, res, subset);
        subset.RemoveAt(subset.Count - 1);
        dfs(nums, i + 1, res, subset);
    }
}