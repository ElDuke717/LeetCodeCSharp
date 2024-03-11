using System;

namespace LeetCodeSolutions
{
    public class GasStation
    {
        public static void Run()
        {
            int[] gas1 = {1,2,3,4,5};
            int[] gas2 = {2,3,4};
            int[] cost1 = {3,4,5,1,2};
            int[] cost2 = {3,4,3};

            int result1 = GoAround(gas1, cost1); // Call GoAround once and store the result
            int result2 = GoAround(gas2, cost2);

            Console.WriteLine(
                result1 >= 0 
                ? $"If you have gas stations with {String.Join(", ", gas1)} gas at each station with cost between stations {String.Join(", ", cost1)}, you can complete the circuit starting at index {result1}"
                : $"If you have {String.Join(", ", gas1)} station with cost {String.Join(", ", cost1)}, you cannot complete the circuit."
            );
            Console.WriteLine(
                result2 >= 0 
                ? $"If you have gas stations with {String.Join(", ", gas2)} gas at each station with cost between stations {String.Join(", ", cost2)}, you can complete the circuit starting at index {result2}"
                : $"If you have {String.Join(", ", gas2)} station with cost {String.Join(", ", cost2)}, you cannot complete the circuit."
            );
        }

        public static int GoAround(int[] gas, int[] cost)
        {
            int totalGas = 0; // Total amount of gas available
            int totalCost = 0; // Total cost to travel between all stations
            int start = 0; // Starting gas station index
            int tank = 0; // Current gas in the tank
        
            // Iterate through all gas stations
            for (int i = 0; i < gas.Length; i++) {
            totalGas += gas[i]; // Add gas available at current station to total gas
            totalCost += cost[i]; // Add cost to move to next station to total cost
            tank += gas[i] - cost[i]; // Update tank gas after reaching the next station
        
            // If tank is negative, you can't reach the next station from the current starting point
            if (tank < 0) {
                start = i + 1; // Update start to the next station
                tank = 0; // Reset tank because you're starting afresh from the next station
            }
            }
        
            // After checking all stations, if total gas is less than total cost,
            // it's impossible to complete the circuit
            if (totalGas < totalCost) {
            return -1;
            } else {
            // Otherwise, return the starting station index
            return start;
            }
        }
    }
}