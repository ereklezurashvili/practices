using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice12.Models;

public class Book
{
    public int Id;
    public string Title;
    public string Author;
    public string Genre;
    public int PublishedYear;
    public bool IsBorrowed;
    public int? BorrowedByMemberId;

    public void PrintInfo()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Published Year: {PublishedYear}");
        Console.WriteLine($"Is Borrowed: {IsBorrowed}");
        Console.WriteLine($"BorrowedByMemberId: {BorrowedByMemberId}");
    }


}
