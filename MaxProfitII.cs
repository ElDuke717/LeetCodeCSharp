using System;

namespace LeetCodeSolutions
{

    public class MaxProfitII
    {
        public static void Run()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 }; // Example input
            int maxProfit = CalculateMaxProfit(prices);

            Console.WriteLine($"Maximum profit: {maxProfit}");
        }

        public static int CalculateMaxProfit(int[] prices)
        {
            // edge case
            if (prices == null || prices.Length < 2) return 0;

            int totalProfit = 0; // Initialize maxProfit to 0

            for (int i = 0; i < prices.Length - 1; i++)
            {
                // If the current price is greater than the previous price, add the difference to maxProfit
                if (prices[i] < prices[i + 1])
                {
                    totalProfit += prices[i + 1] - prices[i];
                }
            }

            return totalProfit;
        }
    }
    
}