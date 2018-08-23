using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");


            List<(string ticker, int shares, double price)> purchases = new List<(string, int, double)>();

            purchases.Add((ticker: "GM", shares: 150, price: 23.21));
            purchases.Add((ticker: "GM", shares: 32, price: 17.87));
            purchases.Add((ticker: "GM", shares: 80, price: 19.02));

            Dictionary<string, double> purchaseInfo = new Dictionary<string, double>();


            /*
            Define a new Dictionary to hold the aggregated purchase information.
            - The key should be a string that is the full company name.
            - The value will be the valuation of each stock (price*amount)

            {
            "General Electric": 35900,
            "AAPL": 8445,
            ...
            }
            */

            // Iterate over the purchases and update the valuation for each stock
            foreach ((string ticker, int shares, double price) purchase in purchases)
            {
                if (purchaseInfo.ContainsKey(stocks[purchase.ticker]))
                {
                    purchaseInfo[stocks[purchase.ticker]] += purchase.shares * purchase.price;
                }
                else
                {
                    purchaseInfo[stocks[purchase.ticker]] = purchase.shares * purchase.price;
                }
                // Does the company name key already exist in the report dictionary?

                // If it does, update the total valuation

                // If not, add the new key and set its value
            }
            foreach (KeyValuePair<string, double> item in purchaseInfo)
            {
                Console.WriteLine($"{item.Key}: ${item.Value}");
            }


        }
    }
}
