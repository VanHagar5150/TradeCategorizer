using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HighRiskCategory : ITradeCategory
{
    public string Classify(ITrade trade, DateTime referenceDate)
    {
        if (trade.Value > 1000000 && trade.ClientSector == "Private" && !trade.IsPoliticallyExposed)
        {
            return "HIGHRISK";
        }
        return null;
    }
}
