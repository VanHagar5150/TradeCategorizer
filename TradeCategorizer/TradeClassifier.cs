using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TradeClassifier
{
    private List<ITradeCategory> _categories;

    public TradeClassifier(List<ITradeCategory> categories)
    {
        _categories = categories;
    }

    public string ClassifyTrade(ITrade trade, DateTime referenceDate)
    {
        foreach (var category in _categories)
        {
            var result = category.Classify(trade, referenceDate);
            if (result != null)
            {
                return result;
            }
        }
        return "UNCATEGORIZED";
    }
}