using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice12.Models;

internal class Member
{
    public int Id;
    public string FirstName;
    public string LastName;
    public int Age;
    public string Email;
    public string PersonalNumber;
    public DateTime CreatedOn;

    public void PrintInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"First Name: {FirstName}");
        Console.WriteLine($"Last Name: {LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Personal Number: {PersonalNumber}");
        Console.WriteLine($"Created On: {CreatedOn.Date.ToShortDateString()}");
    }
}
