public class Solution {
    int profit=0;
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];

        for (int i=1; i<prices.Length; i++){
            int tempProfit= prices[i]-minPrice;
            profit = Math.Max(profit, tempProfit);
            minPrice=Math.Min(minPrice,prices[i]);
        }
        return profit;
    }
}
