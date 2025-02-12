public class Solution {
    public int MaxProfit(int[] prices) {
        int profit = 0, buy = prices[0];
        foreach(var value in prices)
        {
            profit = Math.Max(profit, value - buy);
            buy = Math.Min(buy,value);
        }
        return profit;
    }
}