using PaymentSystem.Interface;
using PaymentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PaymentSystem.Services;

public class PaymentService : IService<Payment>
{
    decimal bal = 0;
    string cur1 = "";
    string cur2 = "";
    public List<Payment> Payments = new List<Payment>();
    public void Add(Payment payment)
    {
        Payments.Add(payment);

    }
    public List<Payment> GetAll()
    {
        return Payments;

    }
    public Payment GetById(Guid Id)
    {
        foreach (Payment payment in Payments)
        {
            if (payment.Id == Id) return payment;
        }
        return null;

    }
    public void Update(Guid Id, Payment newclient)
    {
        for (int i = 0; i < Payments.Count; i++)
        {
            if (Payments[i].Id == Id)
            {
                Payments[i] = newclient;
            }
        }

    }
    public void Delete(Guid Id)
    {
        for (int i = 0; i < Payments.Count; i++)
        {
            if (Payments[i].Id == Id)
            {
                Payments.RemoveAt(i);
            }
        }

    }

    public void Transfer(Guid fromaccid,Guid toaccid,decimal amount,string currency,string purpose)
    {
        AccountService accountService = new AccountService();
        foreach(Account account in accountService.Accounts)
        {
            if(account.Id == fromaccid)
            {
                bal=account.Balance;
                cur1=account.Currency;
            }
            if(account.Id == toaccid)
            {
                cur2=account.Currency;
            }
        }
        if (cur1 == cur2 || bal>=amount)
        {
            foreach (Account account in accountService.Accounts)
            {
                if (account.Id == fromaccid)
                {
                    account.Balance-=amount;
                }
                if (account.Id == toaccid)
                {
                    account.Balance+=amount;
                }
            }
            Console.WriteLine("transfer made");
            Payment payment = new Payment();
            payment.Currency = currency;
            payment.Amount = amount;    
            payment.purpose = purpose;
            payment.FromAccountId = fromaccid;
            payment.ToAccountId = toaccid;
            payment.Id=Guid.NewGuid();
            Payments.Add(payment);

        }
        else
        {
            Console.WriteLine("transfer cant be made");
        }
        

    }

}
