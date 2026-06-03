using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using practice12.Models;

namespace practice12.Services;

internal static class MemberService
{
    private static Member[] members = new Member[100];
    private static int count = 0;

    public static void Initialize()
    {
        members[count] = new Member
        {
            Id = 1,
            FirstName = "Giorgi",
            LastName = "Beridze",
            Age = 25,
            Email = "giorgi@gmail.com",
            PersonalNumber = "12345678901",
            CreatedOn = DateTime.Now
        };

        count++;
    }

    public static void AddMember(
        string firstName,
        string lastName,
        int age,
        string email,
        string personalNumber)
    {
        members[count] = new Member
        {
            Id = count + 1,
            FirstName = firstName,
            LastName = lastName,
            Age = age,
            Email = email,
            PersonalNumber = personalNumber,
            CreatedOn = DateTime.Now
        };

        count++;
    }

    public static void GetAllMembers()
    {
        for (int i = 0; i < count; i++)
        {
            members[i].PrintInfo();
            Console.WriteLine("-------------------");
        }
    }

    public static void UpdateMember(
        int id,
        string firstName,
        string lastName,
        int age,
        string email,
        string personalNumber)
    {
        for (int i = 0; i < count; i++)
        {
            if (members[i].Id == id)
            {
                members[i].FirstName = firstName;
                members[i].LastName = lastName;
                members[i].Age = age;
                members[i].Email = email;
                members[i].PersonalNumber = personalNumber;

                Console.WriteLine("Member updated successfully.");
                return;
            }
        }

        Console.WriteLine("Member not found.");
    }

    public static void DeleteMember(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (members[i].Id == id)
            {
                for (int j = i; j < count - 1; j++)
                {
                    members[j] = members[j + 1];
                }

                members[count - 1] = null;
                count--;

                Console.WriteLine("Member deleted successfully.");
                return;
            }
        }

        Console.WriteLine("Member not found.");
    }

    public static Member GetMemberById(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (members[i].Id == id)
            {
                return members[i];
            }
        }

        return null;
    }
}
