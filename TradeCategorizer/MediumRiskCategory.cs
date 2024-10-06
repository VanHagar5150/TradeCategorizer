using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MediumRiskCategory : ITradeCategory
{
    public string Classify(ITrade trade, DateTime referenceDate)
    {
        if (trade.Value > 1000000 && trade.ClientSector == "Public" && !trade.IsPoliticallyExposed)
        {
            return "MEDIUMRISK";
        }
        return null;
    }
}