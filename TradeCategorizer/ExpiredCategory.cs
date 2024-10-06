using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ExpiredCategory : ITradeCategory
{
    public string Classify(ITrade trade, DateTime referenceDate)
    {
        if (trade.NextPaymentDate < referenceDate.AddDays(-30) && !trade.IsPoliticallyExposed)
        {
            return "EXPIRED";
        }
        return null;
    }
}
