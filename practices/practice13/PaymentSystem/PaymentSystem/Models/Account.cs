using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Models;

public class Account
{
    public Guid Id;
    public Guid ClientId;
    public string AccountNo;
    public string Currency;
    public Decimal Balance;
    public DateTime CreatedOn;


}
