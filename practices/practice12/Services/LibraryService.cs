using practice12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice12.Services;

public static class LibraryService
{
    public static void BorrowBook(int memberId, int bookId)
    {
        Member member = MemberService.GetMemberById(memberId);

        if (member == null)
        {
            Console.WriteLine("Member not found");
            return;
        }

        Book book = BookService.GetBookById(bookId);

        if (book == null)
        {
            Console.WriteLine("Book not found");
            return;
        }

        if (book.IsBorrowed)
        {
            Console.WriteLine("Book is already borrowed");
            return;
        }

        book.IsBorrowed = true;
        book.BorrowedByMemberId = memberId;

        Console.WriteLine("Book borrowed successfully");
    }

    public static void ReturnBook(int bookId)
    {
        Book book = BookService.GetBookById(bookId);

        if (book == null)
        {
            Console.WriteLine("Book not found");
            return;
        }

        if (!book.IsBorrowed)
        {
            Console.WriteLine("Book is not borrowed");
            return;
        }

        book.IsBorrowed = false;
        book.BorrowedByMemberId = null;

        Console.WriteLine("Book returned successfully");
    }
}
