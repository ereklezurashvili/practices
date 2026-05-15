using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practice_15.Models;

public class User
{
    public User(string name,string email,string phone,string username,string password) 
    {
        Username = username;
        Password = password;
        Email = email;
        Phone = phone;
        Name = name;
           
    }


    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
}
         
    
