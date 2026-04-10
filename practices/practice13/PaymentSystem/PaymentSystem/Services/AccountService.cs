using PaymentSystem.Interface;
using PaymentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PaymentSystem.Services;

public class AccountService : IService<Account>
{
    public List<Account> Accounts = new List<Account>();
    public long accnum = 0;
    public int numberofdigits = 0;
    public string accnumstring="";
  
    public void Add(Account Account)
    {
        Accounts.Add(Account);

    }
    public List<Account> GetAll()
    {
        return Accounts;

    }
    public Account GetById(Guid Id)
    {
        foreach (Account Account in Accounts)
        {
            if (Account.Id == Id) return Account;
        }
        return null;

    }
    public void Update(Guid Id, Account newAccount)
    {
        for (int i = 0; i < Accounts.Count; i++)
        {
            if (Accounts[i].Id == Id)
            {
                Accounts[i] = newAccount;
            }
        }

    }
    public void Delete(Guid Id)
    {
        for (int i = 0; i < Accounts.Count; i++)
        {
            if (Accounts[i].Id == Id)
            {
                Accounts.RemoveAt(i);
            }
        }

    }

    public void CreateAccount(Guid clientid,string currency,decimal balance)
    {
        accnum++;
        if (accnum / 10 == 0)
        {
            numberofdigits = 1;

        }
        else if(accnum / 100 == 0) 
        {
                numberofdigits = 2;
            
        }
        else if (accnum / 1000 == 0)
        {
            numberofdigits = 3;

        }
        else if (accnum / 10000 == 0)
        {
            numberofdigits = 4;

        }
        else if (accnum / 100000 == 0)
        {
            numberofdigits = 5;

        }
        else if (accnum / 1000000 == 0)
        {
            numberofdigits = 6;

        }
        else if (accnum / 10000000 == 0)
        {
            numberofdigits = 7;

        }
        else if (accnum / 100000000 == 0)
        {
            numberofdigits = 8;

        }
        else if (accnum / 1000000000 == 0)
        {
            numberofdigits = 9;

        }
        else if (accnum / 10000000000 == 0)
        {
            numberofdigits = 10;

        }
        


        Account account = new Account();
        account.Id = Guid.NewGuid();
        account.ClientId=clientid;
        account.Currency = currency;
        account.Balance = balance;
        account.CreatedOn = DateTime.Now;
        accnumstring = accnum.ToString();
        account.AccountNo = (10 - numberofdigits) * '0' + accnumstring + currency;


    }
    
}
