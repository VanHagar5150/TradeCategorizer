using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PEPCategory : ITradeCategory
{
    public string Classify(ITrade trade, DateTime referenceDate)
    {
        if (trade.IsPoliticallyExposed)
        {
            return "PEP";
        }
        return null;
    }
}