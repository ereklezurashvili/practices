using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Models;

public class Payment
{
    public Guid Id;
    public Guid FromAccountId;
    public Guid ToAccountId;
    public Decimal Amount;
    public string Currency;
    public string purpose;


}
