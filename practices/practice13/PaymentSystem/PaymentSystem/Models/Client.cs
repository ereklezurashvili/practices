using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystem.Models;

public class Client
{
    public Guid Id;
    public string FirstName;
    public string LastName;
    public string PrivateNumber;
    public string PhoneNumber;
    public DateTime CreatedOn;

}
