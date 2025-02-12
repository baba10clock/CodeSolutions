public class Solution {
    public int MaxProfit(int[] prices) {
        int i = 0, j = 0, profit = 0;

        while(i <= j && j < prices.Length)
        {
            if(prices[j] < prices[i])
            {
                i = j;
            }
            if(prices[j] > prices[i])
            {
                profit = Math.Max(profit, prices[j] - prices[i]);
            }
            j++;
        }
        return profit;
    }
}