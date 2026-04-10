using PaymentSystem.Interface;
using PaymentSystem.Models;
using PaymentSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
namespace PaymentSystem.Services;

public class ClientService : IService<Client> 
{
    public List<Client> Clients=new List<Client>();

    public void Add(Client client)
    {
        Clients.Add(client);

    }
    public  List<Client> GetAll()
    {
        return Clients;

    }
    public Client GetById(Guid Id)
    {
        foreach (Client client in Clients)
        {
            if(client.Id == Id) return client;
        }
        return null;

    }
    public void Update(Guid Id, Client newclient)
    {
        for(int i=0; i<Clients.Count; i++)
        {
            if(Clients[i].Id == Id)
            {
                Clients[i]=newclient;
            }
        }

    }
    public void Delete(Guid Id)
    {
        for (int i = 0; i < Clients.Count; i++)
        {
            if (Clients[i].Id == Id)
            {
                Clients.RemoveAt(i);
            }
        }

    }
    public void RegisterClient(string firstname,string lastname,string privatenumber,string phonenumber)
    {
       
        Client client = new Client();
        client.FirstName=firstname;
        client.LastName=lastname;
        client.PrivateNumber = privatenumber;
        client.PhoneNumber = phonenumber;
        client.Id = Guid.NewGuid();
        client.CreatedOn = DateTime.Now;
        Clients.Add(client);

    }
}
