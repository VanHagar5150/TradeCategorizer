using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide the file path as a command line argument.");
            return;
        }

        string filePath = args[0];

        // Check if the file exists
        if (!File.Exists(filePath))
        {
            Console.WriteLine("The file does not exist.");
            return;
        }

        // Read file content
        string[] lines = File.ReadAllLines(filePath);

        // Parse reference date from the first line
        DateTime referenceDate = DateTime.Parse(lines[0]);

        // Parse number of trades
        int n = int.Parse(lines[1]);
        List<ITrade> trades = [];

        // Loop through the trades
        for (int i = 2; i < n + 2; i++)
        {
            string[] tradeInput = lines[i].Split(' ');
            double value = double.Parse(tradeInput[0]);
            string clientSector = tradeInput[1];
            DateTime nextPaymentDate = DateTime.Parse(tradeInput[2]);
            bool isPoliticallyExposed = clientSector == "PEP" ? true : false;
            trades.Add(new Trade(value, clientSector, nextPaymentDate, isPoliticallyExposed));
        }

        // Create a list of categories for classification
        var categories = new List<ITradeCategory>
        {
            new ExpiredCategory(),
            new HighRiskCategory(),
            new MediumRiskCategory(),
            new PEPCategory()
        };

        // Classify trades
        var classifier = new TradeClassifier(categories);

        foreach (var trade in trades)
        {
            Console.WriteLine(classifier.ClassifyTrade(trade, referenceDate));
        }
    }
}