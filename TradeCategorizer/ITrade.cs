using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ITrade
{
    double Value { get; } //indicates the transaction amount in dollars
    string ClientSector { get; } //indicates the client´s sector which can be "Public" or "Private"3
    DateTime NextPaymentDate { get; } //indicates when the next payment from the client to the bank is expected
    bool IsPoliticallyExposed { get; } //indicates the client´s sector is PEP (Politically Exposed Person)
}
