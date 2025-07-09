public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var res = new List<IList<int>>();
        var local = new List<int>();
        void FindComb(int index, int currTarget)
        {
            if(currTarget == 0)
            {
                res.Add(new List<int>(local));
                return;
            }
            if(currTarget < 0)
            {
                return;
            }

            for(int i = index; i < candidates.Length; i++)
            {
                int val = candidates[i];
                local.Add(val);
                //currTarget -= val
                FindComb(i, currTarget - val); // currTarget
                local.RemoveAt(local.Count - 1);
            }
        }
        FindComb(0, target);
        return res;
    }
}