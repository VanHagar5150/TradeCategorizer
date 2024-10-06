using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Trade : ITrade
{
    public double Value { get; private set; }
    public string ClientSector { get; private set; }
    public DateTime NextPaymentDate { get; private set; }
    public bool IsPoliticallyExposed { get; private set; }

    public Trade(double value, string clientSector, DateTime nextPaymentDate, bool isPoliticallyExposed)
    {
        Value = value;
        ClientSector = clientSector;
        NextPaymentDate = nextPaymentDate;
        IsPoliticallyExposed = isPoliticallyExposed;
    }
}
