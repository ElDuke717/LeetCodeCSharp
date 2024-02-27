using System;

namespace LeetCodeSolutions
{
    public class BestTimeToBuyAndSellStock
    {
        public static void Run()
        {
            int[] prices = {7, 1, 5, 3, 6, 4}; // Example input
            int maxProfit = CalculateMaxProfit(prices);

            Console.WriteLine($"Maximum profit: {maxProfit}");
        }

        public static int CalculateMaxProfit(int[] prices)
        {
            if (prices == null || prices.Length < 2) return 0;

            int minPrice = prices[0]; // Initialize minPrice to the first price
            int maxProfit = 0; // Initialize maxProfit to 0

            for (int i = 1; i < prices.Length; i++)
            {
                // If the current price is less than minPrice, update minPrice
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if (prices[i] - minPrice > maxProfit) // If selling today would give more profit than maxProfit, update it
                {
                    maxProfit = prices[i] - minPrice;
                }
            }

            return maxProfit;
        }
    }
}
