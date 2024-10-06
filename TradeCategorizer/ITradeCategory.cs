using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ITradeCategory
{
    string Classify(ITrade trade, DateTime referenceDate);
}
