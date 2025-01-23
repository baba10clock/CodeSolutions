public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        if(gas.Sum() < cost.Sum())
        {
            return -1;
        }
        int tank = 0;
        int startIdx = 0;
        for(int i = 0; i < gas.Length; i++)
        {
            tank += (gas[i] - cost[i]);
            if(tank < 0)
            {
                tank = 0;
                startIdx = i + 1;
            }
        }
        return startIdx;
    }
}