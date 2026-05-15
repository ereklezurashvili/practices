using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice_15.Forms;
using practice_15.Models;

namespace practice_15.Services;

internal class UserService
{
  
    public static int idx = 0;
    public static List<User> Users=new List<User>();
    public static void RegisterUser(User user)
    {

        Users.Add(user);
    }
    public static bool AuthenticateUser(string username,string password)
    {
        
        bool found = false;
        for (int i = 0; i < Users.Count; i++)
        {

            {
                if (Users[i].Username == username &&
                    Users[i].Password == password)
                {
                    idx = i;
                    found = true;

                    return found;
                }
            }
        }
        return false;
    }
}
